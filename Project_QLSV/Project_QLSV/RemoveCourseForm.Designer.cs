namespace Project_QLSV
{
    partial class RemoveCourseForm
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
            this.textBox_CourseID = new System.Windows.Forms.TextBox();
            this.label_CourseID = new System.Windows.Forms.Label();
            this.button_Remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_CourseID
            // 
            this.textBox_CourseID.Location = new System.Drawing.Point(176, 49);
            this.textBox_CourseID.Name = "textBox_CourseID";
            this.textBox_CourseID.Size = new System.Drawing.Size(203, 22);
            this.textBox_CourseID.TabIndex = 9;
            // 
            // label_CourseID
            // 
            this.label_CourseID.AutoSize = true;
            this.label_CourseID.Location = new System.Drawing.Point(29, 52);
            this.label_CourseID.Name = "label_CourseID";
            this.label_CourseID.Size = new System.Drawing.Size(141, 17);
            this.label_CourseID.TabIndex = 8;
            this.label_CourseID.Text = "Enter The Course ID:";
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(411, 41);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(137, 39);
            this.button_Remove.TabIndex = 10;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = true;
            //this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // RemoveCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 118);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.textBox_CourseID);
            this.Controls.Add(this.label_CourseID);
            this.Name = "RemoveCourseForm";
            this.Text = "RemoveCourseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_CourseID;
        private System.Windows.Forms.Label label_CourseID;
        private System.Windows.Forms.Button button_Remove;
    }
}