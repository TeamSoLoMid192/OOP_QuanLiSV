namespace Project_QLSV
{
    partial class EditMyInfoForm
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
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label_UserName = new System.Windows.Forms.Label();
            this.button_UPLOADPICTURE = new System.Windows.Forms.Button();
            this.pictureBox_Picture = new System.Windows.Forms.PictureBox();
            this.label_Picture = new System.Windows.Forms.Label();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.label_LastName = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.textBox_UserID = new System.Windows.Forms.TextBox();
            this.label_UserID = new System.Windows.Forms.Label();
            this.button_EDIT = new System.Windows.Forms.Button();
            this.openFileDialog_PICTURE = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(72, 111);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(188, 20);
            this.textBox_Password.TabIndex = 40;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(9, 114);
            this.label_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(56, 13);
            this.label_Password.TabIndex = 39;
            this.label_Password.Text = "Password:";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(72, 86);
            this.textBox_Username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.ReadOnly = true;
            this.textBox_Username.Size = new System.Drawing.Size(188, 20);
            this.textBox_Username.TabIndex = 38;
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Location = new System.Drawing.Point(9, 89);
            this.label_UserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(58, 13);
            this.label_UserName.TabIndex = 37;
            this.label_UserName.Text = "Username:";
            // 
            // button_UPLOADPICTURE
            // 
            this.button_UPLOADPICTURE.Location = new System.Drawing.Point(72, 317);
            this.button_UPLOADPICTURE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_UPLOADPICTURE.Name = "button_UPLOADPICTURE";
            this.button_UPLOADPICTURE.Size = new System.Drawing.Size(188, 28);
            this.button_UPLOADPICTURE.TabIndex = 36;
            this.button_UPLOADPICTURE.Text = "upload picture";
            this.button_UPLOADPICTURE.UseVisualStyleBackColor = true;
            this.button_UPLOADPICTURE.Click += new System.EventHandler(this.button_UPLOADPICTURE_Click);
            // 
            // pictureBox_Picture
            // 
            this.pictureBox_Picture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox_Picture.Location = new System.Drawing.Point(72, 141);
            this.pictureBox_Picture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_Picture.Name = "pictureBox_Picture";
            this.pictureBox_Picture.Size = new System.Drawing.Size(188, 176);
            this.pictureBox_Picture.TabIndex = 35;
            this.pictureBox_Picture.TabStop = false;
            // 
            // label_Picture
            // 
            this.label_Picture.AutoSize = true;
            this.label_Picture.Location = new System.Drawing.Point(9, 141);
            this.label_Picture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Picture.Name = "label_Picture";
            this.label_Picture.Size = new System.Drawing.Size(43, 13);
            this.label_Picture.TabIndex = 34;
            this.label_Picture.Text = "Picture:";
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(72, 62);
            this.textBox_LastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(188, 20);
            this.textBox_LastName.TabIndex = 33;
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(9, 64);
            this.label_LastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(61, 13);
            this.label_LastName.TabIndex = 32;
            this.label_LastName.Text = "Last Name:";
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(72, 37);
            this.textBox_FirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(188, 20);
            this.textBox_FirstName.TabIndex = 31;
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(9, 39);
            this.label_FirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(60, 13);
            this.label_FirstName.TabIndex = 30;
            this.label_FirstName.Text = "First Name:";
            // 
            // textBox_UserID
            // 
            this.textBox_UserID.Location = new System.Drawing.Point(72, 11);
            this.textBox_UserID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_UserID.Name = "textBox_UserID";
            this.textBox_UserID.ReadOnly = true;
            this.textBox_UserID.Size = new System.Drawing.Size(188, 20);
            this.textBox_UserID.TabIndex = 29;
            // 
            // label_UserID
            // 
            this.label_UserID.AutoSize = true;
            this.label_UserID.Location = new System.Drawing.Point(9, 15);
            this.label_UserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_UserID.Name = "label_UserID";
            this.label_UserID.Size = new System.Drawing.Size(46, 13);
            this.label_UserID.TabIndex = 28;
            this.label_UserID.Text = "User ID:";
            // 
            // button_EDIT
            // 
            this.button_EDIT.Location = new System.Drawing.Point(93, 353);
            this.button_EDIT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_EDIT.Name = "button_EDIT";
            this.button_EDIT.Size = new System.Drawing.Size(141, 43);
            this.button_EDIT.TabIndex = 47;
            this.button_EDIT.Text = "Edit";
            this.button_EDIT.UseVisualStyleBackColor = true;
            this.button_EDIT.Click += new System.EventHandler(this.button_EDIT_Click);
            // 
            // openFileDialog_PICTURE
            // 
            this.openFileDialog_PICTURE.FileName = "openFileDialog_PICTURE";
            // 
            // EditMyInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 406);
            this.Controls.Add(this.button_EDIT);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label_UserName);
            this.Controls.Add(this.button_UPLOADPICTURE);
            this.Controls.Add(this.pictureBox_Picture);
            this.Controls.Add(this.label_Picture);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.textBox_UserID);
            this.Controls.Add(this.label_UserID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditMyInfoForm";
            this.Text = "EditMyInfoForm";
            this.Load += new System.EventHandler(this.EditMyInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.Button button_UPLOADPICTURE;
        private System.Windows.Forms.PictureBox pictureBox_Picture;
        private System.Windows.Forms.Label label_Picture;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.TextBox textBox_UserID;
        private System.Windows.Forms.Label label_UserID;
        private System.Windows.Forms.Button button_EDIT;
        private System.Windows.Forms.OpenFileDialog openFileDialog_PICTURE;
    }
}