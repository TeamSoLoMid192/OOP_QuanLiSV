namespace Project_QLSV
{
    partial class Print
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print));
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.dATA_LOGINDataSet = new WindowsFormsApp2.DATA_LOGINDataSet();
            //this.studentTableAdapter = new WindowsFormsApp2.DATA_LOGINDataSetTableAdapters.StudentTableAdapter();
            this.dataGridView_StudentListForm = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_CHECK = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton_NO = new System.Windows.Forms.RadioButton();
            this.radioButton_YES = new System.Windows.Forms.RadioButton();
            this.label_BirthDateRange = new System.Windows.Forms.Label();
            this.label_UseDateRange = new System.Windows.Forms.Label();
            this.radioButton_All = new System.Windows.Forms.RadioButton();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.button_SaveToTextFile = new System.Windows.Forms.Button();
            this.button_ToPrinter = new System.Windows.Forms.Button();
            this.printDialog_Printer = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog_Printer = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument_Printer = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.dATA_LOGINDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StudentListForm)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
           // this.studentBindingSource.DataSource = this.dATA_LOGINDataSet;
            // 
            // dATA_LOGINDataSet
            // 
            //this.dATA_LOGINDataSet.DataSetName = "DATA_LOGINDataSet";
            //this.dATA_LOGINDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            //this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView_StudentListForm
            // 
            this.dataGridView_StudentListForm.AutoGenerateColumns = false;
            this.dataGridView_StudentListForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_StudentListForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_StudentListForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.bdateDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.dataGridView_StudentListForm.DataSource = this.studentBindingSource;
            this.dataGridView_StudentListForm.Location = new System.Drawing.Point(12, 148);
            this.dataGridView_StudentListForm.Name = "dataGridView_StudentListForm";
            this.dataGridView_StudentListForm.RowTemplate.Height = 24;
            this.dataGridView_StudentListForm.Size = new System.Drawing.Size(1103, 437);
            this.dataGridView_StudentListForm.TabIndex = 47;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "fname";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "lname";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // bdateDataGridViewTextBoxColumn
            // 
            this.bdateDataGridViewTextBoxColumn.DataPropertyName = "bdate";
            this.bdateDataGridViewTextBoxColumn.HeaderText = "bdate";
            this.bdateDataGridViewTextBoxColumn.Name = "bdateDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "picture";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_CHECK);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.radioButton_All);
            this.panel1.Controls.Add(this.radioButton_Female);
            this.panel1.Controls.Add(this.radioButton_Male);
            this.panel1.Location = new System.Drawing.Point(12, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 110);
            this.panel1.TabIndex = 48;
            // 
            // button_CHECK
            // 
            this.button_CHECK.Location = new System.Drawing.Point(904, 40);
            this.button_CHECK.Name = "button_CHECK";
            this.button_CHECK.Size = new System.Drawing.Size(189, 51);
            this.button_CHECK.TabIndex = 35;
            this.button_CHECK.Text = "CHECK";
            this.button_CHECK.UseVisualStyleBackColor = true;
            //this.button_CHECK.Click += new System.EventHandler(this.button_CHECK_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.radioButton_NO);
            this.panel2.Controls.Add(this.radioButton_YES);
            this.panel2.Controls.Add(this.label_BirthDateRange);
            this.panel2.Controls.Add(this.label_UseDateRange);
            this.panel2.Location = new System.Drawing.Point(240, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 85);
            this.panel2.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "and";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(414, 40);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(233, 22);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(235, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // radioButton_NO
            // 
            this.radioButton_NO.AutoSize = true;
            this.radioButton_NO.Location = new System.Drawing.Point(206, 9);
            this.radioButton_NO.Name = "radioButton_NO";
            this.radioButton_NO.Size = new System.Drawing.Size(50, 21);
            this.radioButton_NO.TabIndex = 3;
            this.radioButton_NO.TabStop = true;
            this.radioButton_NO.Text = "NO";
            this.radioButton_NO.UseVisualStyleBackColor = true;
            //this.radioButton_NO.CheckedChanged += new System.EventHandler(this.radioButton_NO_CheckedChanged);
            // 
            // radioButton_YES
            // 
            this.radioButton_YES.AutoSize = true;
            this.radioButton_YES.Location = new System.Drawing.Point(133, 9);
            this.radioButton_YES.Name = "radioButton_YES";
            this.radioButton_YES.Size = new System.Drawing.Size(56, 21);
            this.radioButton_YES.TabIndex = 2;
            this.radioButton_YES.TabStop = true;
            this.radioButton_YES.Text = "YES";
            this.radioButton_YES.UseVisualStyleBackColor = true;
            //this.radioButton_YES.CheckedChanged += new System.EventHandler(this.radioButton_YES_CheckedChanged);
            // 
            // label_BirthDateRange
            // 
            this.label_BirthDateRange.AutoSize = true;
            this.label_BirthDateRange.Location = new System.Drawing.Point(3, 45);
            this.label_BirthDateRange.Name = "label_BirthDateRange";
            this.label_BirthDateRange.Size = new System.Drawing.Size(126, 17);
            this.label_BirthDateRange.TabIndex = 1;
            this.label_BirthDateRange.Text = "Birthdate between:";
            // 
            // label_UseDateRange
            // 
            this.label_UseDateRange.AutoSize = true;
            this.label_UseDateRange.Location = new System.Drawing.Point(3, 11);
            this.label_UseDateRange.Name = "label_UseDateRange";
            this.label_UseDateRange.Size = new System.Drawing.Size(110, 17);
            this.label_UseDateRange.TabIndex = 0;
            this.label_UseDateRange.Text = "Use date range:";
            // 
            // radioButton_All
            // 
            this.radioButton_All.AutoSize = true;
            this.radioButton_All.Location = new System.Drawing.Point(23, 40);
            this.radioButton_All.Name = "radioButton_All";
            this.radioButton_All.Size = new System.Drawing.Size(44, 21);
            this.radioButton_All.TabIndex = 33;
            this.radioButton_All.TabStop = true;
            this.radioButton_All.Text = "All";
            this.radioButton_All.UseVisualStyleBackColor = true;
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.Location = new System.Drawing.Point(159, 40);
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.Size = new System.Drawing.Size(75, 21);
            this.radioButton_Female.TabIndex = 32;
            this.radioButton_Female.TabStop = true;
            this.radioButton_Female.Text = "Female";
            this.radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Location = new System.Drawing.Point(84, 40);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(59, 21);
            this.radioButton_Male.TabIndex = 31;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "Male";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // button_SaveToTextFile
            // 
            this.button_SaveToTextFile.Location = new System.Drawing.Point(304, 606);
            this.button_SaveToTextFile.Name = "button_SaveToTextFile";
            this.button_SaveToTextFile.Size = new System.Drawing.Size(189, 51);
            this.button_SaveToTextFile.TabIndex = 49;
            this.button_SaveToTextFile.Text = "Save To Text File";
            this.button_SaveToTextFile.UseVisualStyleBackColor = true;
            //this.button_SaveToTextFile.Click += new System.EventHandler(this.button_SaveToTextFile_Click);
            // 
            // button_ToPrinter
            // 
            this.button_ToPrinter.Location = new System.Drawing.Point(688, 606);
            this.button_ToPrinter.Name = "button_ToPrinter";
            this.button_ToPrinter.Size = new System.Drawing.Size(189, 51);
            this.button_ToPrinter.TabIndex = 50;
            this.button_ToPrinter.Text = "To Printer";
            this.button_ToPrinter.UseVisualStyleBackColor = true;
            //this.button_ToPrinter.Click += new System.EventHandler(this.button_ToPrinter_Click);
            // 
            // printDialog_Printer
            // 
            this.printDialog_Printer.UseEXDialog = true;
            // 
            // printPreviewDialog_Printer
            // 
            this.printPreviewDialog_Printer.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog_Printer.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog_Printer.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog_Printer.Enabled = true;
            this.printPreviewDialog_Printer.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog_Printer.Icon")));
            this.printPreviewDialog_Printer.Name = "printPreviewDialog_Printer";
            this.printPreviewDialog_Printer.Visible = false;
            // 
            // printDocument_Printer
            // 
            //this.printDocument_Printer.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_Printer_PrintPage);
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 670);
            this.Controls.Add(this.button_ToPrinter);
            this.Controls.Add(this.button_SaveToTextFile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_StudentListForm);
            this.Name = "Print";
            this.Text = "Print";
            //this.Load += new System.EventHandler(this.Print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.dATA_LOGINDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StudentListForm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource studentBindingSource;
        //private DATA_LOGINDataSet dATA_LOGINDataSet;
        //private DATA_LOGINDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView_StudentListForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_CHECK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton_NO;
        private System.Windows.Forms.RadioButton radioButton_YES;
        private System.Windows.Forms.Label label_BirthDateRange;
        private System.Windows.Forms.Label label_UseDateRange;
        public System.Windows.Forms.RadioButton radioButton_All;
        public System.Windows.Forms.RadioButton radioButton_Female;
        public System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.Button button_SaveToTextFile;
        private System.Windows.Forms.Button button_ToPrinter;
        private System.Windows.Forms.PrintDialog printDialog_Printer;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog_Printer;
        private System.Drawing.Printing.PrintDocument printDocument_Printer;
    }
}