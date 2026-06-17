using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing
{
    [TestClass]
    public class tstOrder
    {
        string CustomerName = "Yousuf Test Customer";
        string WatchId = "1";
        string Quantity = "2";
        string OrderDate = DateTime.Now.Date.ToString();
        string TotalAmount = "5000.00";
        string OrderStatus = "Pending";

        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 1;
            AnOrder.OrderId = TestData;
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }

        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "Yousuf Test Customer";
            AnOrder.CustomerName = TestData;
            Assert.AreEqual(AnOrder.CustomerName, TestData);
        }

        [TestMethod]
        public void WatchIdPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 1;
            AnOrder.WatchId = TestData;
            Assert.AreEqual(AnOrder.WatchId, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 2;
            AnOrder.Quantity = TestData;
            Assert.AreEqual(AnOrder.Quantity, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.OrderDate = TestData;
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void TotalAmountPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            decimal TestData = 5000.00m;
            AnOrder.TotalAmount = TestData;
            Assert.AreEqual(AnOrder.TotalAmount, TestData);
        }

        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "Pending";
            AnOrder.OrderStatus = TestData;
            Assert.AreEqual(AnOrder.OrderStatus, TestData);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            bool TestData = true;
            AnOrder.Active = TestData;
            Assert.AreEqual(AnOrder.Active, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            bool Found = false;
            int OrderId = 1;
            Found = AnOrder.Find(OrderId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderFound()
        {
            clsOrder AnOrder = new clsOrder();
            bool Found = false;
            bool OK = true;
            int OrderId = 1;

            Found = AnOrder.Find(OrderId);

            if (AnOrder.OrderId != 1)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            Error = AnOrder.Valid(CustomerName, WatchId, Quantity, OrderDate, TotalAmount, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string CustomerName = "";
            Error = AnOrder.Valid(CustomerName, WatchId, Quantity, OrderDate, TotalAmount, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(101, 'a');
            Error = AnOrder.Valid(CustomerName, WatchId, Quantity, OrderDate, TotalAmount, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void WatchIdInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string WatchId = "abc";
            Error = AnOrder.Valid(CustomerName, WatchId, Quantity, OrderDate, TotalAmount, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string Quantity = "abc";
            Error = AnOrder.Valid(CustomerName, WatchId, Quantity, OrderDate, TotalAmount, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremePast()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string OrderDate = DateTime.Now.Date.AddYears(-10).ToString();
            Error = AnOrder.Valid(CustomerName, WatchId, Quantity, OrderDate, TotalAmount, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string TotalAmount = "abc";
            Error = AnOrder.Valid(CustomerName, WatchId, Quantity, OrderDate, TotalAmount, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string OrderStatus = "";
            Error = AnOrder.Valid(CustomerName, WatchId, Quantity, OrderDate, TotalAmount, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
public void CustomerNameMinBoundary()
{
    clsOrder AnOrder = new clsOrder();
    string Error = "";
    string CustomerName = "a";
    Error = AnOrder.Valid(CustomerName, WatchId, Quantity, OrderDate, TotalAmount, OrderStatus);
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void CustomerNameMaxBoundary()
{
    clsOrder AnOrder = new clsOrder();
    string Error = "";
    string CustomerName = "";
    CustomerName = CustomerName.PadRight(100, 'a');
    Error = AnOrder.Valid(CustomerName, WatchId, Quantity, OrderDate, TotalAmount, OrderStatus);
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void WatchIdZero()
{
    clsOrder AnOrder = new clsOrder();
    string Error = "";
    string WatchId = "0";
    Error = AnOrder.Valid(CustomerName, WatchId, Quantity, OrderDate, TotalAmount, OrderStatus);
    Assert.AreNotEqual(Error, "");
}

[TestMethod]
public void QuantityZero()
{
    clsOrder AnOrder = new clsOrder();
    string Error = "";
    string Quantity = "0";
    Error = AnOrder.Valid(CustomerName, WatchId, Quantity, OrderDate, TotalAmount, OrderStatus);
    Assert.AreNotEqual(Error, "");
}

[TestMethod]
public void QuantityMaxBoundary()
{
    clsOrder AnOrder = new clsOrder();
    string Error = "";
    string Quantity = "100";
    Error = AnOrder.Valid(CustomerName, WatchId, Quantity, OrderDate, TotalAmount, OrderStatus);
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void QuantityMaxPlusOne()
{
    clsOrder AnOrder = new clsOrder();
    string Error = "";
    string Quantity = "101";
    Error = AnOrder.Valid(CustomerName, WatchId, Quantity, OrderDate, TotalAmount, OrderStatus);
    Assert.AreNotEqual(Error, "");
}

[TestMethod]
public void OrderDateToday()
{
    clsOrder AnOrder = new clsOrder();
    string Error = "";
    string OrderDate = DateTime.Now.Date.ToString();
    Error = AnOrder.Valid(CustomerName, WatchId, Quantity, OrderDate, TotalAmount, OrderStatus);
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void OrderDateFutureBoundary()
{
    clsOrder AnOrder = new clsOrder();
    string Error = "";
    string OrderDate = DateTime.Now.Date.AddYears(1).ToString();
    Error = AnOrder.Valid(CustomerName, WatchId, Quantity, OrderDate, TotalAmount, OrderStatus);
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void OrderDateFuturePlusOne()
{
    clsOrder AnOrder = new clsOrder();
    string Error = "";
    string OrderDate = DateTime.Now.Date.AddYears(1).AddDays(1).ToString();
    Error = AnOrder.Valid(CustomerName, WatchId, Quantity, OrderDate, TotalAmount, OrderStatus);
    Assert.AreNotEqual(Error, "");
}

[TestMethod]
public void TotalAmountZero()
{
    clsOrder AnOrder = new clsOrder();
    string Error = "";
    string TotalAmount = "0";
    Error = AnOrder.Valid(CustomerName, WatchId, Quantity, OrderDate, TotalAmount, OrderStatus);
    Assert.AreNotEqual(Error, "");
}

[TestMethod]
public void TotalAmountMaxBoundary()
{
    clsOrder AnOrder = new clsOrder();
    string Error = "";
    string TotalAmount = "1000000";
    Error = AnOrder.Valid(CustomerName, WatchId, Quantity, OrderDate, TotalAmount, OrderStatus);
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void TotalAmountMaxPlusOne()
{
    clsOrder AnOrder = new clsOrder();
    string Error = "";
    string TotalAmount = "1000001";
    Error = AnOrder.Valid(CustomerName, WatchId, Quantity, OrderDate, TotalAmount, OrderStatus);
    Assert.AreNotEqual(Error, "");
}

[TestMethod]
public void OrderStatusValidProcessing()
{
    clsOrder AnOrder = new clsOrder();
    string Error = "";
    string OrderStatus = "Processing";
    Error = AnOrder.Valid(CustomerName, WatchId, Quantity, OrderDate, TotalAmount, OrderStatus);
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void OrderStatusValidCompleted()
{
    clsOrder AnOrder = new clsOrder();
    string Error = "";
    string OrderStatus = "Completed";
    Error = AnOrder.Valid(CustomerName, WatchId, Quantity, OrderDate, TotalAmount, OrderStatus);
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void OrderStatusInvalidValue()
{
    clsOrder AnOrder = new clsOrder();
    string Error = "";
    string OrderStatus = "WrongStatus";
    Error = AnOrder.Valid(CustomerName, WatchId, Quantity, OrderDate, TotalAmount, OrderStatus);
    Assert.AreNotEqual(Error, "");
}
    }
}