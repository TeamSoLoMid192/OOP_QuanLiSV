namespace Project_QLSV
{
    partial class Form1
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
            this.button_EXIT = new System.Windows.Forms.Button();
            this.button_LOGIN = new System.Windows.Forms.Button();
            this.label_USERNAME = new System.Windows.Forms.Label();
            this.label_PASSWORD = new System.Windows.Forms.Label();
            this.textBox_USERNAME = new System.Windows.Forms.TextBox();
            this.textBox_PASSWORD = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel_Register = new System.Windows.Forms.LinkLabel();
            this.label_Register = new System.Windows.Forms.Label();
            this.radioButton_Student = new System.Windows.Forms.RadioButton();
            this.radioButton_Admin = new System.Windows.Forms.RadioButton();
            this.label_Login = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_EXIT
            // 
            this.button_EXIT.Location = new System.Drawing.Point(218, 136);
            this.button_EXIT.Margin = new System.Windows.Forms.Padding(2);
            this.button_EXIT.Name = "button_EXIT";
            this.button_EXIT.Size = new System.Drawing.Size(98, 54);
            this.button_EXIT.TabIndex = 0;
            this.button_EXIT.Text = "E&XIT";
            this.button_EXIT.UseVisualStyleBackColor = true;
            this.button_EXIT.Click += new System.EventHandler(this.button_EXIT_Click);
            // 
            // button_LOGIN
            // 
            this.button_LOGIN.Location = new System.Drawing.Point(321, 136);
            this.button_LOGIN.Margin = new System.Windows.Forms.Padding(2);
            this.button_LOGIN.Name = "button_LOGIN";
            this.button_LOGIN.Size = new System.Drawing.Size(98, 54);
            this.button_LOGIN.TabIndex = 1;
            this.button_LOGIN.Text = "LOGIN";
            this.button_LOGIN.UseVisualStyleBackColor = true;
            this.button_LOGIN.Click += new System.EventHandler(this.button_LOGIN_Click);
            // 
            // label_USERNAME
            // 
            this.label_USERNAME.AutoSize = true;
            this.label_USERNAME.Location = new System.Drawing.Point(178, 57);
            this.label_USERNAME.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_USERNAME.Name = "label_USERNAME";
            this.label_USERNAME.Size = new System.Drawing.Size(71, 13);
            this.label_USERNAME.TabIndex = 2;
            this.label_USERNAME.Text = "USERNAME:";
            // 
            // label_PASSWORD
            // 
            this.label_PASSWORD.AutoSize = true;
            this.label_PASSWORD.Location = new System.Drawing.Point(178, 102);
            this.label_PASSWORD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_PASSWORD.Name = "label_PASSWORD";
            this.label_PASSWORD.Size = new System.Drawing.Size(73, 13);
            this.label_PASSWORD.TabIndex = 3;
            this.label_PASSWORD.Text = "PASSWORD:";
            // 
            // textBox_USERNAME
            // 
            this.textBox_USERNAME.Location = new System.Drawing.Point(249, 57);
            this.textBox_USERNAME.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_USERNAME.Name = "textBox_USERNAME";
            this.textBox_USERNAME.Size = new System.Drawing.Size(171, 20);
            this.textBox_USERNAME.TabIndex = 4;
            // 
            // textBox_PASSWORD
            // 
            this.textBox_PASSWORD.Location = new System.Drawing.Point(249, 99);
            this.textBox_PASSWORD.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_PASSWORD.Name = "textBox_PASSWORD";
            this.textBox_PASSWORD.Size = new System.Drawing.Size(171, 20);
            this.textBox_PASSWORD.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 182);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel_Register
            // 
            this.linkLabel_Register.AutoSize = true;
            this.linkLabel_Register.Location = new System.Drawing.Point(128, 244);
            this.linkLabel_Register.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_Register.Name = "linkLabel_Register";
            this.linkLabel_Register.Size = new System.Drawing.Size(69, 13);
            this.linkLabel_Register.TabIndex = 7;
            this.linkLabel_Register.TabStop = true;
            this.linkLabel_Register.Text = "Register now";
            this.linkLabel_Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Register_LinkClicked);
            // 
            // label_Register
            // 
            this.label_Register.AutoSize = true;
            this.label_Register.Location = new System.Drawing.Point(9, 244);
            this.label_Register.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Register.Name = "label_Register";
            this.label_Register.Size = new System.Drawing.Size(122, 13);
            this.label_Register.TabIndex = 8;
            this.label_Register.Text = "Don\'t have an account?";
            // 
            // radioButton_Student
            // 
            this.radioButton_Student.AutoSize = true;
            this.radioButton_Student.Checked = true;
            this.radioButton_Student.Location = new System.Drawing.Point(218, 203);
            this.radioButton_Student.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_Student.Name = "radioButton_Student";
            this.radioButton_Student.Size = new System.Drawing.Size(62, 17);
            this.radioButton_Student.TabIndex = 9;
            this.radioButton_Student.TabStop = true;
            this.radioButton_Student.Text = "Student";
            this.radioButton_Student.UseVisualStyleBackColor = true;
            // 
            // radioButton_Admin
            // 
            this.radioButton_Admin.AutoSize = true;
            this.radioButton_Admin.Location = new System.Drawing.Point(312, 203);
            this.radioButton_Admin.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_Admin.Name = "radioButton_Admin";
            this.radioButton_Admin.Size = new System.Drawing.Size(85, 17);
            this.radioButton_Admin.TabIndex = 10;
            this.radioButton_Admin.Text = "Administrator";
            this.radioButton_Admin.UseVisualStyleBackColor = true;
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login.Location = new System.Drawing.Point(176, 10);
            this.label_Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(137, 25);
            this.label_Login.TabIndex = 11;
            this.label_Login.Text = "Account Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(454, 265);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.radioButton_Admin);
            this.Controls.Add(this.radioButton_Student);
            this.Controls.Add(this.label_Register);
            this.Controls.Add(this.linkLabel_Register);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_PASSWORD);
            this.Controls.Add(this.textBox_USERNAME);
            this.Controls.Add(this.label_PASSWORD);
            this.Controls.Add(this.label_USERNAME);
            this.Controls.Add(this.button_LOGIN);
            this.Controls.Add(this.button_EXIT);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_EXIT;
        private System.Windows.Forms.Button button_LOGIN;
        private System.Windows.Forms.Label label_USERNAME;
        private System.Windows.Forms.Label label_PASSWORD;
        private System.Windows.Forms.TextBox textBox_USERNAME;
        private System.Windows.Forms.TextBox textBox_PASSWORD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel_Register;
        private System.Windows.Forms.Label label_Register;
        private System.Windows.Forms.RadioButton radioButton_Student;
        private System.Windows.Forms.RadioButton radioButton_Admin;
        private System.Windows.Forms.Label label_Login;
    }
}