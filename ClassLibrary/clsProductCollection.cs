using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsProductCollection
    {
        List<clsProduct> mProductList = new List<clsProduct>();

        clsProduct mThisProduct = new clsProduct();

        public clsProductCollection()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblProducts_SelectAll");

            PopulateArray(DB);
        }

        
        public List<clsProduct> ProductList
        {
            get
            {
                return mProductList;
            }
            set
            {
                mProductList = value;
            }
        }

        public int Count
        {
            get
            {
                return mProductList.Count;
            }
            set
            {

            }
        }

        public clsProduct ThisProduct
        {
            get
            {
                return mThisProduct;
            }
            set
            {
                mThisProduct = value;
            }
        }

            public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Brand", mThisProduct.Brand);
            DB.AddParameter("@Model", mThisProduct.Model);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@StockQuantity", mThisProduct.StockQuantity);
            DB.AddParameter("@Category", mThisProduct.Category);
            DB.AddParameter("@Description", mThisProduct.Description);
            DB.AddParameter("@Active", mThisProduct.Active);
            DB.AddParameter("@ImagePath", mThisProduct.ImagePath);

            return DB.Execute("sproc_tblProducts_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@WatchId", mThisProduct.WatchId);
            DB.AddParameter("@Brand", mThisProduct.Brand);
            DB.AddParameter("@Model", mThisProduct.Model);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@StockQuantity", mThisProduct.StockQuantity);
            DB.AddParameter("@Category", mThisProduct.Category);
            DB.AddParameter("@Description", mThisProduct.Description);
            DB.AddParameter("@Active", mThisProduct.Active);
            DB.AddParameter("@ImagePath", mThisProduct.ImagePath);
            DB.Execute("sproc_tblProducts_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@WatchId", mThisProduct.WatchId);

            DB.Execute("sproc_tblProducts_Delete");
        }

        public void ReportByBrand(string Brand)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Brand", Brand);

            DB.Execute("sproc_tblProducts_FilterByBrand");

            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = DB.Count;

            mProductList = new List<clsProduct>();

            while (Index < RecordCount)
            {
                clsProduct AProduct = new clsProduct();

                AProduct.WatchId = Convert.ToInt32(DB.DataTable.Rows[Index]["WatchId"]);
                AProduct.Brand = Convert.ToString(DB.DataTable.Rows[Index]["Brand"]);
                AProduct.Model = Convert.ToString(DB.DataTable.Rows[Index]["Model"]);
                AProduct.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                AProduct.StockQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["StockQuantity"]);
                AProduct.Category = Convert.ToString(DB.DataTable.Rows[Index]["Category"]);
                AProduct.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                AProduct.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AProduct.ImagePath = Convert.ToString(DB.DataTable.Rows[Index]["ImagePath"]);

                mProductList.Add(AProduct);

                Index++;
            }
        }

    }
    }
