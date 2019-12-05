namespace Project_QLSV
{
    partial class ShowFullListForm
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
            this.listBox_Group = new System.Windows.Forms.ListBox();
            this.dataGridView_Show = new System.Windows.Forms.DataGridView();
            this.button_ShowAll = new System.Windows.Forms.Button();
            this.label_Group = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Group
            // 
            this.listBox_Group.FormattingEnabled = true;
            this.listBox_Group.ItemHeight = 16;
            this.listBox_Group.Location = new System.Drawing.Point(3, 59);
            this.listBox_Group.Name = "listBox_Group";
            this.listBox_Group.Size = new System.Drawing.Size(209, 228);
            this.listBox_Group.TabIndex = 0;
            //this.listBox_Group.Click += new System.EventHandler(this.listBox_Group_Click);
            // 
            // dataGridView_Show
            // 
            this.dataGridView_Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Show.Location = new System.Drawing.Point(227, 59);
            this.dataGridView_Show.Name = "dataGridView_Show";
            this.dataGridView_Show.RowTemplate.Height = 24;
            this.dataGridView_Show.Size = new System.Drawing.Size(1039, 410);
            this.dataGridView_Show.TabIndex = 1;
            // 
            // button_ShowAll
            // 
            this.button_ShowAll.Location = new System.Drawing.Point(35, 305);
            this.button_ShowAll.Name = "button_ShowAll";
            this.button_ShowAll.Size = new System.Drawing.Size(140, 41);
            this.button_ShowAll.TabIndex = 2;
            this.button_ShowAll.Text = "Show All";
            this.button_ShowAll.UseVisualStyleBackColor = true;
            //this.button_ShowAll.Click += new System.EventHandler(this.button_ShowAll_Click);
            // 
            // label_Group
            // 
            this.label_Group.AutoSize = true;
            this.label_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Group.Location = new System.Drawing.Point(-2, 20);
            this.label_Group.Name = "label_Group";
            this.label_Group.Size = new System.Drawing.Size(66, 25);
            this.label_Group.TabIndex = 3;
            this.label_Group.Text = "Group";
            // 
            // ShowFullListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 487);
            this.Controls.Add(this.label_Group);
            this.Controls.Add(this.button_ShowAll);
            this.Controls.Add(this.dataGridView_Show);
            this.Controls.Add(this.listBox_Group);
            this.Name = "ShowFullListForm";
            this.Text = "ShowFullListForm";
            //this.Load += new System.EventHandler(this.ShowFullListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Group;
        public System.Windows.Forms.DataGridView dataGridView_Show;
        private System.Windows.Forms.Button button_ShowAll;
        private System.Windows.Forms.Label label_Group;
    }
}