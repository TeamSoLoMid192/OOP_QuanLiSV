using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QLSV
{
    public partial class EditUserDataForm : Form
    {
        USER user = new USER();
        StudentData stdDT = new StudentData();
        public EditUserDataForm()
        {
            InitializeComponent();
        }

        private void linkLabel_Exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Form1 formLogin = new Form1();
            formLogin.Show();
        }

        private void linkLabel_EditMyInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox_Picture.Image = null;
            //GC.Collect();   // because picturebox is using by another process
            //GC.WaitForPendingFinalizers();  // because picturebox is using by another process
            EditMyInfoForm editMyInfoForm = new EditMyInfoForm();
            editMyInfoForm.ShowDialog();
            pictureBox_Picture.Image = Image.FromFile(stdDT.Picture);
        }

        void getImageAndUsername()
        {
            stdDT = user.getUserByID(Globals.GlobalUserID);
            pictureBox_Picture.Image = Image.FromFile(stdDT.Picture);
            pictureBox_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            label_Username.Text = "Welcome back (" + stdDT.UserName + ")";
        }

        private void EditUserDataForm_Load(object sender, EventArgs e)
        {
            getImageAndUsername();
            Groups group = new Groups();
            comboBox_EditGroup.DataSource = group.ListGroups;
            comboBox_EditGroup.Text = stdDT.Group;
            //comboBox_EditGroupID.DataSource = group.getGroups(Globals.GlobalUserId);
            //comboBox_EditGroupID.DisplayMember = "name";
            //comboBox_EditGroupID.ValueMember = "Id";
            //comboBox_EditGroupID.SelectedItem = null;
            //comboBox_RemoveGroupID.DataSource = group.getGroups(Globals.GlobalUserId);
            //comboBox_RemoveGroupID.DisplayMember = "name";
            //comboBox_RemoveGroupID.ValueMember = "Id";
            //comboBox_RemoveGroupID.SelectedItem = null;
        }

        private void button_ADD_Click(object sender, EventArgs e)
        {
            AddContactForm addContactForm = new AddContactForm();
            addContactForm.ShowDialog();

        }

        private void button_EDIT_Click(object sender, EventArgs e)
        {
            EditContactForm editContactForm = new EditContactForm();
            editContactForm.ShowDialog();
        }

        private void button_EditGroup_Click(object sender, EventArgs e)
        {
            Groups group = new Groups();
            group.edit_a_group(stdDT.Group, textBox_NewName.Text);
            MessageBox.Show("Successful", "Edit group name", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_AddGroup_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel_Refresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditUserDataForm_Load(sender, e);
        }
    }
}
