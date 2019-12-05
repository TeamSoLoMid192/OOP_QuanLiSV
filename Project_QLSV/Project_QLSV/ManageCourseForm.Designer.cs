namespace Project_QLSV
{
    partial class ManageCourseForm
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
            this.components = new System.ComponentModel.Container();
            this.numericUpDown_CoursePeriod = new System.Windows.Forms.NumericUpDown();
            this.richTextBox_Description = new System.Windows.Forms.RichTextBox();
            this.label_Description = new System.Windows.Forms.Label();
            this.label_Period = new System.Windows.Forms.Label();
            this.textBox_Label = new System.Windows.Forms.TextBox();
            this.label_Label = new System.Windows.Forms.Label();
            this.label_CourseID = new System.Windows.Forms.Label();
            this.textBox_CourseID = new System.Windows.Forms.TextBox();
            this.button_EDIT = new System.Windows.Forms.Button();
            this.button_REMOVE = new System.Windows.Forms.Button();
            this.button_ADD = new System.Windows.Forms.Button();
            this.button_First = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Previous = new System.Windows.Forms.Button();
            this.button_Last = new System.Windows.Forms.Button();
            this.listBox_Course = new System.Windows.Forms.ListBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.dATA_LOGINDataSet_Course = new WindowsFormsApp2.DATA_LOGINDataSet_Course();
            this.label_TotalCourses = new System.Windows.Forms.Label();
            //this.courseTableAdapter = new WindowsFormsApp2.DATA_LOGINDataSet_CourseTableAdapters.CourseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CoursePeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.dATA_LOGINDataSet_Course)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_CoursePeriod
            // 
            this.numericUpDown_CoursePeriod.Location = new System.Drawing.Point(116, 86);
            this.numericUpDown_CoursePeriod.Name = "numericUpDown_CoursePeriod";
            this.numericUpDown_CoursePeriod.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_CoursePeriod.TabIndex = 38;
            // 
            // richTextBox_Description
            // 
            this.richTextBox_Description.Location = new System.Drawing.Point(116, 117);
            this.richTextBox_Description.Name = "richTextBox_Description";
            this.richTextBox_Description.Size = new System.Drawing.Size(250, 69);
            this.richTextBox_Description.TabIndex = 37;
            this.richTextBox_Description.Text = "";
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(12, 117);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(83, 17);
            this.label_Description.TabIndex = 36;
            this.label_Description.Text = "Description:";
            // 
            // label_Period
            // 
            this.label_Period.AutoSize = true;
            this.label_Period.Location = new System.Drawing.Point(12, 88);
            this.label_Period.Name = "label_Period";
            this.label_Period.Size = new System.Drawing.Size(53, 17);
            this.label_Period.TabIndex = 35;
            this.label_Period.Text = "Period:";
            // 
            // textBox_Label
            // 
            this.textBox_Label.Location = new System.Drawing.Point(116, 52);
            this.textBox_Label.Name = "textBox_Label";
            this.textBox_Label.Size = new System.Drawing.Size(250, 22);
            this.textBox_Label.TabIndex = 34;
            // 
            // label_Label
            // 
            this.label_Label.AutoSize = true;
            this.label_Label.Location = new System.Drawing.Point(12, 55);
            this.label_Label.Name = "label_Label";
            this.label_Label.Size = new System.Drawing.Size(47, 17);
            this.label_Label.TabIndex = 33;
            this.label_Label.Text = "Label:";
            // 
            // label_CourseID
            // 
            this.label_CourseID.AutoSize = true;
            this.label_CourseID.Location = new System.Drawing.Point(12, 26);
            this.label_CourseID.Name = "label_CourseID";
            this.label_CourseID.Size = new System.Drawing.Size(100, 17);
            this.label_CourseID.TabIndex = 32;
            this.label_CourseID.Text = "Select Course:";
            // 
            // textBox_CourseID
            // 
            this.textBox_CourseID.Location = new System.Drawing.Point(116, 21);
            this.textBox_CourseID.Name = "textBox_CourseID";
            this.textBox_CourseID.Size = new System.Drawing.Size(120, 22);
            this.textBox_CourseID.TabIndex = 39;
            // 
            // button_EDIT
            // 
            this.button_EDIT.Location = new System.Drawing.Point(164, 254);
            this.button_EDIT.Name = "button_EDIT";
            this.button_EDIT.Size = new System.Drawing.Size(100, 42);
            this.button_EDIT.TabIndex = 44;
            this.button_EDIT.Text = "Edit";
            this.button_EDIT.UseVisualStyleBackColor = true;
            //this.button_EDIT.Click += new System.EventHandler(this.button_EDIT_Click);
            // 
            // button_REMOVE
            // 
            this.button_REMOVE.Location = new System.Drawing.Point(270, 254);
            this.button_REMOVE.Name = "button_REMOVE";
            this.button_REMOVE.Size = new System.Drawing.Size(100, 42);
            this.button_REMOVE.TabIndex = 43;
            this.button_REMOVE.Text = "Remove";
            this.button_REMOVE.UseVisualStyleBackColor = true;
            //this.button_REMOVE.Click += new System.EventHandler(this.button_REMOVE_Click);
            // 
            // button_ADD
            // 
            this.button_ADD.Location = new System.Drawing.Point(58, 254);
            this.button_ADD.Name = "button_ADD";
            this.button_ADD.Size = new System.Drawing.Size(100, 42);
            this.button_ADD.TabIndex = 42;
            this.button_ADD.Text = "Add";
            this.button_ADD.UseVisualStyleBackColor = true;
            //this.button_ADD.Click += new System.EventHandler(this.button_ADD_Click);
            // 
            // button_First
            // 
            this.button_First.Location = new System.Drawing.Point(14, 202);
            this.button_First.Name = "button_First";
            this.button_First.Size = new System.Drawing.Size(96, 35);
            this.button_First.TabIndex = 45;
            this.button_First.Text = "First";
            this.button_First.UseVisualStyleBackColor = true;
            //this.button_First.Click += new System.EventHandler(this.button_First_Click);
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(116, 202);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(96, 35);
            this.button_Next.TabIndex = 46;
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = true;
            //this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_Previous
            // 
            this.button_Previous.Location = new System.Drawing.Point(218, 202);
            this.button_Previous.Name = "button_Previous";
            this.button_Previous.Size = new System.Drawing.Size(96, 35);
            this.button_Previous.TabIndex = 47;
            this.button_Previous.Text = "Previous";
            this.button_Previous.UseVisualStyleBackColor = true;
            //this.button_Previous.Click += new System.EventHandler(this.button_Previous_Click);
            // 
            // button_Last
            // 
            this.button_Last.Location = new System.Drawing.Point(320, 202);
            this.button_Last.Name = "button_Last";
            this.button_Last.Size = new System.Drawing.Size(96, 35);
            this.button_Last.TabIndex = 48;
            this.button_Last.Text = "Last";
            this.button_Last.UseVisualStyleBackColor = true;
            //this.button_Last.Click += new System.EventHandler(this.button_Last_Click);
            // 
            // listBox_Course
            // 
            this.listBox_Course.DataSource = this.courseBindingSource;
            this.listBox_Course.FormattingEnabled = true;
            this.listBox_Course.ItemHeight = 16;
            this.listBox_Course.Location = new System.Drawing.Point(449, 20);
            this.listBox_Course.Name = "listBox_Course";
            this.listBox_Course.Size = new System.Drawing.Size(303, 260);
            this.listBox_Course.TabIndex = 49;
            //this.listBox_Course.Click += new System.EventHandler(this.listBox_Course_Click);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            //this.courseBindingSource.DataSource = this.dATA_LOGINDataSet_Course;
            // 
            // dATA_LOGINDataSet_Course
            // 
            //this.dATA_LOGINDataSet_Course.DataSetName = "DATA_LOGINDataSet_Course";
            //this.dATA_LOGINDataSet_Course.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_TotalCourses
            // 
            this.label_TotalCourses.AutoSize = true;
            this.label_TotalCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalCourses.Location = new System.Drawing.Point(565, 283);
            this.label_TotalCourses.Name = "label_TotalCourses";
            this.label_TotalCourses.Size = new System.Drawing.Size(155, 25);
            this.label_TotalCourses.TabIndex = 50;
            this.label_TotalCourses.Text = "Total Courses:";
            // 
            // courseTableAdapter
            // 
            //this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // ManageCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 330);
            this.Controls.Add(this.label_TotalCourses);
            this.Controls.Add(this.listBox_Course);
            this.Controls.Add(this.button_Last);
            this.Controls.Add(this.button_Previous);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.button_First);
            this.Controls.Add(this.button_EDIT);
            this.Controls.Add(this.button_REMOVE);
            this.Controls.Add(this.button_ADD);
            this.Controls.Add(this.textBox_CourseID);
            this.Controls.Add(this.numericUpDown_CoursePeriod);
            this.Controls.Add(this.richTextBox_Description);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.label_Period);
            this.Controls.Add(this.textBox_Label);
            this.Controls.Add(this.label_Label);
            this.Controls.Add(this.label_CourseID);
            this.Name = "ManageCourseForm";
            this.Text = "ManageCourseForm";
            //this.Load += new System.EventHandler(this.ManageCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CoursePeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.dATA_LOGINDataSet_Course)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDown_CoursePeriod;
        private System.Windows.Forms.RichTextBox richTextBox_Description;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label_Period;
        private System.Windows.Forms.TextBox textBox_Label;
        private System.Windows.Forms.Label label_Label;
        private System.Windows.Forms.Label label_CourseID;
        private System.Windows.Forms.TextBox textBox_CourseID;
        private System.Windows.Forms.Button button_EDIT;
        private System.Windows.Forms.Button button_REMOVE;
        private System.Windows.Forms.Button button_ADD;
        private System.Windows.Forms.Button button_First;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Previous;
        private System.Windows.Forms.Button button_Last;
        private System.Windows.Forms.ListBox listBox_Course;
        private System.Windows.Forms.Label label_TotalCourses;
        //private DATA_LOGINDataSet_Course dATA_LOGINDataSet_Course;
        private System.Windows.Forms.BindingSource courseBindingSource;
        //private DATA_LOGINDataSet_CourseTableAdapters.CourseTableAdapter courseTableAdapter;
    }
}