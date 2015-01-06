namespace MilageExcelCounter
{
    partial class EntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.postcodes = new System.Windows.Forms.ListBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAddPostcode = new System.Windows.Forms.Button();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.btnOpenSpreadsheet = new System.Windows.Forms.Button();
            this.FileLabel = new System.Windows.Forms.Label();
            this.btnInsertPostcodes = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreateSpreadsheet = new System.Windows.Forms.Button();
            this.openSpreadsheetDialogue = new System.Windows.Forms.OpenFileDialog();
            this.createSpreadsheetDialogue = new System.Windows.Forms.SaveFileDialog();
            this.btnRemoveLastPostcode = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // postcodes
            // 
            this.postcodes.FormattingEnabled = true;
            this.postcodes.Location = new System.Drawing.Point(13, 180);
            this.postcodes.Name = "postcodes";
            this.postcodes.Size = new System.Drawing.Size(113, 108);
            this.postcodes.TabIndex = 0;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(132, 180);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(108, 20);
            this.txtInput.TabIndex = 1;
            // 
            // btnAddPostcode
            // 
            this.btnAddPostcode.Location = new System.Drawing.Point(132, 206);
            this.btnAddPostcode.Name = "btnAddPostcode";
            this.btnAddPostcode.Size = new System.Drawing.Size(108, 23);
            this.btnAddPostcode.TabIndex = 2;
            this.btnAddPostcode.Text = "Add Postcode";
            this.btnAddPostcode.UseVisualStyleBackColor = true;
            this.btnAddPostcode.Click += new System.EventHandler(this.AddPostCode);
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(13, 6);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 3;
            // 
            // btnOpenSpreadsheet
            // 
            this.btnOpenSpreadsheet.Location = new System.Drawing.Point(132, 294);
            this.btnOpenSpreadsheet.Name = "btnOpenSpreadsheet";
            this.btnOpenSpreadsheet.Size = new System.Drawing.Size(108, 23);
            this.btnOpenSpreadsheet.TabIndex = 4;
            this.btnOpenSpreadsheet.Text = "Open Spreadshet";
            this.btnOpenSpreadsheet.UseVisualStyleBackColor = true;
            this.btnOpenSpreadsheet.Click += new System.EventHandler(this.OpenSpreadsheetDialogue);
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Location = new System.Drawing.Point(357, 22);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(0, 13);
            this.FileLabel.TabIndex = 5;
            // 
            // btnInsertPostcodes
            // 
            this.btnInsertPostcodes.Location = new System.Drawing.Point(13, 323);
            this.btnInsertPostcodes.Name = "btnInsertPostcodes";
            this.btnInsertPostcodes.Size = new System.Drawing.Size(227, 56);
            this.btnInsertPostcodes.TabIndex = 6;
            this.btnInsertPostcodes.Text = "Insert Postcodes To Spreadsheet";
            this.btnInsertPostcodes.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(13, 385);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(227, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.CloseApplication);
            // 
            // btnCreateSpreadsheet
            // 
            this.btnCreateSpreadsheet.Location = new System.Drawing.Point(13, 294);
            this.btnCreateSpreadsheet.Name = "btnCreateSpreadsheet";
            this.btnCreateSpreadsheet.Size = new System.Drawing.Size(113, 23);
            this.btnCreateSpreadsheet.TabIndex = 8;
            this.btnCreateSpreadsheet.Text = "Create Spreadsheet";
            this.btnCreateSpreadsheet.UseVisualStyleBackColor = true;
            this.btnCreateSpreadsheet.Click += new System.EventHandler(this.CreateSpreadsheetDialogue);
            // 
            // openSpreadsheetDialogue
            // 
            this.openSpreadsheetDialogue.FileName = "spreadsheet";
            this.openSpreadsheetDialogue.Filter = "Excel Files (*xls, *.xlsx)|*.xls;*.xlsx";
            // 
            // createSpreadsheetDialogue
            // 
            this.createSpreadsheetDialogue.Filter = "Excel File (*.xls)|*.xls";
            this.createSpreadsheetDialogue.FileOk += new System.ComponentModel.CancelEventHandler(this.CreateSpreadsheet);
            // 
            // btnRemoveLastPostcode
            // 
            this.btnRemoveLastPostcode.Location = new System.Drawing.Point(132, 235);
            this.btnRemoveLastPostcode.Name = "btnRemoveLastPostcode";
            this.btnRemoveLastPostcode.Size = new System.Drawing.Size(108, 23);
            this.btnRemoveLastPostcode.TabIndex = 9;
            this.btnRemoveLastPostcode.Text = "Remove Last";
            this.btnRemoveLastPostcode.UseVisualStyleBackColor = true;
            this.btnRemoveLastPostcode.Click += new System.EventHandler(this.RemoveLastPostcode);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(132, 264);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(108, 23);
            this.btnClearAll.TabIndex = 10;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.ClearAllPostcodes);
            // 
            // EntryForm
            // 
            this.AcceptButton = this.btnAddPostcode;
            this.ClientSize = new System.Drawing.Size(253, 416);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnRemoveLastPostcode);
            this.Controls.Add(this.btnCreateSpreadsheet);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInsertPostcodes);
            this.Controls.Add(this.FileLabel);
            this.Controls.Add(this.btnOpenSpreadsheet);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.btnAddPostcode);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.postcodes);
            this.Name = "EntryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox postcodes;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnAddPostcode;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Button btnOpenSpreadsheet;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.Button btnInsertPostcodes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCreateSpreadsheet;
        private System.Windows.Forms.OpenFileDialog openSpreadsheetDialogue;
        private System.Windows.Forms.SaveFileDialog createSpreadsheetDialogue;
        private System.Windows.Forms.Button btnRemoveLastPostcode;
        private System.Windows.Forms.Button btnClearAll;
    }
}

