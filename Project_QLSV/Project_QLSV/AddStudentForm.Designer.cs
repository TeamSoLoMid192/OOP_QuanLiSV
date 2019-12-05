namespace Project_QLSV
{
    partial class AddStudentForm
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
            this.label_StudentID = new System.Windows.Forms.Label();
            this.textBox_StudentID = new System.Windows.Forms.TextBox();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label_LastName = new System.Windows.Forms.Label();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.label_Birthdate = new System.Windows.Forms.Label();
            this.dateTimePicker_Birthdate = new System.Windows.Forms.DateTimePicker();
            this.label_Gender = new System.Windows.Forms.Label();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.label_Phone = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.label_Picture = new System.Windows.Forms.Label();
            this.pictureBox_Picture = new System.Windows.Forms.PictureBox();
            this.button_CANCEL = new System.Windows.Forms.Button();
            this.button_ADD = new System.Windows.Forms.Button();
            this.richTextBox_ADDRESS = new System.Windows.Forms.RichTextBox();
            this.button_UPLOADPICTURE = new System.Windows.Forms.Button();
            this.openFileDialog_PICTURE = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label_StudentID
            // 
            this.label_StudentID.AutoSize = true;
            this.label_StudentID.Location = new System.Drawing.Point(28, 17);
            this.label_StudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_StudentID.Name = "label_StudentID";
            this.label_StudentID.Size = new System.Drawing.Size(61, 13);
            this.label_StudentID.TabIndex = 0;
            this.label_StudentID.Text = "Student ID:";
            // 
            // textBox_StudentID
            // 
            this.textBox_StudentID.Location = new System.Drawing.Point(91, 13);
            this.textBox_StudentID.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_StudentID.Name = "textBox_StudentID";
            this.textBox_StudentID.Size = new System.Drawing.Size(188, 20);
            this.textBox_StudentID.TabIndex = 1;
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(28, 41);
            this.label_FirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(60, 13);
            this.label_FirstName.TabIndex = 2;
            this.label_FirstName.Text = "First Name:";
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(91, 38);
            this.textBox_FirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(188, 20);
            this.textBox_FirstName.TabIndex = 3;
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(28, 66);
            this.label_LastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(61, 13);
            this.label_LastName.TabIndex = 4;
            this.label_LastName.Text = "Last Name:";
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(91, 63);
            this.textBox_LastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(188, 20);
            this.textBox_LastName.TabIndex = 5;
            // 
            // label_Birthdate
            // 
            this.label_Birthdate.AutoSize = true;
            this.label_Birthdate.Location = new System.Drawing.Point(28, 93);
            this.label_Birthdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Birthdate.Name = "label_Birthdate";
            this.label_Birthdate.Size = new System.Drawing.Size(52, 13);
            this.label_Birthdate.TabIndex = 6;
            this.label_Birthdate.Text = "Birthdate:";
            // 
            // dateTimePicker_Birthdate
            // 
            this.dateTimePicker_Birthdate.Location = new System.Drawing.Point(91, 89);
            this.dateTimePicker_Birthdate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_Birthdate.Name = "dateTimePicker_Birthdate";
            this.dateTimePicker_Birthdate.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker_Birthdate.TabIndex = 7;
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Location = new System.Drawing.Point(28, 114);
            this.label_Gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(45, 13);
            this.label_Gender.TabIndex = 8;
            this.label_Gender.Text = "Gender:";
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Location = new System.Drawing.Point(91, 112);
            this.radioButton_Male.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(48, 17);
            this.radioButton_Male.TabIndex = 9;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "Male";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.Location = new System.Drawing.Point(178, 112);
            this.radioButton_Female.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.Size = new System.Drawing.Size(59, 17);
            this.radioButton_Female.TabIndex = 10;
            this.radioButton_Female.TabStop = true;
            this.radioButton_Female.Text = "Female";
            this.radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(91, 134);
            this.textBox_Phone.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(188, 20);
            this.textBox_Phone.TabIndex = 11;
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Location = new System.Drawing.Point(28, 136);
            this.label_Phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(41, 13);
            this.label_Phone.TabIndex = 12;
            this.label_Phone.Text = "Phone:";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(28, 165);
            this.label_Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(48, 13);
            this.label_Address.TabIndex = 14;
            this.label_Address.Text = "Address:";
            // 
            // label_Picture
            // 
            this.label_Picture.AutoSize = true;
            this.label_Picture.Location = new System.Drawing.Point(28, 235);
            this.label_Picture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Picture.Name = "label_Picture";
            this.label_Picture.Size = new System.Drawing.Size(43, 13);
            this.label_Picture.TabIndex = 15;
            this.label_Picture.Text = "Picture:";
            // 
            // pictureBox_Picture
            // 
            this.pictureBox_Picture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox_Picture.Location = new System.Drawing.Point(91, 235);
            this.pictureBox_Picture.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Picture.Name = "pictureBox_Picture";
            this.pictureBox_Picture.Size = new System.Drawing.Size(188, 176);
            this.pictureBox_Picture.TabIndex = 16;
            this.pictureBox_Picture.TabStop = false;
            // 
            // button_CANCEL
            // 
            this.button_CANCEL.Location = new System.Drawing.Point(91, 453);
            this.button_CANCEL.Margin = new System.Windows.Forms.Padding(2);
            this.button_CANCEL.Name = "button_CANCEL";
            this.button_CANCEL.Size = new System.Drawing.Size(88, 26);
            this.button_CANCEL.TabIndex = 17;
            this.button_CANCEL.Text = "CANCEL";
            this.button_CANCEL.UseVisualStyleBackColor = true;
            //this.button_CANCEL.Click += new System.EventHandler(this.button_CANCEL_Click);
            // 
            // button_ADD
            // 
            this.button_ADD.Location = new System.Drawing.Point(190, 453);
            this.button_ADD.Margin = new System.Windows.Forms.Padding(2);
            this.button_ADD.Name = "button_ADD";
            this.button_ADD.Size = new System.Drawing.Size(88, 26);
            this.button_ADD.TabIndex = 18;
            this.button_ADD.Text = "ADD";
            this.button_ADD.UseVisualStyleBackColor = true;
            //this.button_ADD.Click += new System.EventHandler(this.button_ADD_Click);
            // 
            // richTextBox_ADDRESS
            // 
            this.richTextBox_ADDRESS.Location = new System.Drawing.Point(91, 165);
            this.richTextBox_ADDRESS.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox_ADDRESS.Name = "richTextBox_ADDRESS";
            this.richTextBox_ADDRESS.Size = new System.Drawing.Size(188, 57);
            this.richTextBox_ADDRESS.TabIndex = 19;
            this.richTextBox_ADDRESS.Text = "";
            // 
            // button_UPLOADPICTURE
            // 
            this.button_UPLOADPICTURE.Location = new System.Drawing.Point(91, 410);
            this.button_UPLOADPICTURE.Margin = new System.Windows.Forms.Padding(2);
            this.button_UPLOADPICTURE.Name = "button_UPLOADPICTURE";
            this.button_UPLOADPICTURE.Size = new System.Drawing.Size(188, 28);
            this.button_UPLOADPICTURE.TabIndex = 20;
            this.button_UPLOADPICTURE.Text = "upload picture";
            this.button_UPLOADPICTURE.UseVisualStyleBackColor = true;
            //this.button_UPLOADPICTURE.Click += new System.EventHandler(this.button_UPLOADPICTURE_Click);
            // 
            // openFileDialog_PICTURE
            // 
            this.openFileDialog_PICTURE.FileName = "openFileDialog_PICTURE";
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 502);
            this.Controls.Add(this.button_UPLOADPICTURE);
            this.Controls.Add(this.richTextBox_ADDRESS);
            this.Controls.Add(this.button_ADD);
            this.Controls.Add(this.button_CANCEL);
            this.Controls.Add(this.pictureBox_Picture);
            this.Controls.Add(this.label_Picture);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.label_Phone);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.radioButton_Female);
            this.Controls.Add(this.radioButton_Male);
            this.Controls.Add(this.label_Gender);
            this.Controls.Add(this.dateTimePicker_Birthdate);
            this.Controls.Add(this.label_Birthdate);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.textBox_StudentID);
            this.Controls.Add(this.label_StudentID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddStudentForm";
            this.Text = "AddStudentForm";
            //this.Load += new System.EventHandler(this.AddStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_StudentID;
        private System.Windows.Forms.TextBox textBox_StudentID;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Label label_Birthdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Birthdate;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.RadioButton radioButton_Female;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_Picture;
        private System.Windows.Forms.PictureBox pictureBox_Picture;
        private System.Windows.Forms.Button button_CANCEL;
        private System.Windows.Forms.Button button_ADD;
        private System.Windows.Forms.RichTextBox richTextBox_ADDRESS;
        private System.Windows.Forms.Button button_UPLOADPICTURE;
        private System.Windows.Forms.OpenFileDialog openFileDialog_PICTURE;
    }
}