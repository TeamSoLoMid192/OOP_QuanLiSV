namespace Project_QLSV
{
    partial class AddCourseForm
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
            this.textBox_Period = new System.Windows.Forms.TextBox();
            this.label_Period = new System.Windows.Forms.Label();
            this.textBox_Label = new System.Windows.Forms.TextBox();
            this.label_Label = new System.Windows.Forms.Label();
            this.textBox_CourseID = new System.Windows.Forms.TextBox();
            this.label_CourseID = new System.Windows.Forms.Label();
            this.richTextBox_Description = new System.Windows.Forms.RichTextBox();
            this.label_Description = new System.Windows.Forms.Label();
            this.button_ADD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Period
            // 
            this.textBox_Period.Location = new System.Drawing.Point(96, 80);
            this.textBox_Period.Name = "textBox_Period";
            this.textBox_Period.Size = new System.Drawing.Size(121, 22);
            this.textBox_Period.TabIndex = 11;
            // 
            // label_Period
            // 
            this.label_Period.AutoSize = true;
            this.label_Period.Location = new System.Drawing.Point(12, 85);
            this.label_Period.Name = "label_Period";
            this.label_Period.Size = new System.Drawing.Size(53, 17);
            this.label_Period.TabIndex = 10;
            this.label_Period.Text = "Period:";
            // 
            // textBox_Label
            // 
            this.textBox_Label.Location = new System.Drawing.Point(96, 49);
            this.textBox_Label.Name = "textBox_Label";
            this.textBox_Label.Size = new System.Drawing.Size(250, 22);
            this.textBox_Label.TabIndex = 9;
            // 
            // label_Label
            // 
            this.label_Label.AutoSize = true;
            this.label_Label.Location = new System.Drawing.Point(12, 52);
            this.label_Label.Name = "label_Label";
            this.label_Label.Size = new System.Drawing.Size(47, 17);
            this.label_Label.TabIndex = 8;
            this.label_Label.Text = "Label:";
            // 
            // textBox_CourseID
            // 
            this.textBox_CourseID.Location = new System.Drawing.Point(96, 18);
            this.textBox_CourseID.Name = "textBox_CourseID";
            this.textBox_CourseID.Size = new System.Drawing.Size(121, 22);
            this.textBox_CourseID.TabIndex = 7;
            // 
            // label_CourseID
            // 
            this.label_CourseID.AutoSize = true;
            this.label_CourseID.Location = new System.Drawing.Point(12, 23);
            this.label_CourseID.Name = "label_CourseID";
            this.label_CourseID.Size = new System.Drawing.Size(74, 17);
            this.label_CourseID.TabIndex = 6;
            this.label_CourseID.Text = "Course ID:";
            // 
            // richTextBox_Description
            // 
            this.richTextBox_Description.Location = new System.Drawing.Point(96, 114);
            this.richTextBox_Description.Name = "richTextBox_Description";
            this.richTextBox_Description.Size = new System.Drawing.Size(250, 69);
            this.richTextBox_Description.TabIndex = 21;
            this.richTextBox_Description.Text = "";
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(12, 114);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(83, 17);
            this.label_Description.TabIndex = 20;
            this.label_Description.Text = "Description:";
            // 
            // button_ADD
            // 
            this.button_ADD.Location = new System.Drawing.Point(64, 205);
            this.button_ADD.Name = "button_ADD";
            this.button_ADD.Size = new System.Drawing.Size(282, 32);
            this.button_ADD.TabIndex = 22;
            this.button_ADD.Text = "ADD";
            this.button_ADD.UseVisualStyleBackColor = true;
            //this.button_ADD.Click += new System.EventHandler(this.button_ADD_Click);
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 260);
            this.Controls.Add(this.button_ADD);
            this.Controls.Add(this.richTextBox_Description);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.textBox_Period);
            this.Controls.Add(this.label_Period);
            this.Controls.Add(this.textBox_Label);
            this.Controls.Add(this.label_Label);
            this.Controls.Add(this.textBox_CourseID);
            this.Controls.Add(this.label_CourseID);
            this.Name = "AddCourseForm";
            this.Text = "AddCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Period;
        private System.Windows.Forms.Label label_Period;
        private System.Windows.Forms.TextBox textBox_Label;
        private System.Windows.Forms.Label label_Label;
        private System.Windows.Forms.TextBox textBox_CourseID;
        private System.Windows.Forms.Label label_CourseID;
        private System.Windows.Forms.RichTextBox richTextBox_Description;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Button button_ADD;
    }
}