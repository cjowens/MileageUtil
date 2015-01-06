using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilageExcelCounter
{
    public partial class EntryForm : Form
    {
        public EntryForm ()
        {
            InitializeComponent();
        }

        private void AddPostCode (object sender, EventArgs e)
        {
            // if the text box isn't empty
            if (!string.IsNullOrEmpty(txtInput.Text))
            {
                // add the entry to the listbox and clear the text field
                postcodes.Items.Add(txtInput.Text);
                txtInput.Text = "";
            }
        }

        private void CreateSpreadsheetDialogue (object sender, EventArgs e)
        {
            createSpreadsheetDialogue.ShowDialog();
        }

        private void OpenSpreadsheetDialogue (object sender, EventArgs e)
        {
            var result = openSpreadsheetDialogue.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openSpreadsheetDialogue.FileName;
                try
                {
                    FileLabel.Text = file;
                }
                catch(IOException)
                {
                }
            }
        }

        private void CreateSpreadsheet (object sender, CancelEventArgs e)
        {
            MessageBox.Show("Spreadsheet created.");
        }

        private void CloseApplication (object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RemoveLastPostcode (object sender, EventArgs e)
        {

        }

        private void ClearAllPostcodes (object sender, EventArgs e)
        {

        }
    }
}
