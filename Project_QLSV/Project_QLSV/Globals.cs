using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QLSV
{
    class Globals
    {
        static string globalUserID;

        public static string GlobalUserID { get => globalUserID; set => globalUserID = value; }

        public static void SetGlobalUserId(string User_Id)
        {
            GlobalUserID = User_Id;
        }
    }
}
