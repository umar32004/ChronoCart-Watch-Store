using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;

namespace Testing1
{
    [TestClass]
    public class tstProduct
    {
        string Brand = "Rolex";
        string Model = "Submariner";
        string Price = "2999.99";
        string StockQuantity = "10";
        string Category = "Luxury";
        string Description = "Luxury automatic watch";

        Int32 TestWatchId = 999;
        string TestBrand = "Casio(TEST DON'T DELETE)";
        string TestModel = "G-Shock";
        decimal TestPrice = 120.50m;
        Int32 TestStockQuantity = 15;
        string TestCategory = "Sport";
        string TestDescription = "Durable digital sports watch";
        Boolean TestActive = true;

        [TestMethod]
        public void InstanceOK()
        {
            clsProduct AProduct = new clsProduct();
            Assert.IsNotNull(AProduct);
        }

        [TestMethod]
        public void WatchIdPropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            Int32 TestData = 1;
            AProduct.WatchId = TestData;
            Assert.AreEqual(AProduct.WatchId, TestData);
        }

        [TestMethod]
        public void BrandPropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            string TestData = "Casio";
            AProduct.Brand = TestData;
            Assert.AreEqual(AProduct.Brand, TestData);
        }

        [TestMethod]
        public void ModelPropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            string TestData = "G-Shock";
            AProduct.Model = TestData;
            Assert.AreEqual(AProduct.Model, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            decimal TestData = 120.50m;
            AProduct.Price = TestData;
            Assert.AreEqual(AProduct.Price, TestData);
        }

        [TestMethod]
        public void StockQuantityPropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            Int32 TestData = 15;
            AProduct.StockQuantity = TestData;
            Assert.AreEqual(AProduct.StockQuantity, TestData);
        }

        [TestMethod]
        public void CategoryPropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            string TestData = "Sport";
            AProduct.Category = TestData;
            Assert.AreEqual(AProduct.Category, TestData);
        }

        [TestMethod]
        public void DescriptionPropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            string TestData = "Durable digital sports watch";
            AProduct.Description = TestData;
            Assert.AreEqual(AProduct.Description, TestData);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            Boolean TestData = true;
            AProduct.Active = TestData;
            Assert.AreEqual(AProduct.Active, TestData);
        }

        /****************** FIND METHOD TEST ******************/

        [TestMethod]
        public void FindMethodOK()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Int32 WatchId = 999;

            Found = AProduct.Find(TestWatchId); ;

            Assert.IsTrue(Found);
        }

        /****************** PROPERTY DATA TESTS ******************/

        [TestMethod]
        public void TestWatchIdFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 WatchId = 999;

            Found = AProduct.Find(TestWatchId); ;

            if (AProduct.WatchId != TestWatchId)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBrandFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 WatchId = 999;

            Found = AProduct.Find(TestWatchId); ;

            if (AProduct.Brand != TestBrand)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestModelFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 WatchId = 999;

            Found = AProduct.Find(TestWatchId); ;

            if (AProduct.Model != TestModel)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 WatchId = 999;

            Found = AProduct.Find(TestWatchId); ;

            if (AProduct.Price != TestPrice)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockQuantityFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 WatchId = 999;

            Found = AProduct.Find(TestWatchId); ;

            if (AProduct.StockQuantity != TestStockQuantity)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCategoryFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 WatchId = 999;

            Found = AProduct.Find(TestWatchId); ;

            if (AProduct.Category != TestCategory)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDescriptionFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 WatchId = 999;

            Found = AProduct.Find(TestWatchId); ;

            if (AProduct.Description != TestDescription)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 WatchId = 999;

            Found = AProduct.Find(TestWatchId); ;

            if (AProduct.Active != TestActive)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        /****************** VALID METHOD TEST ******************/

        [TestMethod]
        public void ValidMethodOK()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";

            Error = AProduct.Valid(Brand, Model, Price, StockQuantity, Category, Description);

            Assert.AreEqual(Error, "");
        }

        /****************** BRAND VALIDATION TESTS ******************/

        [TestMethod]
        public void BrandMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Brand = "";

            Error = AProduct.Valid(Brand, Model, Price, StockQuantity, Category, Description);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BrandMin()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Brand = "a";

            Error = AProduct.Valid(Brand, Model, Price, StockQuantity, Category, Description);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMax()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Brand = "";
            Brand = Brand.PadRight(100, 'a');

            Error = AProduct.Valid(Brand, Model, Price, StockQuantity, Category, Description);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMaxPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Brand = "";
            Brand = Brand.PadRight(101, 'a');

            Error = AProduct.Valid(Brand, Model, Price, StockQuantity, Category, Description);

            Assert.AreNotEqual(Error, "");
        }

        /****************** MODEL VALIDATION TESTS ******************/

        [TestMethod]
        public void ModelMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Model = "";

            Error = AProduct.Valid(Brand, Model, Price, StockQuantity, Category, Description);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ModelMin()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Model = "a";

            Error = AProduct.Valid(Brand, Model, Price, StockQuantity, Category, Description);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelMax()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Model = "";
            Model = Model.PadRight(100, 'a');

            Error = AProduct.Valid(Brand, Model, Price, StockQuantity, Category, Description);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelMaxPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Model = "";
            Model = Model.PadRight(101, 'a');

            Error = AProduct.Valid(Brand, Model, Price, StockQuantity, Category, Description);

            Assert.AreNotEqual(Error, "");
        }

        /****************** PRICE VALIDATION TESTS ******************/

        [TestMethod]
        public void PriceInvalidData()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Price = "not a price";

            Error = AProduct.Valid(Brand, Model, Price, StockQuantity, Category, Description);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceZero()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Price = "0";

            Error = AProduct.Valid(Brand, Model, Price, StockQuantity, Category, Description);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceValid()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Price = "2999.99";

            Error = AProduct.Valid(Brand, Model, Price, StockQuantity, Category, Description);

            Assert.AreEqual(Error, "");
        }

        /****************** STOCK QUANTITY VALIDATION TESTS ******************/

        [TestMethod]
        public void StockQuantityInvalidData()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string StockQuantity = "abc";

            Error = AProduct.Valid(Brand, Model, Price, StockQuantity, Category, Description);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityNegative()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string StockQuantity = "-1";

            Error = AProduct.Valid(Brand, Model, Price, StockQuantity, Category, Description);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityZero()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string StockQuantity = "0";

            Error = AProduct.Valid(Brand, Model, Price, StockQuantity, Category, Description);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityValid()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string StockQuantity = "10";

            Error = AProduct.Valid(Brand, Model, Price, StockQuantity, Category, Description);

            Assert.AreEqual(Error, "");
        }

        /****************** CATEGORY VALIDATION TESTS ******************/

        [TestMethod]
        public void CategoryMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Category = "";

            Error = AProduct.Valid(Brand, Model, Price, StockQuantity, Category, Description);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMin()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Category = "a";

            Error = AProduct.Valid(Brand, Model, Price, StockQuantity, Category, Description);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMax()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Category = "";
            Category = Category.PadRight(50, 'a');

            Error = AProduct.Valid(Brand, Model, Price, StockQuantity, Category, Description);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMaxPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Category = "";
            Category = Category.PadRight(51, 'a');

            Error = AProduct.Valid(Brand, Model, Price, StockQuantity, Category, Description);

            Assert.AreNotEqual(Error, "");
        }

        /****************** DESCRIPTION VALIDATION TESTS ******************/

        [TestMethod]
        public void DescriptionMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Description = "";

            Error = AProduct.Valid(Brand, Model, Price, StockQuantity, Category, Description);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMin()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Description = "a";

            Error = AProduct.Valid(Brand, Model, Price, StockQuantity, Category, Description);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMax()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Description = "";
            Description = Description.PadRight(255, 'a');

            Error = AProduct.Valid(Brand, Model, Price, StockQuantity, Category, Description);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Description = "";
            Description = Description.PadRight(256, 'a');

            Error = AProduct.Valid(Brand, Model, Price, StockQuantity, Category, Description);

            Assert.AreNotEqual(Error, "");
        }
    }
}