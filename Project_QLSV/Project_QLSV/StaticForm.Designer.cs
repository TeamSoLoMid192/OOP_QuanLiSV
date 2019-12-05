namespace Project_QLSV
{
    partial class StaticForm
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
            this.panel_Total = new System.Windows.Forms.Panel();
            this.panel_Male = new System.Windows.Forms.Panel();
            this.panel_Female = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label_TotalStudent = new System.Windows.Forms.Label();
            this.label_Male = new System.Windows.Forms.Label();
            this.label_Female = new System.Windows.Forms.Label();
            this.panel_Total.SuspendLayout();
            this.panel_Male.SuspendLayout();
            this.panel_Female.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Total
            // 
            this.panel_Total.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel_Total.Controls.Add(this.label_TotalStudent);
            this.panel_Total.Location = new System.Drawing.Point(2, 6);
            this.panel_Total.Name = "panel_Total";
            this.panel_Total.Size = new System.Drawing.Size(796, 188);
            this.panel_Total.TabIndex = 0;
            //this.panel_Total.MouseEnter += new System.EventHandler(this.panel_Total_MouseEnter);
            //this.panel_Total.MouseLeave += new System.EventHandler(this.panel_Total_MouseLeave);
            // 
            // panel_Male
            // 
            this.panel_Male.BackColor = System.Drawing.Color.Lime;
            this.panel_Male.Controls.Add(this.label_Male);
            this.panel_Male.Location = new System.Drawing.Point(2, 200);
            this.panel_Male.Name = "panel_Male";
            this.panel_Male.Size = new System.Drawing.Size(395, 188);
            this.panel_Male.TabIndex = 1;
            //this.panel_Male.MouseEnter += new System.EventHandler(this.panel_Male_MouseEnter);
            //this.panel_Male.MouseLeave += new System.EventHandler(this.panel_Male_MouseLeave);
            // 
            // panel_Female
            // 
            this.panel_Female.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel_Female.Controls.Add(this.label_Female);
            this.panel_Female.Location = new System.Drawing.Point(403, 200);
            this.panel_Female.Name = "panel_Female";
            this.panel_Female.Size = new System.Drawing.Size(395, 188);
            this.panel_Female.TabIndex = 2;
            //this.panel_Female.MouseEnter += new System.EventHandler(this.panel_Female_MouseEnter);
            //this.panel_Female.MouseLeave += new System.EventHandler(this.panel_Female_MouseLeave);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label_TotalStudent
            // 
            this.label_TotalStudent.AutoSize = true;
            this.label_TotalStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalStudent.Location = new System.Drawing.Point(10, 77);
            this.label_TotalStudent.Name = "label_TotalStudent";
            this.label_TotalStudent.Size = new System.Drawing.Size(214, 36);
            this.label_TotalStudent.TabIndex = 0;
            this.label_TotalStudent.Text = "Total Student:";
            // 
            // label_Male
            // 
            this.label_Male.AutoSize = true;
            this.label_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Male.Location = new System.Drawing.Point(10, 92);
            this.label_Male.Name = "label_Male";
            this.label_Male.Size = new System.Drawing.Size(83, 36);
            this.label_Male.TabIndex = 0;
            this.label_Male.Text = "Male";
            // 
            // label_Female
            // 
            this.label_Female.AutoSize = true;
            this.label_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Female.Location = new System.Drawing.Point(14, 92);
            this.label_Female.Name = "label_Female";
            this.label_Female.Size = new System.Drawing.Size(117, 36);
            this.label_Female.TabIndex = 0;
            this.label_Female.Text = "Female";
            // 
            // StaticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 403);
            this.Controls.Add(this.panel_Female);
            this.Controls.Add(this.panel_Male);
            this.Controls.Add(this.panel_Total);
            this.Name = "StaticsForm";
            this.Text = "StaticsForm";
            //this.Load += new System.EventHandler(this.StaticsForm_Load);
            this.panel_Total.ResumeLayout(false);
            this.panel_Total.PerformLayout();
            this.panel_Male.ResumeLayout(false);
            this.panel_Male.PerformLayout();
            this.panel_Female.ResumeLayout(false);
            this.panel_Female.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Total;
        private System.Windows.Forms.Label label_TotalStudent;
        private System.Windows.Forms.Panel panel_Male;
        private System.Windows.Forms.Label label_Male;
        private System.Windows.Forms.Panel panel_Female;
        private System.Windows.Forms.Label label_Female;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}