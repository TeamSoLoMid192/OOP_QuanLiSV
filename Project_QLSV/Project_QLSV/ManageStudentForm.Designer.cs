namespace Project_QLSV
{
    partial class ManageStudentForm
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
            this.richTextBox_ADDRESS = new System.Windows.Forms.RichTextBox();
            this.label_Address = new System.Windows.Forms.Label();
            this.label_Phone = new System.Windows.Forms.Label();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.label_Gender = new System.Windows.Forms.Label();
            this.dateTimePicker_Birthdate = new System.Windows.Forms.DateTimePicker();
            this.label_Birthdate = new System.Windows.Forms.Label();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.label_LastName = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.textBox_StudentID = new System.Windows.Forms.TextBox();
            this.label_StudentID = new System.Windows.Forms.Label();
            this.pictureBox_Picture = new System.Windows.Forms.PictureBox();
            this.label_Picture = new System.Windows.Forms.Label();
            this.button_UPLOADPICTURE = new System.Windows.Forms.Button();
            this.button_DOWNLOADPICTURE = new System.Windows.Forms.Button();
            this.openFileDialog_PICTURE = new System.Windows.Forms.OpenFileDialog();
            this.button_ADD = new System.Windows.Forms.Button();
            this.button_REMOVE = new System.Windows.Forms.Button();
            this.button_EDIT = new System.Windows.Forms.Button();
            this.button_RESET = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SEARCH = new System.Windows.Forms.TextBox();
            this.button_SEARCH = new System.Windows.Forms.Button();
            this.dataGridView_StudentListForm = new System.Windows.Forms.DataGridView();
            this.label_TotalStudents = new System.Windows.Forms.Label();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StudentListForm)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox_ADDRESS
            // 
            this.richTextBox_ADDRESS.Location = new System.Drawing.Point(94, 196);
            this.richTextBox_ADDRESS.Name = "richTextBox_ADDRESS";
            this.richTextBox_ADDRESS.Size = new System.Drawing.Size(250, 69);
            this.richTextBox_ADDRESS.TabIndex = 34;
            this.richTextBox_ADDRESS.Text = "";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(10, 196);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(64, 17);
            this.label_Address.TabIndex = 33;
            this.label_Address.Text = "Address:";
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Location = new System.Drawing.Point(10, 164);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(53, 17);
            this.label_Phone.TabIndex = 32;
            this.label_Phone.Text = "Phone:";
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(94, 161);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(250, 22);
            this.textBox_Phone.TabIndex = 31;
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.Location = new System.Drawing.Point(210, 134);
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.Size = new System.Drawing.Size(75, 21);
            this.radioButton_Female.TabIndex = 30;
            this.radioButton_Female.TabStop = true;
            this.radioButton_Female.Text = "Female";
            this.radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Location = new System.Drawing.Point(94, 134);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(59, 21);
            this.radioButton_Male.TabIndex = 29;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "Male";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Location = new System.Drawing.Point(10, 136);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(60, 17);
            this.label_Gender.TabIndex = 28;
            this.label_Gender.Text = "Gender:";
            // 
            // dateTimePicker_Birthdate
            // 
            this.dateTimePicker_Birthdate.Location = new System.Drawing.Point(94, 105);
            this.dateTimePicker_Birthdate.Name = "dateTimePicker_Birthdate";
            this.dateTimePicker_Birthdate.Size = new System.Drawing.Size(250, 22);
            this.dateTimePicker_Birthdate.TabIndex = 27;
            // 
            // label_Birthdate
            // 
            this.label_Birthdate.AutoSize = true;
            this.label_Birthdate.Location = new System.Drawing.Point(10, 110);
            this.label_Birthdate.Name = "label_Birthdate";
            this.label_Birthdate.Size = new System.Drawing.Size(69, 17);
            this.label_Birthdate.TabIndex = 26;
            this.label_Birthdate.Text = "Birthdate:";
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(94, 74);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(250, 22);
            this.textBox_LastName.TabIndex = 25;
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(10, 79);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(80, 17);
            this.label_LastName.TabIndex = 24;
            this.label_LastName.Text = "Last Name:";
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(94, 43);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(250, 22);
            this.textBox_FirstName.TabIndex = 23;
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(10, 46);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(80, 17);
            this.label_FirstName.TabIndex = 22;
            this.label_FirstName.Text = "First Name:";
            // 
            // textBox_StudentID
            // 
            this.textBox_StudentID.Location = new System.Drawing.Point(94, 12);
            this.textBox_StudentID.Name = "textBox_StudentID";
            this.textBox_StudentID.Size = new System.Drawing.Size(250, 22);
            this.textBox_StudentID.TabIndex = 21;
            // 
            // label_StudentID
            // 
            this.label_StudentID.AutoSize = true;
            this.label_StudentID.Location = new System.Drawing.Point(10, 17);
            this.label_StudentID.Name = "label_StudentID";
            this.label_StudentID.Size = new System.Drawing.Size(78, 17);
            this.label_StudentID.TabIndex = 20;
            this.label_StudentID.Text = "Student ID:";
            // 
            // pictureBox_Picture
            // 
            this.pictureBox_Picture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox_Picture.Location = new System.Drawing.Point(94, 274);
            this.pictureBox_Picture.Name = "pictureBox_Picture";
            this.pictureBox_Picture.Size = new System.Drawing.Size(250, 216);
            this.pictureBox_Picture.TabIndex = 36;
            this.pictureBox_Picture.TabStop = false;
            // 
            // label_Picture
            // 
            this.label_Picture.AutoSize = true;
            this.label_Picture.Location = new System.Drawing.Point(10, 274);
            this.label_Picture.Name = "label_Picture";
            this.label_Picture.Size = new System.Drawing.Size(56, 17);
            this.label_Picture.TabIndex = 35;
            this.label_Picture.Text = "Picture:";
            // 
            // button_UPLOADPICTURE
            // 
            this.button_UPLOADPICTURE.Location = new System.Drawing.Point(94, 496);
            this.button_UPLOADPICTURE.Name = "button_UPLOADPICTURE";
            this.button_UPLOADPICTURE.Size = new System.Drawing.Size(115, 34);
            this.button_UPLOADPICTURE.TabIndex = 37;
            this.button_UPLOADPICTURE.Text = "upload";
            this.button_UPLOADPICTURE.UseVisualStyleBackColor = true;
            //this.button_UPLOADPICTURE.Click += new System.EventHandler(this.button_UPLOADPICTURE_Click);
            // 
            // button_DOWNLOADPICTURE
            // 
            this.button_DOWNLOADPICTURE.Location = new System.Drawing.Point(229, 496);
            this.button_DOWNLOADPICTURE.Name = "button_DOWNLOADPICTURE";
            this.button_DOWNLOADPICTURE.Size = new System.Drawing.Size(115, 34);
            this.button_DOWNLOADPICTURE.TabIndex = 38;
            this.button_DOWNLOADPICTURE.Text = "download";
            this.button_DOWNLOADPICTURE.UseVisualStyleBackColor = true;
            //this.button_DOWNLOADPICTURE.Click += new System.EventHandler(this.button_DOWNLOADPICTURE_Click);
            // 
            // openFileDialog_PICTURE
            // 
            this.openFileDialog_PICTURE.FileName = "openFileDialog_PICTURE";
            // 
            // button_ADD
            // 
            this.button_ADD.Location = new System.Drawing.Point(13, 553);
            this.button_ADD.Name = "button_ADD";
            this.button_ADD.Size = new System.Drawing.Size(100, 42);
            this.button_ADD.TabIndex = 39;
            this.button_ADD.Text = "Add";
            this.button_ADD.UseVisualStyleBackColor = true;
            //this.button_ADD.Click += new System.EventHandler(this.button_ADD_Click);
            // 
            // button_REMOVE
            // 
            this.button_REMOVE.Location = new System.Drawing.Point(225, 553);
            this.button_REMOVE.Name = "button_REMOVE";
            this.button_REMOVE.Size = new System.Drawing.Size(100, 42);
            this.button_REMOVE.TabIndex = 40;
            this.button_REMOVE.Text = "Remove";
            this.button_REMOVE.UseVisualStyleBackColor = true;
            //this.button_REMOVE.Click += new System.EventHandler(this.button_REMOVE_Click);
            // 
            // button_EDIT
            // 
            this.button_EDIT.Location = new System.Drawing.Point(119, 553);
            this.button_EDIT.Name = "button_EDIT";
            this.button_EDIT.Size = new System.Drawing.Size(100, 42);
            this.button_EDIT.TabIndex = 41;
            this.button_EDIT.Text = "Edit";
            this.button_EDIT.UseVisualStyleBackColor = true;
            //this.button_EDIT.Click += new System.EventHandler(this.button_EDIT_Click);
            // 
            // button_RESET
            // 
            this.button_RESET.Location = new System.Drawing.Point(331, 553);
            this.button_RESET.Name = "button_RESET";
            this.button_RESET.Size = new System.Drawing.Size(100, 42);
            this.button_RESET.TabIndex = 42;
            this.button_RESET.Text = "Reset";
            this.button_RESET.UseVisualStyleBackColor = true;
            //this.button_RESET.Click += new System.EventHandler(this.button_RESET_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(916, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Search FName, LName, Address:";
            // 
            // textBox_SEARCH
            // 
            this.textBox_SEARCH.Location = new System.Drawing.Point(1141, 12);
            this.textBox_SEARCH.Name = "textBox_SEARCH";
            this.textBox_SEARCH.Size = new System.Drawing.Size(250, 22);
            this.textBox_SEARCH.TabIndex = 44;
            // 
            // button_SEARCH
            // 
            this.button_SEARCH.Location = new System.Drawing.Point(1411, 11);
            this.button_SEARCH.Name = "button_SEARCH";
            this.button_SEARCH.Size = new System.Drawing.Size(75, 23);
            this.button_SEARCH.TabIndex = 45;
            this.button_SEARCH.Text = "Search";
            this.button_SEARCH.UseVisualStyleBackColor = true;
            //this.button_SEARCH.Click += new System.EventHandler(this.button_SEARCH_Click);
            // 
            // dataGridView_StudentListForm
            // 
            this.dataGridView_StudentListForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_StudentListForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_StudentListForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.bdateDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.dataGridView_StudentListForm.Location = new System.Drawing.Point(371, 46);
            this.dataGridView_StudentListForm.Name = "dataGridView_StudentListForm";
            this.dataGridView_StudentListForm.RowTemplate.Height = 24;
            this.dataGridView_StudentListForm.Size = new System.Drawing.Size(1121, 484);
            this.dataGridView_StudentListForm.TabIndex = 46;
            //this.dataGridView_StudentListForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_StudentListForm_CellContentClick);
            //this.dataGridView_StudentListForm.DoubleClick += new System.EventHandler(this.dataGridView_StudentListForm_DoubleClick);
            // 
            // label_TotalStudents
            // 
            this.label_TotalStudents.AutoSize = true;
            this.label_TotalStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalStudents.Location = new System.Drawing.Point(1149, 533);
            this.label_TotalStudents.Name = "label_TotalStudents";
            this.label_TotalStudents.Size = new System.Drawing.Size(189, 29);
            this.label_TotalStudents.TabIndex = 47;
            this.label_TotalStudents.Text = "Total Students:";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "picture";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // bdateDataGridViewTextBoxColumn
            // 
            this.bdateDataGridViewTextBoxColumn.DataPropertyName = "bdate";
            this.bdateDataGridViewTextBoxColumn.HeaderText = "bdate";
            this.bdateDataGridViewTextBoxColumn.Name = "bdateDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "lname";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "fname";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // ManageStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 615);
            this.Controls.Add(this.label_TotalStudents);
            this.Controls.Add(this.dataGridView_StudentListForm);
            this.Controls.Add(this.button_SEARCH);
            this.Controls.Add(this.textBox_SEARCH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_RESET);
            this.Controls.Add(this.button_EDIT);
            this.Controls.Add(this.button_REMOVE);
            this.Controls.Add(this.button_ADD);
            this.Controls.Add(this.button_DOWNLOADPICTURE);
            this.Controls.Add(this.button_UPLOADPICTURE);
            this.Controls.Add(this.pictureBox_Picture);
            this.Controls.Add(this.label_Picture);
            this.Controls.Add(this.richTextBox_ADDRESS);
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
            this.Name = "ManageStudentForm";
            this.Text = "ManageStudentForm";
            //this.Load += new System.EventHandler(this.ManageStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StudentListForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_ADDRESS;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.RadioButton radioButton_Female;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Birthdate;
        private System.Windows.Forms.Label label_Birthdate;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.TextBox textBox_StudentID;
        private System.Windows.Forms.Label label_StudentID;
        private System.Windows.Forms.PictureBox pictureBox_Picture;
        private System.Windows.Forms.Label label_Picture;
        private System.Windows.Forms.Button button_UPLOADPICTURE;
        private System.Windows.Forms.Button button_DOWNLOADPICTURE;
        private System.Windows.Forms.OpenFileDialog openFileDialog_PICTURE;
        private System.Windows.Forms.Button button_ADD;
        private System.Windows.Forms.Button button_REMOVE;
        private System.Windows.Forms.Button button_EDIT;
        private System.Windows.Forms.Button button_RESET;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_SEARCH;
        private System.Windows.Forms.Button button_SEARCH;
        private System.Windows.Forms.DataGridView dataGridView_StudentListForm;
        private System.Windows.Forms.Label label_TotalStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
    }
}