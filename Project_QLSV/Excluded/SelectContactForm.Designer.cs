namespace Project_QLSV
{
    partial class SelectContactForm
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
            this.dataGridView_Show = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Show
            // 
            this.dataGridView_Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Show.Location = new System.Drawing.Point(18, 20);
            this.dataGridView_Show.Name = "dataGridView_Show";
            this.dataGridView_Show.RowTemplate.Height = 24;
            this.dataGridView_Show.Size = new System.Drawing.Size(1039, 410);
            this.dataGridView_Show.TabIndex = 0;
            //this.dataGridView_Show.DoubleClick += new System.EventHandler(this.dataGridView_Show_DoubleClick);
            // 
            // SelectContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 450);
            this.Controls.Add(this.dataGridView_Show);
            this.Name = "SelectContactForm";
            this.Text = "SelectContactForm";
            //this.Load += new System.EventHandler(this.SelectContactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Show)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView_Show;
    }
}