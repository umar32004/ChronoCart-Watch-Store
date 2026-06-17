using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing4
{
    [TestClass]
    public class tstPaymentCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            Assert.IsNotNull(AllPayments);
        }

        [TestMethod]
        public void PaymentListOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            System.Collections.Generic.List<clsPayment> TestList = new System.Collections.Generic.List<clsPayment>();

            clsPayment TestItem = new clsPayment();

            TestItem.PaymentID = 1;
            TestItem.OrderID = 1;
            TestItem.Amount = 2500.00m;
            TestItem.PaymentMethod = "Card";
            TestItem.PaymentDate = DateTime.Now.Date;
            TestItem.PaymentStatus = "Completed";

            TestList.Add(TestItem);

            AllPayments.PaymentList = TestList;

            Assert.AreEqual(AllPayments.PaymentList, TestList);
        }

        [TestMethod]
        public void ThisPaymentPropertyOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            clsPayment TestPayment = new clsPayment();

            TestPayment.PaymentID = 1;
            TestPayment.OrderID = 1;
            TestPayment.Amount = 2500.00m;
            TestPayment.PaymentMethod = "Card";
            TestPayment.PaymentDate = DateTime.Now.Date;
            TestPayment.PaymentStatus = "Completed";

            AllPayments.ThisPayment = TestPayment;

            Assert.AreEqual(AllPayments.ThisPayment, TestPayment);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            System.Collections.Generic.List<clsPayment> TestList = new System.Collections.Generic.List<clsPayment>();

            clsPayment TestItem = new clsPayment();

            TestItem.PaymentID = 1;
            TestItem.OrderID = 1;
            TestItem.Amount = 2500.00m;
            TestItem.PaymentMethod = "Card";
            TestItem.PaymentDate = DateTime.Now.Date;
            TestItem.PaymentStatus = "Completed";

            TestList.Add(TestItem);

            AllPayments.PaymentList = TestList;

            Assert.AreEqual(AllPayments.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            clsPayment TestItem = new clsPayment();

            int PrimaryKey = 0;

            TestItem.OrderID = 1;
            TestItem.Amount = 350.00m;
            TestItem.PaymentMethod = "Card";
            TestItem.PaymentDate = DateTime.Now.Date;
            TestItem.PaymentStatus = "Completed";

            AllPayments.ThisPayment = TestItem;

            PrimaryKey = AllPayments.Add();

            TestItem.PaymentID = PrimaryKey;

            AllPayments.ThisPayment.Find(PrimaryKey);

            Assert.AreEqual(AllPayments.ThisPayment.PaymentID, TestItem.PaymentID);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            clsPayment TestItem = new clsPayment();

            int PrimaryKey = 0;

            TestItem.OrderID = 1;
            TestItem.Amount = 350.00m;
            TestItem.PaymentMethod = "Card";
            TestItem.PaymentDate = DateTime.Now.Date;
            TestItem.PaymentStatus = "Completed";

            AllPayments.ThisPayment = TestItem;

            PrimaryKey = AllPayments.Add();

            TestItem.PaymentID = PrimaryKey;
            TestItem.OrderID = 2;
            TestItem.Amount = 500.00m;
            TestItem.PaymentMethod = "Bank Transfer";
            TestItem.PaymentDate = DateTime.Now.Date;
            TestItem.PaymentStatus = "Pending";

            AllPayments.ThisPayment = TestItem;
            AllPayments.Update();

            AllPayments.ThisPayment.Find(PrimaryKey);

            Assert.AreEqual(AllPayments.ThisPayment.PaymentStatus, "Pending");
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            clsPayment TestItem = new clsPayment();

            int PrimaryKey = 0;

            TestItem.OrderID = 1;
            TestItem.Amount = 350.00m;
            TestItem.PaymentMethod = "Card";
            TestItem.PaymentDate = DateTime.Now.Date;
            TestItem.PaymentStatus = "Completed";

            AllPayments.ThisPayment = TestItem;

            PrimaryKey = AllPayments.Add();

            TestItem.PaymentID = PrimaryKey;

            AllPayments.ThisPayment = TestItem;

            AllPayments.Delete();

            bool Found = AllPayments.ThisPayment.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }
    }
}