using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Xml;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using ExcelLibrary.SpreadSheet;


namespace MileageUtil
{
    public partial class EntryForm : Form
    {
        private Workbook _workBook = null;                                  // current spreadsheet
        private string _currentFilePath = "";                               // file path of the currently loaded spreadsheed
        private List<string> _postcodeWaypoints = new List<string>();       // seperate postcode list for manipulation
        private const string _pathLabel = "Current Spreadsheet:\n";         // currently loaded spreadsheet label message

        // comprehensive UK postcode regex supplied by UK Gov.
        private const string _postcodeRegex = "(GIR 0AA)|((([A-Z-[QVX]][0-9][0-9]?)|(([A-Z-[QVX]][A-Z-[IJZ]][0-9][0-9]?)|(([A-Z-[QVX]][0-9][A-HJKSTUW])|([A-Z-[QVX]][A-Z-[IJZ]][0-9][ABEHMNPRVWXY])))) ?[0-9][A-Z-[CIKMOV]]{2})";


        public EntryForm ()
        {
            InitializeComponent();
        }

        // Initialization. Called before application is rendered for 1st time.
        private void OnFormLoaded (object sender, EventArgs e)
        {
            _workBook = new Workbook();
            fileLabel.Text = _pathLabel;
        }

        private void AddPostCode (object sender, EventArgs e)
        {
            // if the text box isn't empty
            if (!string.IsNullOrEmpty(txtInput.Text))
            {
                var match = Regex.Match(txtInput.Text, _postcodeRegex);

                if (match.Success)
                {
                    // add the entry to the listbox
                    postcodes.Items.Add(txtInput.Text);
                    // reset the text field
                    txtInput.Text = "";
                }
                else
                {
                    MessageBox.Show("Please use a valid postcode.\nUppercase required.");
                }
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
                    _currentFilePath = openSpreadsheetDialogue.FileName;
                }
                catch(IOException ioExcep)
                {
                    MessageBox.Show("ERROR: " + ioExcep.ToString());
                    return;
                }

                fileLabel.Text = _pathLabel + _currentFilePath;
            }
        }

        private void InsetDataToSpreadsheet (object sender, EventArgs e)
        {
            if (postcodes.Items.Count == 0)
            {
                MessageBox.Show("There nothing to enter in to spreadsheet.\nPlease enter your trip and try again.");
                return;
            }
        }

        private void CreateSpreadsheet (object sender, CancelEventArgs e)
        {
            _currentFilePath = createSpreadsheetDialogue.FileName;
            fileLabel.Text = _pathLabel + _currentFilePath;
            _workBook.Save(_currentFilePath);
        }

        // Removes the last postcode from the list
        private void RemoveLastPostcode (object sender, EventArgs e)
        {
            if (postcodes.Items.Count > 0)
                postcodes.Items.RemoveAt(postcodes.Items.Count - 1);
        }

        // Removes all postcodes from the list
        private void ClearAllPostcodes (object sender, EventArgs e)
        {
            if (postcodes.Items.Count > 0)
                postcodes.Items.Clear();
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


        }

        public static double GetTotalMileage()
        {
            return 0;
        }

        public static double GetDrivingDistanceInMiles (string origin, string destination)
        {
            string url = @"http://maps.googleapis.com/maps/api/distancematrix/xml?origins=" +
              origin + "&destinations=" + destination +
              "&mode=driving&sensor=false&language=en-EN&units=imperial&alternatives=true";

            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
            WebResponse response = request.GetResponse();
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
    }
}
