using System;

namespace ClassLibrary
{
    public class clsProduct
    {
        private Int32 mWatchId;
        public Int32 WatchId
        {
            get { return mWatchId; }
            set { mWatchId = value; }
        }

        private string mBrand;
        public string Brand
        {
            get { return mBrand; }
            set { mBrand = value; }
        }

        private string mModel;
        public string Model
        {
            get { return mModel; }
            set { mModel = value; }
        }

        private decimal mPrice;
        public decimal Price
        {
            get { return mPrice; }
            set { mPrice = value; }
        }

        private Int32 mStockQuantity;
        public Int32 StockQuantity
        {
            get { return mStockQuantity; }
            set { mStockQuantity = value; }
        }

        private string mCategory;
        public string Category
        {
            get { return mCategory; }
            set { mCategory = value; }
        }

        private string mDescription;
        public string Description
        {
            get { return mDescription; }
            set { mDescription = value; }
        }

        private Boolean mActive;
        public Boolean Active
        {
            get { return mActive; }
            set { mActive = value; }
        }

        public bool Find(Int32 WatchId)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@WatchId", WatchId);

            DB.Execute("sproc_tblProducts_FilterByWatchId");

            if (DB.Count == 1)
            {
                mWatchId = Convert.ToInt32(DB.DataTable.Rows[0]["WatchId"]);
                mBrand = Convert.ToString(DB.DataTable.Rows[0]["Brand"]);
                mModel = Convert.ToString(DB.DataTable.Rows[0]["Model"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mStockQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["StockQuantity"]);
                mCategory = Convert.ToString(DB.DataTable.Rows[0]["Category"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mImagePath = Convert.ToString(DB.DataTable.Rows[0]["ImagePath"]);

                return true;
            }
            else
            {
                return false;
            }
        }
    
    public string Valid(string brand, string model, string price, string stockQuantity, string category, string description)
        {
            String Error = "";

            if (brand.Length == 0)
            {
                Error = Error + "The brand may not be blank : ";
            }

            if (brand.Length > 100)
            {
                Error = Error + "The brand must be less than 100 characters : ";
            }

            if (model.Length == 0)
            {
                Error = Error + "The model may not be blank : ";
            }

            if (model.Length > 100)
            {
                Error = Error + "The model must be less than 100 characters : ";
            }

            try
            {
                decimal PriceTemp = Convert.ToDecimal(price);

                if (PriceTemp <= 0)
                {
                    Error = Error + "The price must be greater than zero : ";
                }
            }
            catch
            {
                Error = Error + "The price was not a valid number : ";
            }

            try
            {
                Int32 StockTemp = Convert.ToInt32(stockQuantity);

                if (StockTemp < 0)
                {
                    Error = Error + "The stock quantity cannot be negative : ";
                }
            }
            catch
            {
                Error = Error + "The stock quantity was not a valid number : ";
            }

            if (category.Length == 0)
            {
                Error = Error + "The category may not be blank : ";
            }

            if (category.Length > 50)
            {
                Error = Error + "The category must be less than 50 characters : ";
            }

            if (description.Length == 0)
            {
                Error = Error + "The description may not be blank : ";
            }

            if (description.Length > 255)
            {
                Error = Error + "The description must be less than 255 characters : ";
            }

            return Error;
        }

        private string mImagePath;

        public string ImagePath
        {
            get { return mImagePath; }
            set { mImagePath = value; }
        }

    } }