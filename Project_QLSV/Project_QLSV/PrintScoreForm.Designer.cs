namespace Project_QLSV
{
    partial class PrintScoreForm
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
            this.comboBox_Search = new System.Windows.Forms.ComboBox();
            this.button_SEARCH = new System.Windows.Forms.Button();
            this.textBox_SEARCH = new System.Windows.Forms.TextBox();
            this.dataGridView_Show = new System.Windows.Forms.DataGridView();
            this.button_Reload = new System.Windows.Forms.Button();
            this.button_SaveToTextFile = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_ToPrinter = new System.Windows.Forms.Button();
            this.printDocument_Printer = new System.Drawing.Printing.PrintDocument();
            this.printDialog_Printer = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Search
            // 
            this.comboBox_Search.FormattingEnabled = true;
            this.comboBox_Search.Location = new System.Drawing.Point(931, 12);
            this.comboBox_Search.Name = "comboBox_Search";
            this.comboBox_Search.Size = new System.Drawing.Size(66, 24);
            this.comboBox_Search.TabIndex = 62;
            // 
            // button_SEARCH
            // 
            this.button_SEARCH.Location = new System.Drawing.Point(648, 13);
            this.button_SEARCH.Name = "button_SEARCH";
            this.button_SEARCH.Size = new System.Drawing.Size(75, 23);
            this.button_SEARCH.TabIndex = 61;
            this.button_SEARCH.Text = "Search";
            this.button_SEARCH.UseVisualStyleBackColor = true;
            //this.button_SEARCH.Click += new System.EventHandler(this.button_SEARCH_Click);
            // 
            // textBox_SEARCH
            // 
            this.textBox_SEARCH.Location = new System.Drawing.Point(729, 14);
            this.textBox_SEARCH.Name = "textBox_SEARCH";
            this.textBox_SEARCH.Size = new System.Drawing.Size(196, 22);
            this.textBox_SEARCH.TabIndex = 60;
            // 
            // dataGridView_Show
            // 
            this.dataGridView_Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Show.Location = new System.Drawing.Point(12, 50);
            this.dataGridView_Show.Name = "dataGridView_Show";
            this.dataGridView_Show.RowTemplate.Height = 24;
            this.dataGridView_Show.Size = new System.Drawing.Size(985, 244);
            this.dataGridView_Show.TabIndex = 63;
            // 
            // button_Reload
            // 
            this.button_Reload.Location = new System.Drawing.Point(363, 310);
            this.button_Reload.Name = "button_Reload";
            this.button_Reload.Size = new System.Drawing.Size(177, 51);
            this.button_Reload.TabIndex = 67;
            this.button_Reload.Text = "Reload";
            this.button_Reload.UseVisualStyleBackColor = true;
            //this.button_Reload.Click += new System.EventHandler(this.button_Reload_Click);
            // 
            // button_SaveToTextFile
            // 
            this.button_SaveToTextFile.Location = new System.Drawing.Point(546, 310);
            this.button_SaveToTextFile.Name = "button_SaveToTextFile";
            this.button_SaveToTextFile.Size = new System.Drawing.Size(177, 51);
            this.button_SaveToTextFile.TabIndex = 66;
            this.button_SaveToTextFile.Text = "Save To Text File";
            this.button_SaveToTextFile.UseVisualStyleBackColor = true;
            //this.button_SaveToTextFile.Click += new System.EventHandler(this.button_SaveToTextFile_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(180, 310);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(177, 51);
            this.button_Cancel.TabIndex = 65;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
           // this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_ToPrinter
            // 
            this.button_ToPrinter.Location = new System.Drawing.Point(729, 310);
            this.button_ToPrinter.Name = "button_ToPrinter";
            this.button_ToPrinter.Size = new System.Drawing.Size(177, 51);
            this.button_ToPrinter.TabIndex = 64;
            this.button_ToPrinter.Text = "To Printer";
            this.button_ToPrinter.UseVisualStyleBackColor = true;
            //this.button_ToPrinter.Click += new System.EventHandler(this.button_ToPrinter_Click);
            // 
            // printDocument_Printer
            // 
            //this.printDocument_Printer.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_Printer_PrintPage);
            // 
            // printDialog_Printer
            // 
            this.printDialog_Printer.UseEXDialog = true;
            // 
            // PrintScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 377);
            this.Controls.Add(this.button_Reload);
            this.Controls.Add(this.button_SaveToTextFile);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_ToPrinter);
            this.Controls.Add(this.dataGridView_Show);
            this.Controls.Add(this.comboBox_Search);
            this.Controls.Add(this.button_SEARCH);
            this.Controls.Add(this.textBox_SEARCH);
            this.Name = "PrintScoreForm";
            this.Text = "PrintScoreForm";
            //this.Load += new System.EventHandler(this.PrintScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Search;
        private System.Windows.Forms.Button button_SEARCH;
        private System.Windows.Forms.TextBox textBox_SEARCH;
        private System.Windows.Forms.DataGridView dataGridView_Show;
        private System.Windows.Forms.Button button_Reload;
        private System.Windows.Forms.Button button_SaveToTextFile;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_ToPrinter;
        private System.Drawing.Printing.PrintDocument printDocument_Printer;
        private System.Windows.Forms.PrintDialog printDialog_Printer;
    }
}