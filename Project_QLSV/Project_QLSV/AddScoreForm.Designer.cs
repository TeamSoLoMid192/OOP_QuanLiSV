namespace Project_QLSV
{
    partial class AddScoreForm
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
            this.textBox_StudentID = new System.Windows.Forms.TextBox();
            this.label_StudentID = new System.Windows.Forms.Label();
            this.comboBox_CourseID = new System.Windows.Forms.ComboBox();
            this.label_CourseID = new System.Windows.Forms.Label();
            this.textBox_Score = new System.Windows.Forms.TextBox();
            this.label_Score = new System.Windows.Forms.Label();
            this.richTextBox_Description = new System.Windows.Forms.RichTextBox();
            this.label_Description = new System.Windows.Forms.Label();
            this.button_ADD = new System.Windows.Forms.Button();
            this.dataGridView_Score = new System.Windows.Forms.DataGridView();
            //this.dATA_LOGINDataSet_Score = new WindowsFormsApp2.DATA_LOGINDataSet_Score();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.studentTableAdapter = new WindowsFormsApp2.DATA_LOGINDataSet_ScoreTableAdapters.StudentTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Score)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.dATA_LOGINDataSet_Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_StudentID
            // 
            this.textBox_StudentID.Location = new System.Drawing.Point(149, 42);
            this.textBox_StudentID.Name = "textBox_StudentID";
            this.textBox_StudentID.Size = new System.Drawing.Size(120, 22);
            this.textBox_StudentID.TabIndex = 3;
            // 
            // label_StudentID
            // 
            this.label_StudentID.AutoSize = true;
            this.label_StudentID.Location = new System.Drawing.Point(43, 47);
            this.label_StudentID.Name = "label_StudentID";
            this.label_StudentID.Size = new System.Drawing.Size(78, 17);
            this.label_StudentID.TabIndex = 2;
            this.label_StudentID.Text = "Student ID:";
            // 
            // comboBox_CourseID
            // 
            this.comboBox_CourseID.FormattingEnabled = true;
            this.comboBox_CourseID.Location = new System.Drawing.Point(149, 74);
            this.comboBox_CourseID.Name = "comboBox_CourseID";
            this.comboBox_CourseID.Size = new System.Drawing.Size(221, 24);
            this.comboBox_CourseID.TabIndex = 33;
            // 
            // label_CourseID
            // 
            this.label_CourseID.AutoSize = true;
            this.label_CourseID.Location = new System.Drawing.Point(43, 81);
            this.label_CourseID.Name = "label_CourseID";
            this.label_CourseID.Size = new System.Drawing.Size(100, 17);
            this.label_CourseID.TabIndex = 32;
            this.label_CourseID.Text = "Select Course:";
            // 
            // textBox_Score
            // 
            this.textBox_Score.Location = new System.Drawing.Point(149, 113);
            this.textBox_Score.Name = "textBox_Score";
            this.textBox_Score.Size = new System.Drawing.Size(120, 22);
            this.textBox_Score.TabIndex = 35;
            // 
            // label_Score
            // 
            this.label_Score.AutoSize = true;
            this.label_Score.Location = new System.Drawing.Point(43, 118);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(49, 17);
            this.label_Score.TabIndex = 34;
            this.label_Score.Text = "Score:";
            // 
            // richTextBox_Description
            // 
            this.richTextBox_Description.Location = new System.Drawing.Point(149, 150);
            this.richTextBox_Description.Name = "richTextBox_Description";
            this.richTextBox_Description.Size = new System.Drawing.Size(221, 69);
            this.richTextBox_Description.TabIndex = 39;
            this.richTextBox_Description.Text = "";
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(45, 150);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(83, 17);
            this.label_Description.TabIndex = 38;
            this.label_Description.Text = "Description:";
            // 
            // button_ADD
            // 
            this.button_ADD.Location = new System.Drawing.Point(175, 239);
            this.button_ADD.Name = "button_ADD";
            this.button_ADD.Size = new System.Drawing.Size(173, 42);
            this.button_ADD.TabIndex = 43;
            this.button_ADD.Text = "Add Score";
            this.button_ADD.UseVisualStyleBackColor = true;
            //this.button_ADD.Click += new System.EventHandler(this.button_ADD_Click);
            // 
            // dataGridView_Score
            // 
            this.dataGridView_Score.AutoGenerateColumns = false;
            this.dataGridView_Score.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Score.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn});
            this.dataGridView_Score.DataSource = this.studentBindingSource;
            this.dataGridView_Score.Location = new System.Drawing.Point(405, 42);
            this.dataGridView_Score.Name = "dataGridView_Score";
            this.dataGridView_Score.RowTemplate.Height = 24;
            this.dataGridView_Score.Size = new System.Drawing.Size(462, 239);
            this.dataGridView_Score.TabIndex = 44;
            //this.dataGridView_Score.DoubleClick += new System.EventHandler(this.dataGridView_Score_DoubleClick);
            // 
            // dATA_LOGINDataSet_Score
            // 
            //this.dATA_LOGINDataSet_Score.DataSetName = "DATA_LOGINDataSet_Score";
            //this.dATA_LOGINDataSet_Score.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            //this.studentBindingSource.DataSource = this.dATA_LOGINDataSet_Score;
            // 
            // studentTableAdapter
            // 
            //this.studentTableAdapter.ClearBeforeFill = true;
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
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 310);
            this.Controls.Add(this.dataGridView_Score);
            this.Controls.Add(this.button_ADD);
            this.Controls.Add(this.richTextBox_Description);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.textBox_Score);
            this.Controls.Add(this.label_Score);
            this.Controls.Add(this.comboBox_CourseID);
            this.Controls.Add(this.label_CourseID);
            this.Controls.Add(this.textBox_StudentID);
            this.Controls.Add(this.label_StudentID);
            this.Name = "AddScoreForm";
            this.Text = "AddScoreForm";
            //this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Score)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.dATA_LOGINDataSet_Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_StudentID;
        private System.Windows.Forms.Label label_StudentID;
        private System.Windows.Forms.ComboBox comboBox_CourseID;
        private System.Windows.Forms.Label label_CourseID;
        private System.Windows.Forms.TextBox textBox_Score;
        private System.Windows.Forms.Label label_Score;
        private System.Windows.Forms.RichTextBox richTextBox_Description;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Button button_ADD;
        private System.Windows.Forms.DataGridView dataGridView_Score;
        //private DATA_LOGINDataSet_Score dATA_LOGINDataSet_Score;
        private System.Windows.Forms.BindingSource studentBindingSource;
        //private DATA_LOGINDataSet_ScoreTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
    }
}