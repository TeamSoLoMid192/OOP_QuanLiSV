using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Project_QLSV
{
    class Groups
    {
        List<string> listGroups = new List<string>();
        XDocument groupData = XDocument.Load(AddressesString.student_groups);

        public List<string> ListGroups { get => listGroups; set => listGroups = value; }

        public Groups()
        {
            loadToGroups();
        }
        private void loadToGroups()
        {
            foreach(XElement groupName in groupData.Descendants("Group"))
            {
                ListGroups.Add(groupName.Element("Name").Value);
            }
        }
        public void delete_a_group(string group_name)
        {
            ListGroups.Remove(group_name);
            XElement groupsElement = groupData.Descendants("Groups").First();
            XElement delGroup = groupsElement.Elements("Group").Where(c => c.Value.Equals(group_name)).First();
            delGroup.Remove();
            groupData.Save(AddressesString.student_groups);
        }
        public void add_a_group(string group_name)
        {
            ListGroups.Add(group_name);
            XElement groupsElement = groupData.Descendants("Groups").First();
            XElement addGroup = new XElement("Group", group_name);
            groupsElement.Add(addGroup);
            groupData.Save(AddressesString.student_groups);
        }
        public void edit_a_group(string group_name, string group_new_name)
        {
            ListGroups.Remove(group_name);
            XElement del = groupData.Descendants("Group").Where(c => c.Element("Name").Value.Equals(group_name)).First();
            del.Element("Name").Value = group_new_name;
            groupData.Save(AddressesString.student_groups);

            XDocument eachGR = XDocument.Load(AddressesString.students_contact);
            foreach(XElement c in eachGR.Descendants("Contact"))
            {
                if(c.Element("Group").Value == group_name)
                {
                    c.Element("Group").Value = group_new_name;
                }
            }
            eachGR.Save(AddressesString.students_contact);
        }
    }
    //public class DictionaryManager
    //{
    //    #region properties
    //    private string filePath = "data.xml";

    //    private DictionaryItem items;

    //    public DictionaryItem Items
    //    {
    //        get { return items; }
    //        set { items = value; }
    //    }
    //    #endregion

    //    #region methods
    //    public DictionaryManager()
    //    {
    //        items = (DictionaryItem)DeserializeFromXML(filePath);
    //    }

    //    public void LoadDataToCombobox(ComboBox combo)
    //    {
    //        combo.DataSource = items.Items;
    //    }


    //    public void Serialize()
    //    {
    //        SerializeToXML(Items, filePath);
    //    }

    //    private void SerializeToXML(object data, string filePath)
    //    {
    //        FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

    //        XmlSerializer sr = new XmlSerializer(typeof(DictionaryItem));

    //        sr.Serialize(fs, data);

    //        fs.Close();
    //    }

    //    public object DeserializeFromXML(string filePath)
    //    {
    //        FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

    //        XmlSerializer sr = new XmlSerializer(typeof(DictionaryItem));

    //        object obj = sr.Deserialize(fs);

    //        fs.Close();

    //        return obj;
    //    }

    //    #endregion
    //}
    //public class DictionaryData
    //{
    //    private string key;

    //    public string Key
    //    {
    //        get { return key; }
    //        set { key = value; }
    //    }

    //    private string meaning;

    //    public string Meaning
    //    {
    //        get { return meaning; }
    //        set { meaning = value; }
    //    }

    //    private string explaination;

    //    public string Explaination
    //    {
    //        get { return explaination; }
    //        set { explaination = value; }
    //    }
    //}

    //[Serializable]
    //public class DictionaryItem
    //{
    //    private List<DictionaryData> items;

    //    public List<DictionaryData> Items
    //    {
    //        get { return items; }
    //        set { items = value; }
    //    }
}

