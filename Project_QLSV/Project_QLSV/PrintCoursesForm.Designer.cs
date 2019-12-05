namespace Project_QLSV
{
    partial class PrintCoursesForm
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
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.dATA_LOGINDataSet_Course = new WindowsFormsApp2.DATA_LOGINDataSet_Course();
            //this.courseTableAdapter = new WindowsFormsApp2.DATA_LOGINDataSet_CourseTableAdapters.CourseTableAdapter();
            this.button_ToPrinter = new System.Windows.Forms.Button();
            this.button_SaveToTextFile = new System.Windows.Forms.Button();
            this.dataGridView_Courses = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDialog_Printer = new System.Windows.Forms.PrintDialog();
            this.printDocument_Printer = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.dATA_LOGINDataSet_Course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Courses)).BeginInit();
            this.SuspendLayout();
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            //this.courseBindingSource.DataSource = this.dATA_LOGINDataSet_Course;
            // 
            // dATA_LOGINDataSet_Course
            // 
            //this.dATA_LOGINDataSet_Course.DataSetName = "DATA_LOGINDataSet_Course";
            //this.dATA_LOGINDataSet_Course.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTableAdapter
            // 
            //this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // button_ToPrinter
            // 
            this.button_ToPrinter.Location = new System.Drawing.Point(372, 348);
            this.button_ToPrinter.Name = "button_ToPrinter";
            this.button_ToPrinter.Size = new System.Drawing.Size(189, 51);
            this.button_ToPrinter.TabIndex = 52;
            this.button_ToPrinter.Text = "To Printer";
            this.button_ToPrinter.UseVisualStyleBackColor = true;
            //this.button_ToPrinter.Click += new System.EventHandler(this.button_ToPrinter_Click);
            // 
            // button_SaveToTextFile
            // 
            this.button_SaveToTextFile.Location = new System.Drawing.Point(36, 348);
            this.button_SaveToTextFile.Name = "button_SaveToTextFile";
            this.button_SaveToTextFile.Size = new System.Drawing.Size(189, 51);
            this.button_SaveToTextFile.TabIndex = 51;
            this.button_SaveToTextFile.Text = "Save To Text File";
            this.button_SaveToTextFile.UseVisualStyleBackColor = true;
            //this.button_SaveToTextFile.Click += new System.EventHandler(this.button_SaveToTextFile_Click);
            // 
            // dataGridView_Courses
            // 
            this.dataGridView_Courses.AutoGenerateColumns = false;
            this.dataGridView_Courses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Courses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.labelDataGridViewTextBoxColumn,
            this.periodDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView_Courses.DataSource = this.courseBindingSource;
            this.dataGridView_Courses.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Courses.Name = "dataGridView_Courses";
            this.dataGridView_Courses.RowTemplate.Height = 24;
            this.dataGridView_Courses.Size = new System.Drawing.Size(587, 319);
            this.dataGridView_Courses.TabIndex = 53;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // labelDataGridViewTextBoxColumn
            // 
            this.labelDataGridViewTextBoxColumn.DataPropertyName = "label";
            this.labelDataGridViewTextBoxColumn.HeaderText = "label";
            this.labelDataGridViewTextBoxColumn.Name = "labelDataGridViewTextBoxColumn";
            // 
            // periodDataGridViewTextBoxColumn
            // 
            this.periodDataGridViewTextBoxColumn.DataPropertyName = "period";
            this.periodDataGridViewTextBoxColumn.HeaderText = "period";
            this.periodDataGridViewTextBoxColumn.Name = "periodDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // printDialog_Printer
            // 
            this.printDialog_Printer.UseEXDialog = true;
            // 
            // printDocument_Printer
            // 
            //this.printDocument_Printer.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_Printer_PrintPage);
            // 
            // PrintCoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 415);
            this.Controls.Add(this.dataGridView_Courses);
            this.Controls.Add(this.button_ToPrinter);
            this.Controls.Add(this.button_SaveToTextFile);
            this.Name = "PrintCoursesForm";
            this.Text = "PrintCoursesForm";
            //this.Load += new System.EventHandler(this.PrintCoursesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.dATA_LOGINDataSet_Course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Courses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource courseBindingSource;
       // private DATA_LOGINDataSet_Course dATA_LOGINDataSet_Course;
        //private DATA_LOGINDataSet_CourseTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.Button button_ToPrinter;
        private System.Windows.Forms.Button button_SaveToTextFile;
        private System.Windows.Forms.DataGridView dataGridView_Courses;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.PrintDialog printDialog_Printer;
        private System.Drawing.Printing.PrintDocument printDocument_Printer;
    }
}