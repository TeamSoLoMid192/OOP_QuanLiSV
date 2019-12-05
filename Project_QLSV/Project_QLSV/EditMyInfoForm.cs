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

namespace Project_QLSV
{
    public partial class EditMyInfoForm : Form
    {
        USER user = new USER();
        string pic_string = "";
        public EditMyInfoForm()
        {
            InitializeComponent();
        }

        private void EditMyInfoForm_Load(object sender, EventArgs e)
        {
            StudentData stdDT = new StudentData();
            textBox_UserID.Text = Globals.GlobalUserID;
            stdDT = user.getUserByID(Globals.GlobalUserID);
            textBox_FirstName.Text = stdDT.FirstName;
            textBox_LastName.Text = stdDT.LastName;
            textBox_Username.Text = stdDT.UserName;
            textBox_Password.Text = stdDT.Password;
            pictureBox_Picture.Image = Image.FromFile(stdDT.Picture);
            pictureBox_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
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

        private void button_EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBox_UserID.Text;
                string fname = textBox_FirstName.Text;
                string lname = textBox_LastName.Text;
                string uname = textBox_Username.Text;
                string pwd = textBox_Password.Text;
                StudentData stdDT = new StudentData();
                user.getUserByID(id);
                string picstr = stdDT.Picture;
                //MessageBox.Show(picstr);
                if (pic_string != "")
                {
                    string targetPath = "Students/StudentsPictures/";
                    string file_path, file_name, file_extension;
                    file_path = Path.GetDirectoryName(pic_string); //lấy thư mục của file từ đường dẫn file
                    file_name = Path.GetFileNameWithoutExtension(pic_string); //lấy tên file không bao gồm phần đuôi kiểu file
                    file_extension = Path.GetExtension(pic_string); //lấy phần đuôi của file vd: .pdf,.png
                    picstr = targetPath + Globals.GlobalUserID + file_extension;
                    if (stdDT.Picture == "") 
                    {
                        File.Copy(pic_string, picstr);
                    }
                    else
                    {
                        GC.Collect();   // because picturebox is using by another process
                        GC.WaitForPendingFinalizers();  // because picturebox is using by another process

                        // delete your file.

                        File.Delete(picstr);
                        File.Copy(pic_string, picstr);
                    }

                }
                else
                {

                }
                pic_string = "";

                if (!lack_infomation())
                {
                    if (user.updateUser(id, fname, lname, uname, pwd, picstr))
                    {
                        MessageBox.Show("User edited", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Field", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid information", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
