namespace Project_QLSV
{
    partial class EditCourseForm
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
            this.label_Period = new System.Windows.Forms.Label();
            this.textBox_Label = new System.Windows.Forms.TextBox();
            this.label_Label = new System.Windows.Forms.Label();
            this.label_CourseID = new System.Windows.Forms.Label();
            this.numericUpDown_CoursePeriod = new System.Windows.Forms.NumericUpDown();
            this.comboBox_CourseID = new System.Windows.Forms.ComboBox();
            this.button_Edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CoursePeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox_Description
            // 
            this.richTextBox_Description.Location = new System.Drawing.Point(116, 114);
            this.richTextBox_Description.Name = "richTextBox_Description";
            this.richTextBox_Description.Size = new System.Drawing.Size(250, 69);
            this.richTextBox_Description.TabIndex = 29;
            this.richTextBox_Description.Text = "";
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(12, 114);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(83, 17);
            this.label_Description.TabIndex = 28;
            this.label_Description.Text = "Description:";
            // 
            // label_Period
            // 
            this.label_Period.AutoSize = true;
            this.label_Period.Location = new System.Drawing.Point(12, 85);
            this.label_Period.Name = "label_Period";
            this.label_Period.Size = new System.Drawing.Size(53, 17);
            this.label_Period.TabIndex = 26;
            this.label_Period.Text = "Period:";
            // 
            // textBox_Label
            // 
            this.textBox_Label.Location = new System.Drawing.Point(116, 49);
            this.textBox_Label.Name = "textBox_Label";
            this.textBox_Label.Size = new System.Drawing.Size(250, 22);
            this.textBox_Label.TabIndex = 25;
            // 
            // label_Label
            // 
            this.label_Label.AutoSize = true;
            this.label_Label.Location = new System.Drawing.Point(12, 52);
            this.label_Label.Name = "label_Label";
            this.label_Label.Size = new System.Drawing.Size(47, 17);
            this.label_Label.TabIndex = 24;
            this.label_Label.Text = "Label:";
            // 
            // label_CourseID
            // 
            this.label_CourseID.AutoSize = true;
            this.label_CourseID.Location = new System.Drawing.Point(12, 23);
            this.label_CourseID.Name = "label_CourseID";
            this.label_CourseID.Size = new System.Drawing.Size(100, 17);
            this.label_CourseID.TabIndex = 22;
            this.label_CourseID.Text = "Select Course:";
            // 
            // numericUpDown_CoursePeriod
            // 
            this.numericUpDown_CoursePeriod.Location = new System.Drawing.Point(116, 83);
            this.numericUpDown_CoursePeriod.Name = "numericUpDown_CoursePeriod";
            this.numericUpDown_CoursePeriod.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_CoursePeriod.TabIndex = 30;
            // 
            // comboBox_CourseID
            // 
            this.comboBox_CourseID.FormattingEnabled = true;
            this.comboBox_CourseID.Location = new System.Drawing.Point(116, 20);
            this.comboBox_CourseID.Name = "comboBox_CourseID";
            this.comboBox_CourseID.Size = new System.Drawing.Size(120, 24);
            this.comboBox_CourseID.TabIndex = 31;
            //this.comboBox_CourseID.SelectedIndexChanged += new System.EventHandler(this.comboBox_CourseID_SelectedIndexChanged);
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(55, 200);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(282, 32);
            this.button_Edit.TabIndex = 32;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            //this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 260);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.comboBox_CourseID);
            this.Controls.Add(this.numericUpDown_CoursePeriod);
            this.Controls.Add(this.richTextBox_Description);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.label_Period);
            this.Controls.Add(this.textBox_Label);
            this.Controls.Add(this.label_Label);
            this.Controls.Add(this.label_CourseID);
            this.Name = "EditCourseForm";
            this.Text = "EditCourseForm";
            //this.Load += new System.EventHandler(this.EditCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CoursePeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Description;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label_Period;
        private System.Windows.Forms.TextBox textBox_Label;
        private System.Windows.Forms.Label label_Label;
        private System.Windows.Forms.Label label_CourseID;
        private System.Windows.Forms.NumericUpDown numericUpDown_CoursePeriod;
        private System.Windows.Forms.ComboBox comboBox_CourseID;
        private System.Windows.Forms.Button button_Edit;
    }
}