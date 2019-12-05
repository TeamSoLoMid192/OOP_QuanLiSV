using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project_QLSV
{
    class USER
    {
        public StudentData getUserByID(string UserID)
        {
            StudentData stdDT = new StudentData();
            XDocument data = XDocument.Load(AddressesString.students_data);
            XDocument accdata = XDocument.Load(AddressesString.user_accounts);
            XDocument contactdata = XDocument.Load(AddressesString.students_contact);

            //XDocument
            try
            {
                XElement findStudent = data.Descendants("Student").Where(c => c.Element("UserID").Value.Equals(UserID)).First();
                XElement findAccount = accdata.Descendants("Account").Where(c => c.Element("UserID").Value.Equals(UserID)).First();
                stdDT.UserID = UserID;
                stdDT.FirstName = findStudent.Element("FirstName").Value;
                stdDT.LastName = findStudent.Element("LastName").Value;
                stdDT.BirthDate = findStudent.Element("BirthDate").Value;
                stdDT.Gender = findStudent.Element("Gender").Value;
                stdDT.Picture = findStudent.Element("Picture").Value;

                stdDT.UserName = findAccount.Element("UserName").Value;
                stdDT.Password = findAccount.Element("Password").Value;

                try
                {
                    XElement findContact = contactdata.Descendants("Contact").Where(c => c.Element("UserID").Value.Equals(UserID)).First();
                    stdDT.Group = findContact.Element("Group").Value;
                    stdDT.Email = findContact.Element("Email").Value;
                    stdDT.Phone = findContact.Element("Phone").Value;
                    stdDT.GroupID = findContact.Element("GroupID").Value;
                    stdDT.Address = findContact.Element("Address").Value;
                }
                catch //(Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
            }
            catch
            {

            }

            return stdDT;
        }
        public bool updateUser(string User_ID, string User_fname, string User_lname, string User_uname, string User_pwd, string User_picture)
        {
            bool k = true;
            XDocument data = XDocument.Load(AddressesString.students_data);
            XDocument accdata = XDocument.Load(AddressesString.user_accounts);
            try
            {
                XElement findData = data.Descendants("Student").Where(c => c.Element("UserID").Value.Equals(User_ID)).First();
                XElement findAcc = accdata.Descendants("Account").Where(d => d.Element("UserID").Value.Equals(User_ID)).First();
                findData.Element("FirstName").Value = User_fname;
                findData.Element("LastName").Value = User_lname;
                findAcc.Element("UserName").Value = User_uname;
                findAcc.Element("Password").Value = User_pwd;
                accdata.Save(AddressesString.user_accounts);
                data.Save(AddressesString.students_data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                k = false;
            }
            return k;
        }
        public bool insertUser(string User_ID, string User_fname, string User_lname, string User_uname, string User_pwd, string User_picture)
        {
            bool k = true;

            XDocument data = XDocument.Load(AddressesString.students_data);
            XDocument accdata = XDocument.Load(AddressesString.user_accounts);
            try
            {
                XElement newData = new XElement("Student", new XElement("UserID", User_ID), new XElement("FirstName", User_fname), new XElement("LastName", User_lname), new XElement("BirthDate", ""), new XElement("Gender", ""), new XElement("Phone", ""), new XElement("Address", ""), new XElement("Picture", User_picture));
                XElement newAcc = new XElement("Account", new XElement("UserID", User_ID), new XElement("UserName", User_uname), new XElement("Password", User_pwd));
                
                accdata.Element("Items").Add(newAcc);
                data.Element("Items").Add(newData);
                accdata.Save(AddressesString.user_accounts);
                data.Save(AddressesString.students_data);
            }
            catch
            {
                k = false;
            }
            return k;
        }
    }
}
