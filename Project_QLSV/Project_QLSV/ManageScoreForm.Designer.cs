namespace Project_QLSV
{
    partial class ManageScoreForm
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
            this.richTextBox_Description = new System.Windows.Forms.RichTextBox();
            this.label_Description = new System.Windows.Forms.Label();
            this.textBox_Score = new System.Windows.Forms.TextBox();
            this.label_Score = new System.Windows.Forms.Label();
            this.comboBox_CourseID = new System.Windows.Forms.ComboBox();
            this.label_CourseID = new System.Windows.Forms.Label();
            this.textBox_StudentID = new System.Windows.Forms.TextBox();
            this.label_StudentID = new System.Windows.Forms.Label();
            this.button_REMOVE = new System.Windows.Forms.Button();
            this.button_ADD = new System.Windows.Forms.Button();
            this.button_AverageScoreByCourse = new System.Windows.Forms.Button();
            this.button_ShowStudent = new System.Windows.Forms.Button();
            this.button_ShowScore = new System.Windows.Forms.Button();
            this.dataGridView_Show = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox_Description
            // 
            this.richTextBox_Description.Location = new System.Drawing.Point(128, 127);
            this.richTextBox_Description.Name = "richTextBox_Description";
            this.richTextBox_Description.Size = new System.Drawing.Size(221, 69);
            this.richTextBox_Description.TabIndex = 47;
            this.richTextBox_Description.Text = "";
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(24, 127);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(83, 17);
            this.label_Description.TabIndex = 46;
            this.label_Description.Text = "Description:";
            // 
            // textBox_Score
            // 
            this.textBox_Score.Location = new System.Drawing.Point(128, 90);
            this.textBox_Score.Name = "textBox_Score";
            this.textBox_Score.Size = new System.Drawing.Size(120, 22);
            this.textBox_Score.TabIndex = 45;
            // 
            // label_Score
            // 
            this.label_Score.AutoSize = true;
            this.label_Score.Location = new System.Drawing.Point(22, 95);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(49, 17);
            this.label_Score.TabIndex = 44;
            this.label_Score.Text = "Score:";
            // 
            // comboBox_CourseID
            // 
            this.comboBox_CourseID.FormattingEnabled = true;
            this.comboBox_CourseID.Location = new System.Drawing.Point(128, 51);
            this.comboBox_CourseID.Name = "comboBox_CourseID";
            this.comboBox_CourseID.Size = new System.Drawing.Size(221, 24);
            this.comboBox_CourseID.TabIndex = 43;
            // 
            // label_CourseID
            // 
            this.label_CourseID.AutoSize = true;
            this.label_CourseID.Location = new System.Drawing.Point(22, 58);
            this.label_CourseID.Name = "label_CourseID";
            this.label_CourseID.Size = new System.Drawing.Size(100, 17);
            this.label_CourseID.TabIndex = 42;
            this.label_CourseID.Text = "Select Course:";
            // 
            // textBox_StudentID
            // 
            this.textBox_StudentID.Location = new System.Drawing.Point(128, 19);
            this.textBox_StudentID.Name = "textBox_StudentID";
            this.textBox_StudentID.Size = new System.Drawing.Size(120, 22);
            this.textBox_StudentID.TabIndex = 41;
            // 
            // label_StudentID
            // 
            this.label_StudentID.AutoSize = true;
            this.label_StudentID.Location = new System.Drawing.Point(22, 24);
            this.label_StudentID.Name = "label_StudentID";
            this.label_StudentID.Size = new System.Drawing.Size(78, 17);
            this.label_StudentID.TabIndex = 40;
            this.label_StudentID.Text = "Student ID:";
            // 
            // button_REMOVE
            // 
            this.button_REMOVE.Location = new System.Drawing.Point(239, 214);
            this.button_REMOVE.Name = "button_REMOVE";
            this.button_REMOVE.Size = new System.Drawing.Size(100, 42);
            this.button_REMOVE.TabIndex = 49;
            this.button_REMOVE.Text = "Remove";
            this.button_REMOVE.UseVisualStyleBackColor = true;
            //this.button_REMOVE.Click += new System.EventHandler(this.button_REMOVE_Click);
            // 
            // button_ADD
            // 
            this.button_ADD.Location = new System.Drawing.Point(128, 214);
            this.button_ADD.Name = "button_ADD";
            this.button_ADD.Size = new System.Drawing.Size(100, 42);
            this.button_ADD.TabIndex = 48;
            this.button_ADD.Text = "Add";
            this.button_ADD.UseVisualStyleBackColor = true;
            //this.button_ADD.Click += new System.EventHandler(this.button_ADD_Click);
            // 
            // button_AverageScoreByCourse
            // 
            this.button_AverageScoreByCourse.Location = new System.Drawing.Point(128, 267);
            this.button_AverageScoreByCourse.Name = "button_AverageScoreByCourse";
            this.button_AverageScoreByCourse.Size = new System.Drawing.Size(211, 42);
            this.button_AverageScoreByCourse.TabIndex = 50;
            this.button_AverageScoreByCourse.Text = "Average Score By Course";
            this.button_AverageScoreByCourse.UseVisualStyleBackColor = true;
            //this.button_AverageScoreByCourse.Click += new System.EventHandler(this.button_AverageScoreByCourse_Click);
            // 
            // button_ShowStudent
            // 
            this.button_ShowStudent.Location = new System.Drawing.Point(480, 19);
            this.button_ShowStudent.Name = "button_ShowStudent";
            this.button_ShowStudent.Size = new System.Drawing.Size(260, 29);
            this.button_ShowStudent.TabIndex = 51;
            this.button_ShowStudent.Text = "Show Student";
            this.button_ShowStudent.UseVisualStyleBackColor = true;
            //this.button_ShowStudent.Click += new System.EventHandler(this.button_ShowStudent_Click);
            // 
            // button_ShowScore
            // 
            this.button_ShowScore.Location = new System.Drawing.Point(830, 19);
            this.button_ShowScore.Name = "button_ShowScore";
            this.button_ShowScore.Size = new System.Drawing.Size(260, 29);
            this.button_ShowScore.TabIndex = 52;
            this.button_ShowScore.Text = "Show Score";
            this.button_ShowScore.UseVisualStyleBackColor = true;
            //this.button_ShowScore.Click += new System.EventHandler(this.button_ShowScore_Click);
            // 
            // dataGridView_Show
            // 
            this.dataGridView_Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Show.Location = new System.Drawing.Point(407, 65);
            this.dataGridView_Show.Name = "dataGridView_Show";
            this.dataGridView_Show.RowTemplate.Height = 24;
            this.dataGridView_Show.Size = new System.Drawing.Size(769, 244);
            this.dataGridView_Show.TabIndex = 53;
            //this.dataGridView_Show.DoubleClick += new System.EventHandler(this.dataGridView_Show_DoubleClick);
            // 
            // ManageScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 321);
            this.Controls.Add(this.dataGridView_Show);
            this.Controls.Add(this.button_ShowScore);
            this.Controls.Add(this.button_ShowStudent);
            this.Controls.Add(this.button_AverageScoreByCourse);
            this.Controls.Add(this.button_REMOVE);
            this.Controls.Add(this.button_ADD);
            this.Controls.Add(this.richTextBox_Description);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.textBox_Score);
            this.Controls.Add(this.label_Score);
            this.Controls.Add(this.comboBox_CourseID);
            this.Controls.Add(this.label_CourseID);
            this.Controls.Add(this.textBox_StudentID);
            this.Controls.Add(this.label_StudentID);
            this.Name = "ManageScoresForm";
            this.Text = "ManageScoresForm";
            //this.Load += new System.EventHandler(this.ManageScoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Description;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.TextBox textBox_Score;
        private System.Windows.Forms.Label label_Score;
        private System.Windows.Forms.ComboBox comboBox_CourseID;
        private System.Windows.Forms.Label label_CourseID;
        private System.Windows.Forms.TextBox textBox_StudentID;
        private System.Windows.Forms.Label label_StudentID;
        private System.Windows.Forms.Button button_REMOVE;
        private System.Windows.Forms.Button button_ADD;
        private System.Windows.Forms.Button button_AverageScoreByCourse;
        private System.Windows.Forms.Button button_ShowStudent;
        private System.Windows.Forms.Button button_ShowScore;
        private System.Windows.Forms.DataGridView dataGridView_Show;
    }
}