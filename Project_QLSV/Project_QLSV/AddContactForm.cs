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
    public partial class AddContactForm : Form
    {
        //string pic_string = "";
        StudentData stdDT = new StudentData();
        USER user = new USER();
        Groups group = new Groups();
        public AddContactForm()
        {
            InitializeComponent();
        }

        private void button_UPLOADPICTURE_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            if ((openfiledialog.ShowDialog() == DialogResult.OK))
            {
                pictureBox_Picture.ImageLocation = openfiledialog.FileName;
                pictureBox_Picture.SizeMode = PictureBoxSizeMode.Normal;
                pictureBox_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
                //pic_string = openfiledialog.FileName;
                //MessageBox.Show(pic_string);
            }
        }
        bool lack_infomation()
        {
            if (textBox_Phone.Text.Trim() == ""
                || textBox_Email.Text.Trim() == ""
                || richTextBox_ADDRESS.Text.Trim() == ""
                || textBox_GroupID.Text.Trim() == ""
                || textBox_GroupID.Text.Trim() == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_ADD_Click(object sender, EventArgs e)
        {
            string group = comboBox_Group.Text;
            string phone = textBox_Phone.Text;
            string email = textBox_Email.Text;
            string groupID = textBox_GroupID.Text;
            string address = richTextBox_ADDRESS.Text;
            if(!lack_infomation())
            {
                Contacts contacts = new Contacts();
                contacts.add_contact(group, phone, email, groupID, address);
                //button_ADD.Enabled = false;
                this.Close();
                MessageBox.Show("Successful", "Add contact", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Empty Field", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            stdDT = user.getUserByID(Globals.GlobalUserID);
            textBox_FirstName.Text = stdDT.FirstName;
            textBox_LastName.Text = stdDT.LastName;
            textBox_Phone.Text = stdDT.Phone;
            textBox_Email.Text = stdDT.Email;
            textBox_GroupID.Text = stdDT.GroupID;
            richTextBox_ADDRESS.Text = stdDT.Address;

            comboBox_Group.DataSource = group.ListGroups;
            comboBox_Group.Text = stdDT.Group;

            pictureBox_Picture.Image = Image.FromFile(stdDT.Picture);
            pictureBox_Picture.SizeMode = PictureBoxSizeMode.StretchImage;

            if(!lack_infomation())
            {
                button_ADD.Enabled = false;
            }
        }
    }
}
