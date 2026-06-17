using System;
using System.Collections.Generic;
using System.Data;

namespace ClassLibrary
{
    public class clsUserCollection
    {
        private List<clsUser> mUserList = new List<clsUser>();

        public List<clsUser> UserList { get { return mUserList; } }
        public int Count { get { return mUserList.Count; } }

        // Constructor loads all users
        public clsUserCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblUser_SelectAll");
            for (int i = 0; i < DB.Count; i++)
            {
                clsUser user = new clsUser();
                user.UserId = Convert.ToInt32(DB.DataTable.Rows[i]["UserId"]);
                user.FullName = Convert.ToString(DB.DataTable.Rows[i]["FullName"]);
                user.Email = Convert.ToString(DB.DataTable.Rows[i]["Email"]);
                user.PasswordHash = Convert.ToString(DB.DataTable.Rows[i]["PasswordHash"]);
                user.Address = Convert.ToString(DB.DataTable.Rows[i]["Address"]);
                user.Phone = Convert.ToString(DB.DataTable.Rows[i]["Phone"]);
                user.IsActive = Convert.ToBoolean(DB.DataTable.Rows[i]["IsActive"]);
                user.CreatedAt = Convert.ToDateTime(DB.DataTable.Rows[i]["CreatedAt"]);
                mUserList.Add(user);
            }
        }

        // Filter by FullName
        public void FilterByFullName(string fullName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FullName", fullName);
            DB.Execute("sproc_tblUser_FilterByFullName");
            mUserList.Clear();
            for (int i = 0; i < DB.Count; i++)
            {
                clsUser user = new clsUser();
                user.UserId = Convert.ToInt32(DB.DataTable.Rows[i]["UserId"]);
                user.FullName = Convert.ToString(DB.DataTable.Rows[i]["FullName"]);
                user.Email = Convert.ToString(DB.DataTable.Rows[i]["Email"]);
                user.PasswordHash = Convert.ToString(DB.DataTable.Rows[i]["PasswordHash"]);
                user.Address = Convert.ToString(DB.DataTable.Rows[i]["Address"]);
                user.Phone = Convert.ToString(DB.DataTable.Rows[i]["Phone"]);
                user.IsActive = Convert.ToBoolean(DB.DataTable.Rows[i]["IsActive"]);
                user.CreatedAt = Convert.ToDateTime(DB.DataTable.Rows[i]["CreatedAt"]);
                mUserList.Add(user);
            }
        }
    }
}