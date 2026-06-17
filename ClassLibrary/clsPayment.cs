using System;

namespace ClassLibrary
{
    public class clsPayment
    {
        private Int32 mPaymentID;
        private Int32 mOrderID;
        private decimal mAmount;
        private string mPaymentMethod;
        private DateTime mPaymentDate;
        private string mPaymentStatus;

        public int PaymentID
        {
            get { return mPaymentID; }
            set { mPaymentID = value; }
        }

        public int OrderID
        {
            get { return mOrderID; }
            set { mOrderID = value; }
        }

        public decimal Amount
        {
            get { return mAmount; }
            set { mAmount = value; }
        }

        public string PaymentMethod
        {
            get { return mPaymentMethod; }
            set { mPaymentMethod = value; }
        }

        public DateTime PaymentDate
        {
            get { return mPaymentDate; }
            set { mPaymentDate = value; }
        }

        public string PaymentStatus
        {
            get { return mPaymentStatus; }
            set { mPaymentStatus = value; }
        }

        public bool Find(int PaymentID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PaymentID", PaymentID);
            DB.Execute("sproc_tblPayment_FilterByPaymentID");

            if (DB.Count == 1)
            {
                mPaymentID = Convert.ToInt32(DB.DataTable.Rows[0]["PaymentID"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mAmount = Convert.ToDecimal(DB.DataTable.Rows[0]["Amount"]);
                mPaymentMethod = Convert.ToString(DB.DataTable.Rows[0]["PaymentMethod"]);
                mPaymentDate = Convert.ToDateTime(DB.DataTable.Rows[0]["PaymentDate"]);
                mPaymentStatus = Convert.ToString(DB.DataTable.Rows[0]["PaymentStatus"]);
                return true;
            }
            else
            {
                return false;
            }
        }
            public string Valid(string orderID, string amount, string paymentMethod, string paymentDate, string paymentStatus)
        {
            string Error = "";
            DateTime DateTemp;
            decimal AmountTemp;
            int OrderIDTemp;

            if (orderID.Length == 0)
            {
                Error = Error + "Order ID may not be blank. ";
            }

            if (int.TryParse(orderID, out OrderIDTemp) == false)
            {
                Error = Error + "Order ID must be a number. ";
            }

            if (amount.Length == 0)
            {
                Error = Error + "Amount may not be blank. ";
            }

            if (decimal.TryParse(amount, out AmountTemp) == false)
            {
                Error = Error + "Amount must be a valid number. ";
            }
            else
            {
                if (AmountTemp <= 0)
                {
                    Error = Error + "Amount must be greater than 0. ";
                }
            }

            if (paymentMethod.Length == 0)
            {
                Error = Error + "Payment method may not be blank. ";
            }

            if (paymentMethod.Length > 50)
            {
                Error = Error + "Payment method must be less than 50 characters. ";
            }

            if (paymentStatus.Length == 0)
            {
                Error = Error + "Payment status may not be blank. ";
            }

            if (paymentStatus.Length > 50)
            {
                Error = Error + "Payment status must be less than 50 characters. ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(paymentDate);
            }
            catch
            {
                Error = Error + "Payment date must be a valid date. ";
            }

            return Error;
        }

    }
    }
