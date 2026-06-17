using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace ClassLibrary
{
    public class clsPaymentUser
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public bool Login(string userName, string password)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@UserName", userName);
            DB.AddParameter("@Password", password);

            DB.Execute("sproc_tblPaymentUsers_Login");

            if (DB.Count == 1)
            {
                UserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                UserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                Password = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                Role = Convert.ToString(DB.DataTable.Rows[0]["Role"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
