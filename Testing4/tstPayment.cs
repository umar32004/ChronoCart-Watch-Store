using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing4
{
    [TestClass]
    public class tstPayment
    {
        string OrderID = "1";
        string Amount = "2500.00";
        string PaymentMethod = "Card";
        string PaymentDate = DateTime.Now.Date.ToString();
        string PaymentStatus = "Completed";

        [TestMethod]
        public void InstanceOK()
        {
            clsPayment APayment = new clsPayment();
            Assert.IsNotNull(APayment);
        }

        [TestMethod]
        public void PaymentIDPropertyOK()
        {
            clsPayment APayment = new clsPayment();
            int TestData = 1;
            APayment.PaymentID = TestData;
            Assert.AreEqual(APayment.PaymentID, TestData);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            clsPayment APayment = new clsPayment();
            int TestData = 1;
            APayment.OrderID = TestData;
            Assert.AreEqual(APayment.OrderID, TestData);
        }

        [TestMethod]
        public void AmountPropertyOK()
        {
            clsPayment APayment = new clsPayment();
            decimal TestData = 2500.00m;
            APayment.Amount = TestData;
            Assert.AreEqual(APayment.Amount, TestData);
        }

        [TestMethod]
        public void PaymentMethodPropertyOK()
        {
            clsPayment APayment = new clsPayment();
            string TestData = "Card";
            APayment.PaymentMethod = TestData;
            Assert.AreEqual(APayment.PaymentMethod, TestData);
        }

        [TestMethod]
        public void PaymentDatePropertyOK()
        {
            clsPayment APayment = new clsPayment();
            DateTime TestData = DateTime.Now.Date;
            APayment.PaymentDate = TestData;
            Assert.AreEqual(APayment.PaymentDate, TestData);
        }

        [TestMethod]
        public void PaymentStatusPropertyOK()
        {
            clsPayment APayment = new clsPayment();
            string TestData = "Completed";
            APayment.PaymentStatus = TestData;
            Assert.AreEqual(APayment.PaymentStatus, TestData);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsPayment APayment = new clsPayment();
            string Error = "";
            Error = APayment.Valid(OrderID, Amount, PaymentMethod, PaymentDate, PaymentStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDBlank()
        {
            clsPayment APayment = new clsPayment();
            string Error = "";
            string OrderID = "";
            Error = APayment.Valid(OrderID, Amount, PaymentMethod, PaymentDate, PaymentStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AmountBlank()
        {
            clsPayment APayment = new clsPayment();
            string Error = "";
            string Amount = "";
            Error = APayment.Valid(OrderID, Amount, PaymentMethod, PaymentDate, PaymentStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AmountLessThanZero()
        {
            clsPayment APayment = new clsPayment();
            string Error = "";
            string Amount = "-1";
            Error = APayment.Valid(OrderID, Amount, PaymentMethod, PaymentDate, PaymentStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodBlank()
        {
            clsPayment APayment = new clsPayment();
            string Error = "";
            string PaymentMethod = "";
            Error = APayment.Valid(OrderID, Amount, PaymentMethod, PaymentDate, PaymentStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentStatusBlank()
        {
            clsPayment APayment = new clsPayment();
            string Error = "";
            string PaymentStatus = "";
            Error = APayment.Valid(OrderID, Amount, PaymentMethod, PaymentDate, PaymentStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentDateInvalid()
        {
            clsPayment APayment = new clsPayment();
            string Error = "";
            string PaymentDate = "not a date";
            Error = APayment.Valid(OrderID, Amount, PaymentMethod, PaymentDate, PaymentStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsPayment APayment = new clsPayment();

            bool Found = false;

            int PaymentID = 2;

            Found = APayment.Find(PaymentID);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void AmountZero()
        {
            clsPayment APayment = new clsPayment();
            string Error = APayment.Valid(OrderID, "0", PaymentMethod, PaymentDate, PaymentStatus);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void AmountDecimalValue()
        {
            clsPayment APayment = new clsPayment();
            string Error = APayment.Valid(OrderID, "99.99", PaymentMethod, PaymentDate, PaymentStatus);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void AmountLargeValue()
        {
            clsPayment APayment = new clsPayment();
            string Error = APayment.Valid(OrderID, "999999.99", PaymentMethod, PaymentDate, PaymentStatus);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void OrderIDInvalidData()
        {
            clsPayment APayment = new clsPayment();
            string Error = APayment.Valid("ABC", Amount, PaymentMethod, PaymentDate, PaymentStatus);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void OrderIDZero()
        {
            clsPayment APayment = new clsPayment();
            string Error = APayment.Valid("0", Amount, PaymentMethod, PaymentDate, PaymentStatus);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void PaymentMethodMin()
        {
            clsPayment APayment = new clsPayment();
            string Error = APayment.Valid(OrderID, Amount, "A", PaymentDate, PaymentStatus);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void PaymentMethodMax()
        {
            clsPayment APayment = new clsPayment();
            string PaymentMethod = new string('A', 50);

            string Error = APayment.Valid(OrderID, Amount, PaymentMethod, PaymentDate, PaymentStatus);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void PaymentMethodMaxPlusOne()
        {
            clsPayment APayment = new clsPayment();
            string PaymentMethod = new string('A', 51);

            string Error = APayment.Valid(OrderID, Amount, PaymentMethod, PaymentDate, PaymentStatus);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void PaymentStatusMin()
        {
            clsPayment APayment = new clsPayment();
            string Error = APayment.Valid(OrderID, Amount, PaymentMethod, PaymentDate, "A");
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void PaymentStatusMax()
        {
            clsPayment APayment = new clsPayment();
            string PaymentStatus = new string('A', 50);

            string Error = APayment.Valid(OrderID, Amount, PaymentMethod, PaymentDate, PaymentStatus);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void PaymentStatusMaxPlusOne()
        {
            clsPayment APayment = new clsPayment();
            string PaymentStatus = new string('A', 51);

            string Error = APayment.Valid(OrderID, Amount, PaymentMethod, PaymentDate, PaymentStatus);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void PaymentDateToday()
        {
            clsPayment APayment = new clsPayment();
            string PaymentDate = DateTime.Now.Date.ToString();

            string Error = APayment.Valid(OrderID, Amount, PaymentMethod, PaymentDate, PaymentStatus);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void PaymentDatePast()
        {
            clsPayment APayment = new clsPayment();
            string PaymentDate = DateTime.Now.Date.AddDays(-1).ToString();

            string Error = APayment.Valid(OrderID, Amount, PaymentMethod, PaymentDate, PaymentStatus);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void PaymentDateFuture()
        {
            clsPayment APayment = new clsPayment();
            string PaymentDate = DateTime.Now.Date.AddDays(1).ToString();

            string Error = APayment.Valid(OrderID, Amount, PaymentMethod, PaymentDate, PaymentStatus);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void PaymentDateExtremeFuture()
        {
            clsPayment APayment = new clsPayment();
            string PaymentDate = DateTime.Now.Date.AddYears(100).ToString();

            string Error = APayment.Valid(OrderID, Amount, PaymentMethod, PaymentDate, PaymentStatus);
            Assert.AreEqual("", Error);
        }`
    }
}