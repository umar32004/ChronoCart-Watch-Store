using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing1
{
    [TestClass]
    public class tstProductCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();

            Assert.IsNotNull(AllProducts);
        }

        [TestMethod]
        public void ProductListOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();

            List<clsProduct> TestList = new List<clsProduct>();

            clsProduct TestItem = new clsProduct();

            TestItem.WatchId = 1;
            TestItem.Brand = "Rolex";
            TestItem.Model = "Submariner";
            TestItem.Price = 2500;
            TestItem.StockQuantity = 5;
            TestItem.Category = "Luxury";
            TestItem.Description = "Luxury watch";
            TestItem.Active = true;

            TestList.Add(TestItem);

            AllProducts.ProductList = TestList;

            Assert.AreEqual(AllProducts.ProductList, TestList);
        }
        
        [TestMethod]
        public void CountPropertyOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();

            Int32 SomeCount = AllProducts.ProductList.Count;

            Assert.AreEqual(AllProducts.Count, SomeCount);
        }
        [TestMethod]
        public void ThisProductPropertyOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();

            clsProduct TestProduct = new clsProduct();

            TestProduct.WatchId = 1;
            TestProduct.Brand = "Rolex";
            TestProduct.Model = "Submariner";
            TestProduct.Price = 2500;
            TestProduct.StockQuantity = 5;
            TestProduct.Category = "Luxury";
            TestProduct.Description = "Luxury watch";
            TestProduct.Active = true;

            AllProducts.ThisProduct = TestProduct;

            Assert.AreEqual(AllProducts.ThisProduct, TestProduct);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();

            clsProduct TestItem = new clsProduct();

            Int32 PrimaryKey = 0;

            TestItem.Brand = "Casio";
            TestItem.Model = "G-Shock";
            TestItem.Price = 120.50m;
            TestItem.StockQuantity = 15;
            TestItem.Category = "Sport";
            TestItem.Description = "Durable digital sports watch";
            TestItem.Active = true;
            TestItem.ImagePath = "";

            AllProducts.ThisProduct = TestItem;

            PrimaryKey = AllProducts.Add();

            TestItem.WatchId = PrimaryKey;

            AllProducts.ThisProduct.Find(PrimaryKey);

            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();
            clsProduct TestItem = new clsProduct();

            Int32 PrimaryKey = 0;

            TestItem.Brand = "Seiko";
            TestItem.Model = "Original";
            TestItem.Price = 150.00m;
            TestItem.StockQuantity = 5;
            TestItem.Category = "Classic";
            TestItem.Description = "Original watch";
            TestItem.Active = true;
            TestItem.ImagePath = "";

            AllProducts.ThisProduct = TestItem;

            PrimaryKey = AllProducts.Add();

            TestItem.WatchId = PrimaryKey;

            TestItem.Brand = "Seiko Updated";
            TestItem.Model = "Updated Model";
            TestItem.Price = 199.99m;
            TestItem.StockQuantity = 12;
            TestItem.Category = "Updated";
            TestItem.Description = "Updated watch description";
            TestItem.Active = false;

            AllProducts.ThisProduct = TestItem;

            AllProducts.Update();

            AllProducts.ThisProduct.Find(PrimaryKey);

            Assert.AreEqual(AllProducts.ThisProduct.Brand, TestItem.Brand);
            Assert.AreEqual(AllProducts.ThisProduct.Model, TestItem.Model);
            Assert.AreEqual(AllProducts.ThisProduct.Price, TestItem.Price);
            Assert.AreEqual(AllProducts.ThisProduct.StockQuantity, TestItem.StockQuantity);
            Assert.AreEqual(AllProducts.ThisProduct.Category, TestItem.Category);
            Assert.AreEqual(AllProducts.ThisProduct.Description, TestItem.Description);
            Assert.AreEqual(AllProducts.ThisProduct.Active, TestItem.Active);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();
            clsProduct TestItem = new clsProduct();

            Int32 PrimaryKey = 0;

            TestItem.Brand = "DeleteTest";
            TestItem.Model = "Temporary";
            TestItem.Price = 99.99m;
            TestItem.StockQuantity = 3;
            TestItem.Category = "Test";
            TestItem.Description = "Temporary product for delete test";
            TestItem.Active = true;
            TestItem.ImagePath = "";

            AllProducts.ThisProduct = TestItem;

            PrimaryKey = AllProducts.Add();

            TestItem.WatchId = PrimaryKey;

            AllProducts.ThisProduct.Find(PrimaryKey);

            AllProducts.Delete();

            Boolean Found = AllProducts.ThisProduct.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByBrandMethodOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();
            clsProductCollection FilteredProducts = new clsProductCollection();

            FilteredProducts.ReportByBrand("");

            Assert.AreEqual(AllProducts.Count, FilteredProducts.Count);
        }

        [TestMethod]
        public void ReportByBrandNoneFound()
        {
            clsProductCollection FilteredProducts = new clsProductCollection();

            FilteredProducts.ReportByBrand("zzzzzz");

            Assert.AreEqual(0, FilteredProducts.Count);
        }
    }
}