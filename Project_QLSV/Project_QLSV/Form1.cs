using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project_QLSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void button_EXIT_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Resources/trueDMG.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button_LOGIN_Click(object sender, EventArgs e)
        {
            if(radioButton_Student.Checked == true)
            {
                XDocument data = XDocument.Load(AddressesString.user_accounts);
                try
                {
                    XElement findAcc = data.Descendants("Account").Where(c => c.Element("UserName").Value.Equals(textBox_USERNAME.Text) && c.Element("Password").Value.Equals(textBox_PASSWORD.Text)).First();
                    string user_ID = findAcc.Element("UserID").Value;
                    Globals.SetGlobalUserId(user_ID);
                    this.Hide();
                    this.DialogResult = DialogResult.OK;
                    EditUserDataForm editUserDataForm = new EditUserDataForm();
                    editUserDataForm.Show();
                }
                catch
                {
                    MessageBox.Show(" Invalid Username or Password", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if(radioButton_Admin.Checked == true)
            {
                XDocument data = XDocument.Load(AddressesString.admin_accounts);
                try
                {
                    XElement findAcc = data.Descendants("Account").Where(c => c.Element("UserName").Value.Equals(textBox_USERNAME.Text) && c.Element("Password").Value.Equals(textBox_PASSWORD.Text)).First();
                    MAIN main = new MAIN();
                    this.Hide();
                    main.Show();
                }
                catch
                {
                    MessageBox.Show(" Invalid Username or Password", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
