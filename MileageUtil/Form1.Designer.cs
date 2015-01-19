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
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnOpenSpreadsheet = new System.Windows.Forms.Button();
            this.btnInsertMileage = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreateSpreadsheet = new System.Windows.Forms.Button();
            this.openSpreadsheetDialogue = new System.Windows.Forms.OpenFileDialog();
            this.createSpreadsheetDialogue = new System.Windows.Forms.SaveFileDialog();
            this.btnRemoveLastPostcode = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowMileage = new System.Windows.Forms.Button();
            this.currentPath = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSetHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // postcodes
            // 
            this.postcodes.FormattingEnabled = true;
            this.postcodes.Location = new System.Drawing.Point(254, 33);
            this.postcodes.Name = "postcodes";
            this.postcodes.Size = new System.Drawing.Size(113, 134);
            this.postcodes.TabIndex = 0;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(376, 33);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(68, 20);
            this.txtInput.TabIndex = 1;
            // 
            // btnAddPostcode
            // 
            this.btnAddPostcode.Location = new System.Drawing.Point(376, 59);
            this.btnAddPostcode.Name = "btnAddPostcode";
            this.btnAddPostcode.Size = new System.Drawing.Size(123, 23);
            this.btnAddPostcode.TabIndex = 2;
            this.btnAddPostcode.Text = "Add Postcode";
            this.btnAddPostcode.UseVisualStyleBackColor = true;
            this.btnAddPostcode.Click += new System.EventHandler(this.AddPostCode);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(15, 6);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 3;
            // 
            // btnOpenSpreadsheet
            // 
            this.btnOpenSpreadsheet.Location = new System.Drawing.Point(134, 173);
            this.btnOpenSpreadsheet.Name = "btnOpenSpreadsheet";
            this.btnOpenSpreadsheet.Size = new System.Drawing.Size(108, 33);
            this.btnOpenSpreadsheet.TabIndex = 4;
            this.btnOpenSpreadsheet.Text = "Open Spreadshet";
            this.btnOpenSpreadsheet.UseVisualStyleBackColor = true;
            this.btnOpenSpreadsheet.Click += new System.EventHandler(this.OpenSpreadsheetDialogue);
            // 
            // btnInsertMileage
            // 
            this.btnInsertMileage.Location = new System.Drawing.Point(254, 209);
            this.btnInsertMileage.Name = "btnInsertMileage";
            this.btnInsertMileage.Size = new System.Drawing.Size(245, 56);
            this.btnInsertMileage.TabIndex = 6;
            this.btnInsertMileage.Text = "Insert Mileage To Spreadsheet";
            this.btnInsertMileage.UseVisualStyleBackColor = true;
            this.btnInsertMileage.Click += new System.EventHandler(this.InsetMileageToSpreadsheet);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(254, 271);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(245, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.CloseApplication);
            // 
            // btnCreateSpreadsheet
            // 
            this.btnCreateSpreadsheet.Location = new System.Drawing.Point(15, 173);
            this.btnCreateSpreadsheet.Name = "btnCreateSpreadsheet";
            this.btnCreateSpreadsheet.Size = new System.Drawing.Size(113, 33);
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
            this.btnRemoveLastPostcode.Location = new System.Drawing.Point(376, 88);
            this.btnRemoveLastPostcode.Name = "btnRemoveLastPostcode";
            this.btnRemoveLastPostcode.Size = new System.Drawing.Size(123, 23);
            this.btnRemoveLastPostcode.TabIndex = 9;
            this.btnRemoveLastPostcode.Text = "Remove Last";
            this.btnRemoveLastPostcode.UseVisualStyleBackColor = true;
            this.btnRemoveLastPostcode.Click += new System.EventHandler(this.RemoveLastPostcode);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(376, 117);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(123, 23);
            this.btnClearAll.TabIndex = 10;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.ClearAllPostcodes);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter postcode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Waypoints";
            // 
            // btnShowMileage
            // 
            this.btnShowMileage.Location = new System.Drawing.Point(254, 173);
            this.btnShowMileage.Name = "btnShowMileage";
            this.btnShowMileage.Size = new System.Drawing.Size(245, 33);
            this.btnShowMileage.TabIndex = 14;
            this.btnShowMileage.Text = "Show Mileage";
            this.btnShowMileage.UseVisualStyleBackColor = true;
            this.btnShowMileage.Click += new System.EventHandler(this.ShowMileage);
            // 
            // currentPath
            // 
            this.currentPath.Location = new System.Drawing.Point(15, 220);
            this.currentPath.Name = "currentPath";
            this.currentPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.currentPath.Size = new System.Drawing.Size(227, 72);
            this.currentPath.TabIndex = 15;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(450, 31);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(49, 23);
            this.btnHome.TabIndex = 16;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.AddHomePostcode);
            // 
            // btnSetHome
            // 
            this.btnSetHome.Location = new System.Drawing.Point(376, 147);
            this.btnSetHome.Name = "btnSetHome";
            this.btnSetHome.Size = new System.Drawing.Size(123, 21);
            this.btnSetHome.TabIndex = 17;
            this.btnSetHome.Text = "Set Home";
            this.btnSetHome.UseVisualStyleBackColor = true;
            this.btnSetHome.Click += new System.EventHandler(this.SetHome);
            // 
            // EntryForm
            // 
            this.AcceptButton = this.btnAddPostcode;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(504, 301);
            this.Controls.Add(this.btnSetHome);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.currentPath);
            this.Controls.Add(this.btnShowMileage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnRemoveLastPostcode);
            this.Controls.Add(this.btnCreateSpreadsheet);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInsertMileage);
            this.Controls.Add(this.btnOpenSpreadsheet);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.btnAddPostcode);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.postcodes);
            this.DoubleBuffered = true;
            this.Name = "EntryForm";
            this.Text = "Mileage Calculation Tool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.Load += new System.EventHandler(this.OnFormLoaded);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox postcodes;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnAddPostcode;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button btnOpenSpreadsheet;
        private System.Windows.Forms.Button btnInsertMileage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCreateSpreadsheet;
        private System.Windows.Forms.OpenFileDialog openSpreadsheetDialogue;
        private System.Windows.Forms.SaveFileDialog createSpreadsheetDialogue;
        private System.Windows.Forms.Button btnRemoveLastPostcode;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowMileage;
        private System.Windows.Forms.Label currentPath;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSetHome;
    }
}

