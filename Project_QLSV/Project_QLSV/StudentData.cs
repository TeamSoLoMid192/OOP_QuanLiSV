using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QLSV
{
    class StudentData
    {
        string userID;
        string firstName;
        string lastName;
        string birthDate;
        string gender;
        string phone;
        string address;
        string picture;
        string userName;
        string password;
        string group;
        string groupID;
        string email;

        public string UserID { get => userID; set => userID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string BirthDate { get => birthDate; set => birthDate = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Picture { get => picture; set => picture = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Group { get => group; set => group = value; }
        public string GroupID { get => groupID; set => groupID = value; }
        public string Email { get => email; set => email = value; }
    }
}
