namespace Project_QLSV
{
    partial class ResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
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
        private void InitializeComponent()
        {
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.label_LastName = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.textBox_StudentID = new System.Windows.Forms.TextBox();
            this.label_StudentID = new System.Windows.Forms.Label();
            this.button_SEARCH = new System.Windows.Forms.Button();
            this.textBox_SEARCH = new System.Windows.Forms.TextBox();
            this.label_Search = new System.Windows.Forms.Label();
            this.dataGridView_Show = new System.Windows.Forms.DataGridView();
            this.label_StudentResult = new System.Windows.Forms.Label();
            this.button_ToPrinter = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.printDocument_Printer = new System.Drawing.Printing.PrintDocument();
            this.printDialog_Printer = new System.Windows.Forms.PrintDialog();
            this.button_SaveToTextFile = new System.Windows.Forms.Button();
            this.comboBox_Search = new System.Windows.Forms.ComboBox();
            this.button_Reload = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(100, 134);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.ReadOnly = true;
            this.textBox_LastName.Size = new System.Drawing.Size(178, 22);
            this.textBox_LastName.TabIndex = 11;
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(16, 139);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(80, 17);
            this.label_LastName.TabIndex = 10;
            this.label_LastName.Text = "Last Name:";
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(100, 103);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.ReadOnly = true;
            this.textBox_FirstName.Size = new System.Drawing.Size(178, 22);
            this.textBox_FirstName.TabIndex = 9;
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(16, 106);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(80, 17);
            this.label_FirstName.TabIndex = 8;
            this.label_FirstName.Text = "First Name:";
            // 
            // textBox_StudentID
            // 
            this.textBox_StudentID.Location = new System.Drawing.Point(100, 72);
            this.textBox_StudentID.Name = "textBox_StudentID";
            this.textBox_StudentID.ReadOnly = true;
            this.textBox_StudentID.Size = new System.Drawing.Size(178, 22);
            this.textBox_StudentID.TabIndex = 7;
            // 
            // label_StudentID
            // 
            this.label_StudentID.AutoSize = true;
            this.label_StudentID.Location = new System.Drawing.Point(16, 77);
            this.label_StudentID.Name = "label_StudentID";
            this.label_StudentID.Size = new System.Drawing.Size(78, 17);
            this.label_StudentID.TabIndex = 6;
            this.label_StudentID.Text = "Student ID:";
            // 
            // button_SEARCH
            // 
            this.button_SEARCH.Location = new System.Drawing.Point(21, 200);
            this.button_SEARCH.Name = "button_SEARCH";
            this.button_SEARCH.Size = new System.Drawing.Size(75, 23);
            this.button_SEARCH.TabIndex = 48;
            this.button_SEARCH.Text = "Search";
            this.button_SEARCH.UseVisualStyleBackColor = true;
            //this.button_SEARCH.Click += new System.EventHandler(this.button_SEARCH_Click);
            // 
            // textBox_SEARCH
            // 
            this.textBox_SEARCH.Location = new System.Drawing.Point(102, 201);
            this.textBox_SEARCH.Name = "textBox_SEARCH";
            this.textBox_SEARCH.Size = new System.Drawing.Size(104, 22);
            this.textBox_SEARCH.TabIndex = 47;
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Location = new System.Drawing.Point(16, 171);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(168, 17);
            this.label_Search.TabIndex = 46;
            this.label_Search.Text = "Search By Id, First Name:";
            // 
            // dataGridView_Show
            // 
            this.dataGridView_Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Show.Location = new System.Drawing.Point(295, 72);
            this.dataGridView_Show.Name = "dataGridView_Show";
            this.dataGridView_Show.RowTemplate.Height = 24;
            this.dataGridView_Show.Size = new System.Drawing.Size(933, 244);
            this.dataGridView_Show.TabIndex = 54;
            //this.dataGridView_Show.DoubleClick += new System.EventHandler(this.dataGridView_Show_DoubleClick);
            // 
            // label_StudentResult
            // 
            this.label_StudentResult.AutoSize = true;
            this.label_StudentResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StudentResult.Location = new System.Drawing.Point(290, 24);
            this.label_StudentResult.Name = "label_StudentResult";
            this.label_StudentResult.Size = new System.Drawing.Size(169, 29);
            this.label_StudentResult.TabIndex = 55;
            this.label_StudentResult.Text = "Student Result";
            // 
            // button_ToPrinter
            // 
            this.button_ToPrinter.Location = new System.Drawing.Point(1053, 327);
            this.button_ToPrinter.Name = "button_ToPrinter";
            this.button_ToPrinter.Size = new System.Drawing.Size(177, 51);
            this.button_ToPrinter.TabIndex = 56;
            this.button_ToPrinter.Text = "To Printer";
            this.button_ToPrinter.UseVisualStyleBackColor = true;
            //this.button_ToPrinter.Click += new System.EventHandler(this.button_ToPrinter_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(321, 327);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(177, 51);
            this.button_Cancel.TabIndex = 57;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            //this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // printDocument_Printer
            // 
            //this.printDocument_Printer.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_Printer_PrintPage);
            // 
            // printDialog_Printer
            // 
            this.printDialog_Printer.UseEXDialog = true;
            // 
            // button_SaveToTextFile
            // 
            this.button_SaveToTextFile.Location = new System.Drawing.Point(870, 327);
            this.button_SaveToTextFile.Name = "button_SaveToTextFile";
            this.button_SaveToTextFile.Size = new System.Drawing.Size(177, 51);
            this.button_SaveToTextFile.TabIndex = 58;
            this.button_SaveToTextFile.Text = "Save To Text File";
            this.button_SaveToTextFile.UseVisualStyleBackColor = true;
            //this.button_SaveToTextFile.Click += new System.EventHandler(this.button_SaveToTextFile_Click);
            // 
            // comboBox_Search
            // 
            this.comboBox_Search.FormattingEnabled = true;
            this.comboBox_Search.Location = new System.Drawing.Point(212, 199);
            this.comboBox_Search.Name = "comboBox_Search";
            this.comboBox_Search.Size = new System.Drawing.Size(66, 24);
            this.comboBox_Search.TabIndex = 59;
            // 
            // button_Reload
            // 
            this.button_Reload.Location = new System.Drawing.Point(687, 327);
            this.button_Reload.Name = "button_Reload";
            this.button_Reload.Size = new System.Drawing.Size(177, 51);
            this.button_Reload.TabIndex = 60;
            this.button_Reload.Text = "Reload";
            this.button_Reload.UseVisualStyleBackColor = true;
            //this.button_Reload.Click += new System.EventHandler(this.button_Reload_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(504, 327);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(177, 51);
            this.button_Reset.TabIndex = 61;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            //this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 390);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Reload);
            this.Controls.Add(this.comboBox_Search);
            this.Controls.Add(this.button_SaveToTextFile);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_ToPrinter);
            this.Controls.Add(this.label_StudentResult);
            this.Controls.Add(this.dataGridView_Show);
            this.Controls.Add(this.button_SEARCH);
            this.Controls.Add(this.textBox_SEARCH);
            this.Controls.Add(this.label_Search);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.textBox_StudentID);
            this.Controls.Add(this.label_StudentID);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            //this.Load += new System.EventHandler(this.ResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.TextBox textBox_StudentID;
        private System.Windows.Forms.Label label_StudentID;
        private System.Windows.Forms.Button button_SEARCH;
        private System.Windows.Forms.TextBox textBox_SEARCH;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.DataGridView dataGridView_Show;
        private System.Windows.Forms.Label label_StudentResult;
        private System.Windows.Forms.Button button_ToPrinter;
        private System.Windows.Forms.Button button_Cancel;
        private System.Drawing.Printing.PrintDocument printDocument_Printer;
        private System.Windows.Forms.PrintDialog printDialog_Printer;
        private System.Windows.Forms.Button button_SaveToTextFile;
        private System.Windows.Forms.ComboBox comboBox_Search;
        private System.Windows.Forms.Button button_Reload;
        private System.Windows.Forms.Button button_Reset;
    }
}