using System;
using System.Data;

namespace ClassLibrary
{
    public class clsUser
    {
        // Private fields (to hold data from DB)
        private Int32 mUserId;
        private string mFullName;
        private string mEmail;
        private string mPasswordHash;
        private string mAddress;
        private string mPhone;
        private bool mIsActive;
        private DateTime mCreatedAt;

        // Public properties
        public int UserId { get { return mUserId; } set { mUserId = value; } }
        public string FullName { get { return mFullName; } set { mFullName = value; } }
        public string Email { get { return mEmail; } set { mEmail = value; } }
        public string PasswordHash { get { return mPasswordHash; } set { mPasswordHash = value; } }
        public string Address { get { return mAddress; } set { mAddress = value; } }
        public string Phone { get { return mPhone; } set { mPhone = value; } }
        public bool IsActive { get { return mIsActive; } set { mIsActive = value; } }
        public DateTime CreatedAt { get { return mCreatedAt; } set { mCreatedAt = value; } }

        // Find a record by primary key
        public bool Find(int userId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserId", userId);
            DB.Execute("sproc_tblUser_FilterByUserId");
            if (DB.Count == 1)
            {
                mUserId = Convert.ToInt32(DB.DataTable.Rows[0]["UserId"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPasswordHash = Convert.ToString(DB.DataTable.Rows[0]["PasswordHash"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPhone = Convert.ToString(DB.DataTable.Rows[0]["Phone"]);
                mIsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["IsActive"]);
                mCreatedAt = Convert.ToDateTime(DB.DataTable.Rows[0]["CreatedAt"]);
                return true;
            }
            else return false;
        }

        // Add a new record (returns -1 if fails, else new UserId)
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FullName", mFullName);
            DB.AddParameter("@Email", mEmail);
            DB.AddParameter("@PasswordHash", mPasswordHash);
            DB.AddParameter("@Address", mAddress);
            DB.AddParameter("@Phone", mPhone);
            DB.AddParameter("@IsActive", mIsActive);
            return DB.Execute("sproc_tblUser_Insert");
        }

        // Update existing record
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserId", mUserId);
            DB.AddParameter("@FullName", mFullName);
            DB.AddParameter("@Email", mEmail);
            DB.AddParameter("@PasswordHash", mPasswordHash);
            DB.AddParameter("@Address", mAddress);
            DB.AddParameter("@Phone", mPhone);
            DB.AddParameter("@IsActive", mIsActive);
            DB.Execute("sproc_tblUser_Update");
        }

        // Delete a record by primary key
        public void Delete(int userId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserId", userId);
            DB.Execute("sproc_tblUser_Delete");
        }

        // Validation (FullName only – you can add Email later)
        public string Valid(string fullName, string email, string passwordHash, string address, string phone)
        {
            string Error = "";
            if (fullName.Length == 0)
                Error += "FullName may not be blank. ";
            else if (fullName.Length < 3)
                Error += "FullName must be at least 3 characters. ";
            else if (fullName.Length > 50)
                Error += "FullName cannot exceed 50 characters. ";
            // Email, password, etc. can be added similarly
            return Error;
        }
    }
}