using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project_QLSV
{
    public partial class RegisterForm : Form
    {
        string pic_string = "";
        USER user = new USER();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void linkLabel_Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Form1 formLogin = new Form1();
            formLogin.Show();
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
                pic_string = openfiledialog.FileName;
                //MessageBox.Show(pic_string);
            }
        }

        bool lack_infomation()
        {
            if (textBox_FirstName.Text.Trim() == ""
                || textBox_LastName.Text.Trim() == ""
                || textBox_UserID.Text.Trim() == ""
                || textBox_Password.Text.Trim() == ""
                || textBox_Username.Text.Trim() == ""
                || pictureBox_Picture.Image == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBox_UserID.Text;
                string fname = textBox_FirstName.Text;
                string lname = textBox_LastName.Text;
                string uname = textBox_Username.Text;
                string pwd = textBox_Password.Text;

                XDocument findExist = XDocument.Load(AddressesString.user_accounts);
                try
                {
                    XElement foundE = findExist.Descendants("Account").Where(c => c.Element("UserName").Value.Equals(uname) || c.Element("UserID").Value.Equals(id)).First();
                    if (foundE.Element("UserName").Value == uname || foundE.Element("UserID").Value == id)
                    {
                        MessageBox.Show("UserName or UserID was exist", "Insert user", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                catch
                {

                }

                //StudentData stdDT = new StudentData();
                //user.getUserByID(id);
                string picstr = "";// = stdDT.Picture;
                if (pic_string != "")
                {
                    string targetPath = "Students/StudentsPictures/";
                    string file_path, file_name, file_extension;
                    file_path = Path.GetDirectoryName(pic_string); //lấy thư mục của file từ đường dẫn file
                    file_name = Path.GetFileNameWithoutExtension(pic_string); //lấy tên file không bao gồm phần đuôi kiểu file
                    file_extension = Path.GetExtension(pic_string); //lấy phần đuôi của file vd: .pdf,.png
                    picstr = targetPath + textBox_UserID.Text + file_extension;
                    File.Copy(pic_string, picstr);

                }
                pic_string = "";

                if (!lack_infomation())
                {
                    if (user.insertUser(id, fname, lname, uname, pwd, picstr))
                    {
                        MessageBox.Show("User Registed", "Register User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Register User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Field", "Register User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid information", "Register User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
