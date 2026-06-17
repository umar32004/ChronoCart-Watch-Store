using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsPaymentCollection
    {
        List<clsPayment> mPaymentList = new List<clsPayment>();
        clsPayment mThisPayment = new clsPayment();

        public clsPaymentCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblPayment_SelectAll");
            PopulateArray(DB);
        }

        public List<clsPayment> PaymentList
        {
            get { return mPaymentList; }
            set { mPaymentList = value; }
        }

        public int Count
        {
            get { return mPaymentList.Count; }
        }

        public clsPayment ThisPayment
        {
            get { return mThisPayment; }
            set { mThisPayment = value; }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@OrderID", mThisPayment.OrderID);
            DB.AddParameter("@Amount", mThisPayment.Amount);
            DB.AddParameter("@PaymentMethod", mThisPayment.PaymentMethod);
            DB.AddParameter("@PaymentDate", mThisPayment.PaymentDate);
            DB.AddParameter("@PaymentStatus", mThisPayment.PaymentStatus);

            return DB.Execute("sproc_tblPayment_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@PaymentID", mThisPayment.PaymentID);
            DB.AddParameter("@OrderID", mThisPayment.OrderID);
            DB.AddParameter("@Amount", mThisPayment.Amount);
            DB.AddParameter("@PaymentMethod", mThisPayment.PaymentMethod);
            DB.AddParameter("@PaymentDate", mThisPayment.PaymentDate);
            DB.AddParameter("@PaymentStatus", mThisPayment.PaymentStatus);

            DB.Execute("sproc_tblPayment_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PaymentID", mThisPayment.PaymentID);
            DB.Execute("sproc_tblPayment_Delete");
        }

        void PopulateArray(clsDataConnection DB)
        {
            int Index = 0;
            int RecordCount = DB.Count;

            mPaymentList = new List<clsPayment>();

            while (Index < RecordCount)
            {
                clsPayment APayment = new clsPayment();

                APayment.PaymentID = Convert.ToInt32(DB.DataTable.Rows[Index]["PaymentID"]);
                APayment.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                APayment.Amount = Convert.ToDecimal(DB.DataTable.Rows[Index]["Amount"]);
                APayment.PaymentMethod = Convert.ToString(DB.DataTable.Rows[Index]["PaymentMethod"]);
                APayment.PaymentDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["PaymentDate"]);
                APayment.PaymentStatus = Convert.ToString(DB.DataTable.Rows[Index]["PaymentStatus"]);

                mPaymentList.Add(APayment);

                Index++;
            }
        }
    }
}