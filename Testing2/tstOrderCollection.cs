using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();

            clsOrder TestItem = new clsOrder();

            TestItem.OrderId = 1;
            TestItem.CustomerName = "Yousuf Test Customer";
            TestItem.WatchId = 1;
            TestItem.Quantity = 2;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalAmount = 5000.00m;
            TestItem.OrderStatus = "Pending";
            TestItem.Active = true;

            TestList.Add(TestItem);

            AllOrders.OrderList = TestList;

            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();

            TestOrder.OrderId = 1;
            TestOrder.CustomerName = "Yousuf Test Customer";
            TestOrder.WatchId = 1;
            TestOrder.Quantity = 2;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.TotalAmount = 5000.00m;
            TestOrder.OrderStatus = "Pending";
            TestOrder.Active = true;

            AllOrders.ThisOrder = TestOrder;

            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();

            clsOrder TestItem = new clsOrder();

            TestItem.OrderId = 1;
            TestItem.CustomerName = "Yousuf Test Customer";
            TestItem.WatchId = 1;
            TestItem.Quantity = 2;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalAmount = 5000.00m;
            TestItem.OrderStatus = "Pending";
            TestItem.Active = true;

            TestList.Add(TestItem);

            AllOrders.OrderList = TestList;

            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();

            int PrimaryKey = 0;

            TestItem.CustomerName = "Add Test Customer";
            TestItem.WatchId = 1;
            TestItem.Quantity = 3;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalAmount = 7500.00m;
            TestItem.OrderStatus = "Pending";
            TestItem.Active = true;

            AllOrders.ThisOrder = TestItem;

            PrimaryKey = AllOrders.Add();

            TestItem.OrderId = PrimaryKey;

            AllOrders.ThisOrder.Find(PrimaryKey);

            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();

            int PrimaryKey = 0;

            TestItem.CustomerName = "Update Test Customer";
            TestItem.WatchId = 1;
            TestItem.Quantity = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalAmount = 2500.00m;
            TestItem.OrderStatus = "Pending";
            TestItem.Active = true;

            AllOrders.ThisOrder = TestItem;

            PrimaryKey = AllOrders.Add();

            TestItem.OrderId = PrimaryKey;

            TestItem.CustomerName = "Updated Customer";
            TestItem.WatchId = 2;
            TestItem.Quantity = 4;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalAmount = 10000.00m;
            TestItem.OrderStatus = "Completed";
            TestItem.Active = false;

            AllOrders.ThisOrder = TestItem;

            AllOrders.Update();

            AllOrders.ThisOrder.Find(PrimaryKey);

            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();

            int PrimaryKey = 0;

            TestItem.CustomerName = "Delete Test Customer";
            TestItem.WatchId = 1;
            TestItem.Quantity = 2;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalAmount = 5000.00m;
            TestItem.OrderStatus = "Cancelled";
            TestItem.Active = true;

            AllOrders.ThisOrder = TestItem;

            PrimaryKey = AllOrders.Add();

            TestItem.OrderId = PrimaryKey;

            AllOrders.ThisOrder.Find(PrimaryKey);

            AllOrders.Delete();

            bool Found = AllOrders.ThisOrder.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByCustomerNameMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();

            FilteredOrders.ReportByCustomerName("");

            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByCustomerNameNoneFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();

            FilteredOrders.ReportByCustomerName("xxxxxxxxxxxx");

            Assert.AreEqual(0, FilteredOrders.Count);
        }
    }
}