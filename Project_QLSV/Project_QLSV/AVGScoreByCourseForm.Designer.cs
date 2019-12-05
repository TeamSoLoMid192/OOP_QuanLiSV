namespace Project_QLSV
{
    partial class AVGScoreByCourseForm
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
            this.dataGridView_AVGScoreByCourse = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AVGScoreByCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_AVGScoreByCourse
            // 
            this.dataGridView_AVGScoreByCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AVGScoreByCourse.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_AVGScoreByCourse.Name = "dataGridView_AVGScoreByCourse";
            this.dataGridView_AVGScoreByCourse.RowTemplate.Height = 24;
            this.dataGridView_AVGScoreByCourse.Size = new System.Drawing.Size(324, 253);
            this.dataGridView_AVGScoreByCourse.TabIndex = 0;
            // 
            // AVGScoreByCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 277);
            this.Controls.Add(this.dataGridView_AVGScoreByCourse);
            this.Name = "AVGScoreByCourseForm";
            this.Text = "AVGScoreByCourseForm";
            //this.Load += new System.EventHandler(this.AVGScoreByCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AVGScoreByCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_AVGScoreByCourse;
    }
}