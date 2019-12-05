using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_QLSV
{
    class Contacts
    {
        public void add_contact(string group, string phone, string email, string groupID, string address)
        {
            XDocument contactData = XDocument.Load(AddressesString.students_contact);

            //XElement findContact = contactData.Descendants("Contact").Where(c => c.Element("UserID").Value.Equals(Globals.GlobalUserID)).First();
            XElement newContact = new XElement("Contact", new XElement("UserID", Globals.GlobalUserID), new XElement("Group", group), new XElement("Email", email), new XElement("Phone", phone), new XElement("GroupID", groupID), new XElement("Address", address));
            contactData.Element("Items").Add(newContact);
            contactData.Save(AddressesString.students_contact);
        }
        
        public bool edit_contact(string group, string phone, string email, string groupID, string address)
        {
            bool k = true;
            XDocument contactData = XDocument.Load(AddressesString.students_contact);
            try
            {
                XElement findContact = contactData.Descendants("Contact").Where(c => c.Element("UserID").Value.Equals(Globals.GlobalUserID)).First();
                findContact.Element("Group").Value = group;
                findContact.Element("Email").Value = email;
                findContact.Element("Phone").Value = phone;
                findContact.Element("GroupID").Value = groupID;
                findContact.Element("Address").Value = address;
                contactData.Save(AddressesString.students_contact);
            }
            catch
            {
                k = false;
            }
            return k;
        }
    }
}
