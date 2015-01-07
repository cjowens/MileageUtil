namespace MileageUtil
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
            this.fileLabel = new System.Windows.Forms.Label();
            this.btnInsertData = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreateSpreadsheet = new System.Windows.Forms.Button();
            this.openSpreadsheetDialogue = new System.Windows.Forms.OpenFileDialog();
            this.createSpreadsheetDialogue = new System.Windows.Forms.SaveFileDialog();
            this.btnRemoveLastPostcode = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowMileage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // postcodes
            // 
            this.postcodes.FormattingEnabled = true;
            this.postcodes.Location = new System.Drawing.Point(254, 87);
            this.postcodes.Name = "postcodes";
            this.postcodes.Size = new System.Drawing.Size(113, 134);
            this.postcodes.TabIndex = 0;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(376, 75);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(108, 20);
            this.txtInput.TabIndex = 1;
            // 
            // btnAddPostcode
            // 
            this.btnAddPostcode.Location = new System.Drawing.Point(376, 101);
            this.btnAddPostcode.Name = "btnAddPostcode";
            this.btnAddPostcode.Size = new System.Drawing.Size(108, 23);
            this.btnAddPostcode.TabIndex = 2;
            this.btnAddPostcode.Text = "Add Postcode";
            this.btnAddPostcode.UseVisualStyleBackColor = true;
            this.btnAddPostcode.Click += new System.EventHandler(this.AddPostCode);
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(15, 59);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 3;
            // 
            // btnOpenSpreadsheet
            // 
            this.btnOpenSpreadsheet.Location = new System.Drawing.Point(144, 293);
            this.btnOpenSpreadsheet.Name = "btnOpenSpreadsheet";
            this.btnOpenSpreadsheet.Size = new System.Drawing.Size(108, 23);
            this.btnOpenSpreadsheet.TabIndex = 4;
            this.btnOpenSpreadsheet.Text = "Open Spreadshet";
            this.btnOpenSpreadsheet.UseVisualStyleBackColor = true;
            this.btnOpenSpreadsheet.Click += new System.EventHandler(this.OpenSpreadsheetDialogue);
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(12, 325);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(29, 13);
            this.fileLabel.TabIndex = 5;
            this.fileLabel.Text = "label";
            this.fileLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnInsertData
            // 
            this.btnInsertData.Location = new System.Drawing.Point(13, 341);
            this.btnInsertData.Name = "btnInsertData";
            this.btnInsertData.Size = new System.Drawing.Size(227, 56);
            this.btnInsertData.TabIndex = 6;
            this.btnInsertData.Text = "Insert Data To Spreadsheet";
            this.btnInsertData.UseVisualStyleBackColor = true;
            this.btnInsertData.Click += new System.EventHandler(this.InsetDataToSpreadsheet);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 432);
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
            this.openSpreadsheetDialogue.Filter = "Excel Files (*xls)|*.xls;";
            // 
            // createSpreadsheetDialogue
            // 
            this.createSpreadsheetDialogue.Filter = "Excel File (*.xls)|*.xls";
            this.createSpreadsheetDialogue.FileOk += new System.ComponentModel.CancelEventHandler(this.CreateSpreadsheet);
            // 
            // btnRemoveLastPostcode
            // 
            this.btnRemoveLastPostcode.Location = new System.Drawing.Point(376, 130);
            this.btnRemoveLastPostcode.Name = "btnRemoveLastPostcode";
            this.btnRemoveLastPostcode.Size = new System.Drawing.Size(108, 23);
            this.btnRemoveLastPostcode.TabIndex = 9;
            this.btnRemoveLastPostcode.Text = "Remove Last";
            this.btnRemoveLastPostcode.UseVisualStyleBackColor = true;
            this.btnRemoveLastPostcode.Click += new System.EventHandler(this.RemoveLastPostcode);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(376, 159);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(108, 23);
            this.btnClearAll.TabIndex = 10;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.ClearAllPostcodes);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 403);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(226, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter postcode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Waypoints";
            // 
            // btnShowMileage
            // 
            this.btnShowMileage.Location = new System.Drawing.Point(376, 188);
            this.btnShowMileage.Name = "btnShowMileage";
            this.btnShowMileage.Size = new System.Drawing.Size(108, 33);
            this.btnShowMileage.TabIndex = 14;
            this.btnShowMileage.Text = "Show Mileage";
            this.btnShowMileage.UseVisualStyleBackColor = true;
            this.btnShowMileage.Click += new System.EventHandler(this.ShowMileage);
            // 
            // EntryForm
            // 
            this.AcceptButton = this.btnAddPostcode;
            this.ClientSize = new System.Drawing.Size(514, 491);
            this.Controls.Add(this.btnShowMileage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnRemoveLastPostcode);
            this.Controls.Add(this.btnCreateSpreadsheet);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInsertData);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.btnOpenSpreadsheet);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.btnAddPostcode);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.postcodes);
            this.DoubleBuffered = true;
            this.Name = "EntryForm";
            this.Text = "Mileage Calculation Tool";
            this.Load += new System.EventHandler(this.OnFormLoaded);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox postcodes;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnAddPostcode;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Button btnOpenSpreadsheet;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Button btnInsertData;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCreateSpreadsheet;
        private System.Windows.Forms.OpenFileDialog openSpreadsheetDialogue;
        private System.Windows.Forms.SaveFileDialog createSpreadsheetDialogue;
        private System.Windows.Forms.Button btnRemoveLastPostcode;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowMileage;
    }
}

