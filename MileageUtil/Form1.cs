using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Xml;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using ExcelLibrary.SpreadSheet;
using System.Reflection;
using Microsoft.VisualBasic;
using System.Drawing;


namespace MileageUtil
{
    public partial class EntryForm : Form
    {
        private Workbook _workBook = null;                                  // current spreadsheet
        private string _spreadsheetPath = "";                               // file path of the currently loaded spreadsheed
        private const string _pathLabel = "Current Spreadsheet:\n";         // currently loaded spreadsheet label message
        private XmlDocument _config = null;                                 // our config.xml file
        private const string _configPath = "config/config.xml";
        private string _appPath = "";
        private string debugpath = "";
        private string _homePostcode = "";

        // comprehensive UK postcode regex supplied by UK Gov except optional space added.
        private const string _postcodeRegex = "(GIR 0AA)|((([A-Z-[QVX]][0-9][0-9]?)|(([A-Z-[QVX]][A-Z-[IJZ]][0-9][0-9]?)|(([A-Z-[QVX]][0-9][A-HJKSTUW])|([A-Z-[QVX]][A-Z-[IJZ]][0-9][ABEHMNPRVWXY])))) ?[0-9][A-Z-[CIKMOV]]{2})";


        public EntryForm ()
        {
            InitializeComponent();
        }


        // Initialization. Called before application is rendered for 1st time.
        private void OnFormLoaded (object sender, EventArgs e)
        {
            _appPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            debugpath = Directory.GetParent(_appPath).Parent.FullName;

            // load settings (xml)
            _config = new XmlDocument();
            LoadConfig();

            monthCalendar.MaxSelectionCount = 1;
            currentPath.Text = _pathLabel + _spreadsheetPath;
        }


        private void AddPostCode (object sender, EventArgs e)
        {
            // if the text box isn't empty
            if (!string.IsNullOrEmpty(txtInput.Text))
            {
                if (ValidatePostcode(txtInput.Text))
                {
                    // add the entry to the listbox
                    postcodes.Items.Add(txtInput.Text);
                    // reset the text field
                    txtInput.Text = "";
                }
            }
        }

        private bool ValidatePostcode (string postcode)
        {
            var match = Regex.Match(postcode, _postcodeRegex);

            if (match.Success)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please use a valid postcode.\nUppercase required.");
                return false;
            }
        }


        private void CreateSpreadsheetDialogue (object sender, EventArgs e)
        {
            createSpreadsheetDialogue.FileName = "";
            createSpreadsheetDialogue.ShowDialog();
        }


        private void OpenSpreadsheetDialogue (object sender, EventArgs e)
        {
            openSpreadsheetDialogue.FileName = "";
            var result = openSpreadsheetDialogue.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openSpreadsheetDialogue.FileName;
                try
                {
                    _workBook = Workbook.Load(file);
                    _spreadsheetPath = openSpreadsheetDialogue.FileName;
                }
                catch(IOException ioExcep)
                {
                    MessageBox.Show("ERROR: " + ioExcep.ToString());
                    return;
                }

                currentPath.Text = _pathLabel + _spreadsheetPath;
            }
        }


        private void InsetMileageToSpreadsheet (object sender, EventArgs e)
        {
            if (_workBook.Worksheets[0] == null || string.IsNullOrEmpty(_spreadsheetPath))
            {
                MessageBox.Show("ERROR: There was no spreadsheet loaded.");
                LoadConfig();
                return;
            }

            // get the selected date
            var date = monthCalendar.SelectionRange.Start;

            // get the 1st worksheet from the spreadsheet
            Worksheet worksheet = _workBook.Worksheets[0];

            int y = worksheet.Cells.LastRowIndex + 2;
            int numPostcodes = postcodes.Items.Count;

            if (numPostcodes < 2)
            {
                MessageBox.Show("You need to add more postcodes");
                return;
            }

            for (int i = 0; i < numPostcodes - 1; i++)
            {
                worksheet.Cells[y, 0] = new Cell(date.Day + "/" + date.Month + "/" + date.Year);
                worksheet.Cells[y, 1] = new Cell(postcodes.Items[i]);
                worksheet.Cells[y, 2] = new Cell(postcodes.Items[i + 1]);
                worksheet.Cells[y, 3] = new Cell(GetDrivingDistanceInMiles((string) postcodes.Items[i], (string) postcodes.Items[i + 1]));

                y++;
            }

            // update the total mileage with all the cells in column D (Mileage)
            worksheet.Cells[2, 6] = new Cell(UpdateTotalMileageFromSpreadsheet());

            // try save the workbook
            try
            {
                _workBook.Save(_spreadsheetPath);
            }
            catch (IOException)
            {
                return;
            }

            MessageBox.Show("Spreadsheet successfully updated and saved.");
        }


        private void CreateSpreadsheet (object sender, CancelEventArgs e)
        {
            _spreadsheetPath = createSpreadsheetDialogue.FileName;
            currentPath.Text = _pathLabel + _spreadsheetPath;

            var worksheet = new Worksheet("Mileage");
            worksheet.Cells[0, 0] = new Cell("Date");
            worksheet.Cells[0, 1] = new Cell("From");
            worksheet.Cells[0, 2] = new Cell("To");
            worksheet.Cells[0, 3] = new Cell("Distance");
            worksheet.Cells[0, 6] = new Cell("Total");
            _workBook.Worksheets.Add(worksheet);

            _workBook.Save(_spreadsheetPath);
        }


        // Removes the last postcode from the list
        private void RemoveLastPostcode (object sender, EventArgs e)
        {
            if (postcodes.Items.Count > 0)
            {
                postcodes.Items.RemoveAt(postcodes.Items.Count - 1);
            }
        }


        // Removes all postcodes from the list
        private void ClearAllPostcodes (object sender, EventArgs e)
        {
            if (postcodes.Items.Count > 0)
            {
                postcodes.Items.Clear();
            }
        }


        // Closes the application
        private void CloseApplication (object sender, EventArgs e)
        {
            GC.Collect();
            Application.Exit();
        }


        private void ShowMileage (object sender, EventArgs e)
        {
            if(postcodes.Items.Count == 0)
            {
                MessageBox.Show("There was nothing to check the milage of.\nPlease enter your trip and try again.");
                return;
            }

            double mileage = GetTotalMileage(postcodes.Items);
            MessageBox.Show("Total mileage for this trip was: " + mileage.ToString());
        }



        
        private double UpdateTotalMileageFromSpreadsheet()
        {
            var worksheet = _workBook.Worksheets[0];
            double total = 0;

            for (int i = 1; i < worksheet.Cells.LastRowIndex+1; i++)
            {
                if (worksheet.Cells[i, 3].Value != null)
                    total += (double) worksheet.Cells[i, 3].Value;
            }

            return total;
        }


        private void LoadConfig()
        {
            try
            {
                _config.Load(Path.Combine(_appPath, _configPath));
                _spreadsheetPath = _config.SelectSingleNode("settings/spreadsheet").InnerText;
                _homePostcode = _config.SelectSingleNode("settings/home").InnerText;

                _workBook = new Workbook();

                if (!string.IsNullOrEmpty(_spreadsheetPath))
                    _workBook = Workbook.Load(_spreadsheetPath);
            }
            catch (IOException e) {
                MessageBox.Show("There was an error loading saved settings:\n\n" + e.ToString());
                return; }
        }


        private void SaveConfig()
        {
            // save xml config
            try
            {
                _config.SelectSingleNode("settings/spreadsheet").InnerText = _spreadsheetPath;
                _config.SelectSingleNode("settings/home").InnerText = _homePostcode;
                _config.Save(Path.Combine(_appPath, _configPath));
            }
            catch (IOException) { }
        }


        private void AddHomePostcode (object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_homePostcode))
            {
                SetHome(this, new EventArgs());
            }
            else
            {
                postcodes.Items.Add(_homePostcode);
            }
        }


        private void OnFormClosed (object sender, FormClosedEventArgs e)
        {
            SaveConfig();
        }

        private void SetHome (object sender, EventArgs e)
        {
            string value = "";
            if (InputBox("Enter your home postcode", "Enter your home postcode:", ref value) == DialogResult.OK)
            {
                if (ValidatePostcode(value))
                    _homePostcode = value;
                else
                    return;
            }
        }


        private double GetTotalMileage(ListBox.ObjectCollection postcodes)
        {
            double mileage = 0.0;

            for (int i = 0; i < postcodes.Count - 1; i++)
            {
                mileage += GetDrivingDistanceInMiles((string)postcodes[i], (string)postcodes[i + 1]);
            }

            return mileage;
        }


        private double GetDrivingDistanceInMiles (string origin, string destination)
        {
            string url = @"http://maps.googleapis.com/maps/api/distancematrix/xml?origins=" +
              origin + "&destinations=" + destination +
              "&mode=driving&sensor=false&language=en-EN&units=imperial&";

            WebResponse response;
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
            try
            {
                response = request.GetResponse();
            }
            catch(WebException)
            {
                MessageBox.Show("Could not connect to google maps");
                return 0;
            }
            Stream dataStream = response.GetResponseStream();
            StreamReader sreader = new StreamReader(dataStream);
            string responsereader = sreader.ReadToEnd();
            response.Close();

            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(responsereader);

            if (xmldoc.GetElementsByTagName("status")[0].ChildNodes[0].InnerText == "OK")
            {
                XmlNodeList distance = xmldoc.GetElementsByTagName("distance");
                return Convert.ToDouble(distance[0].ChildNodes[1].InnerText.Replace(" mi", ""));
            }
            return 0;
        }


        public static DialogResult InputBox (string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
    }
}
