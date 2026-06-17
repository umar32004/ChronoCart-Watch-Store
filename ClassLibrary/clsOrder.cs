using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        // Private data members
        private Int32 mOrderId;
        private string mCustomerName;
        private Int32 mWatchId;
        private Int32 mQuantity;
        private DateTime mOrderDate;
        private decimal mTotalAmount;
        private string mOrderStatus;
        private Boolean mActive;

        // Public properties
        public int OrderId
        {
            get { return mOrderId; }
            set { mOrderId = value; }
        }

        public string CustomerName
        {
            get { return mCustomerName; }
            set { mCustomerName = value; }
        }

        public int WatchId
        {
            get { return mWatchId; }
            set { mWatchId = value; }
        }

        public int Quantity
        {
            get { return mQuantity; }
            set { mQuantity = value; }
        }

        public DateTime OrderDate
        {
            get { return mOrderDate; }
            set { mOrderDate = value; }
        }

        public decimal TotalAmount
        {
            get { return mTotalAmount; }
            set { mTotalAmount = value; }
        }

        public string OrderStatus
        {
            get { return mOrderStatus; }
            set { mOrderStatus = value; }
        }

        public bool Active
        {
            get { return mActive; }
            set { mActive = value; }
        }

        public bool Find(int OrderId)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@OrderId", OrderId);

            DB.Execute("sproc_tblOrders_FilterByOrderId");

            if (DB.Count == 1)
            {
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mWatchId = Convert.ToInt32(DB.DataTable.Rows[0]["WatchId"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mTotalAmount = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalAmount"]);
                mOrderStatus = Convert.ToString(DB.DataTable.Rows[0]["OrderStatus"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string CustomerName,
                    string WatchId,
                    string Quantity,
                    string OrderDate,
                    string TotalAmount,
                    string OrderStatus)
        {
            string Error = "";
            DateTime DateTemp;
            decimal AmountTemp;
            int IntTemp;

            if (CustomerName.Length == 0)
            {
                Error += "Customer name may not be blank : ";
            }

            if (CustomerName.Length > 100)
            {
                Error += "Customer name must be 100 characters or less : ";
            }

            try
            {
                IntTemp = Convert.ToInt32(WatchId);

                if (IntTemp < 1)
                {
                    Error += "Watch ID must be greater than 0 : ";
                }
            }
            catch
            {
                Error += "Watch ID must be a valid number : ";
            }

            try
            {
                IntTemp = Convert.ToInt32(Quantity);

                if (IntTemp < 1)
                {
                    Error += "Quantity must be greater than 0 : ";
                }

                if (IntTemp > 100)
                {
                    Error += "Quantity cannot be more than 100 : ";
                }
            }
            catch
            {
                Error += "Quantity must be a valid number : ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(OrderDate);

                if (DateTemp < DateTime.Now.Date)
                {
                    Error += "Order date cannot be in the past : ";
                }

                if (DateTemp > DateTime.Now.Date.AddYears(1))
                {
                    Error += "Order date cannot be more than one year in the future : ";
                }
            }
            catch
            {
                Error += "Order date must be valid : ";
            }

            try
            {
                AmountTemp = Convert.ToDecimal(TotalAmount);

                if (AmountTemp <= 0)
                {
                    Error += "Total amount must be greater than 0 : ";
                }

                if (AmountTemp > 1000000)
                {
                    Error += "Total amount cannot be more than 1000000 : ";
                }
            }
            catch
            {
                Error += "Total amount must be valid : ";
            }

            if (OrderStatus.Length == 0)
            {
                Error += "Order status may not be blank : ";
            }

            if (OrderStatus.Length > 50)
            {
                Error += "Order status must be 50 characters or less : ";
            }

            if (OrderStatus != "Pending" &&
                OrderStatus != "Processing" &&
                OrderStatus != "Completed" &&
                OrderStatus != "Cancelled")
            {
                Error += "Order status must be Pending, Processing, Completed, or Cancelled : ";
            }

            return Error;
        }
    }
}