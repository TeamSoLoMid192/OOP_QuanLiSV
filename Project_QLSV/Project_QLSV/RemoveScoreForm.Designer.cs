namespace Project_QLSV
{
    partial class RemoveScoreForm
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
            this.button_REMOVE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Show
            // 
            this.dataGridView_Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Show.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Show.Name = "dataGridView_Show";
            this.dataGridView_Show.RowTemplate.Height = 24;
            this.dataGridView_Show.Size = new System.Drawing.Size(769, 317);
            this.dataGridView_Show.TabIndex = 54;
            // 
            // button_REMOVE
            // 
            this.button_REMOVE.Location = new System.Drawing.Point(12, 335);
            this.button_REMOVE.Name = "button_REMOVE";
            this.button_REMOVE.Size = new System.Drawing.Size(100, 42);
            this.button_REMOVE.TabIndex = 55;
            this.button_REMOVE.Text = "Remove";
            this.button_REMOVE.UseVisualStyleBackColor = true;
            //this.button_REMOVE.Click += new System.EventHandler(this.button_REMOVE_Click);
            // 
            // RemoveScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 386);
            this.Controls.Add(this.button_REMOVE);
            this.Controls.Add(this.dataGridView_Show);
            this.Name = "RemoveScoreForm";
            this.Text = "RemoveScoreForm";
            //this.Load += new System.EventHandler(this.RemoveScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Show)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Show;
        private System.Windows.Forms.Button button_REMOVE;
    }
}