    using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing3
{
    [TestClass]
    public class tstUser
    {
      
        string FullName = "John Doe";
        string Email = "test@example.com";
        string PasswordHash = "hashed_password_123";
        string Address = "123 Main St";
        string Phone = "07123456789";

        //  INSTANCE & PROPERTY TESTS ==========
        [TestMethod]
        public void InstanceOK()
        {
            clsUser AnUser = new clsUser();
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIdPropertyOK()
        {
            clsUser AnUser = new clsUser();
            Int32 TestData = 1;
            AnUser.UserId = TestData;
            Assert.AreEqual(AnUser.UserId, TestData);
        }

        [TestMethod]
        public void FullNamePropertyOK()
        {
            clsUser AnUser = new clsUser();
            string TestData = "John Doe";
            AnUser.FullName = TestData;
            Assert.AreEqual(AnUser.FullName, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            clsUser AnUser = new clsUser();
            string TestData = "test@example.com";
            AnUser.Email = TestData;
            Assert.AreEqual(AnUser.Email, TestData);
        }

        [TestMethod]
        public void PasswordHashPropertyOK()
        {
            clsUser AnUser = new clsUser();
            string TestData = "hashed_password_123";
            AnUser.PasswordHash = TestData;
            Assert.AreEqual(AnUser.PasswordHash, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            clsUser AnUser = new clsUser();
            string TestData = "123 Main St, Leicester";
            AnUser.Address = TestData;
            Assert.AreEqual(AnUser.Address, TestData);
        }

        [TestMethod]
        public void PhonePropertyOK()
        {
            clsUser AnUser = new clsUser();
            string TestData = "07123456789";
            AnUser.Phone = TestData;
            Assert.AreEqual(AnUser.Phone, TestData);
        }

        [TestMethod]
        public void IsActivePropertyOK()
        {
            clsUser AnUser = new clsUser();
            bool TestData = true;
            AnUser.IsActive = TestData;
            Assert.AreEqual(AnUser.IsActive, TestData);
        }

        [TestMethod]
        public void CreatedAtPropertyOK()
        {
            clsUser AnUser = new clsUser();
            DateTime TestData = DateTime.Now.Date;
            AnUser.CreatedAt = TestData;
            Assert.AreEqual(AnUser.CreatedAt, TestData);
        }

        // ========== FIND METHOD TESTS ==========
        [TestMethod]
        public void FindMethodOK()
        {
            clsUser AnUser = new clsUser();
            Boolean Found = false;
            Int32 UserId = 1;
            Found = AnUser.Find(UserId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserIdFound()
        {
            clsUser AnUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserId = 1;
            Found = AnUser.Find(UserId);
            if (AnUser.UserId != 1) OK = false;
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFullNameFound()
        {
            clsUser AnUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserId = 1;
            Found = AnUser.Find(UserId);
            if (AnUser.FullName != "Test User") OK = false;
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            clsUser AnUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserId = 1;
            Found = AnUser.Find(UserId);
            if (AnUser.Email != "test@example.com") OK = false;
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            clsUser AnUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserId = 1;
            Found = AnUser.Find(UserId);
            if (AnUser.Address != "123 Main St") OK = false;
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneFound()
        {
            clsUser AnUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserId = 1;
            Found = AnUser.Find(UserId);
            if (AnUser.Phone != "07123456789") OK = false;
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsActiveFound()
        {
            clsUser AnUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserId = 1;
            Found = AnUser.Find(UserId);
            if (AnUser.IsActive != true) OK = false;
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCreatedAtFound()
        {
            clsUser AnUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserId = 1;
            Found = AnUser.Find(UserId);
            if (AnUser.CreatedAt.Date != DateTime.Now.Date) OK = false;
            Assert.IsTrue(OK);
        }

        // ========== VALIDATION TESTS (FullName) ==========
        [TestMethod]
        public void ValidMethodOK()
        {
            clsUser AnUser = new clsUser();
            string Error = "";
            Error = AnUser.Valid(FullName, Email, PasswordHash, Address, Phone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMinLessOne()
        {
            clsUser AnUser = new clsUser();
            string Error = "";
            string TestFullName = "Ab";
            Error = AnUser.Valid(TestFullName, Email, PasswordHash, Address, Phone);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMin()
        {
            clsUser AnUser = new clsUser();
            string Error = "";
            string TestFullName = "Abc";
            Error = AnUser.Valid(TestFullName, Email, PasswordHash, Address, Phone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMinPlusOne()
        {
            clsUser AnUser = new clsUser();
            string Error = "";
            string TestFullName = "Abcd";
            Error = AnUser.Valid(TestFullName, Email, PasswordHash, Address, Phone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxLessOne()
        {
            clsUser AnUser = new clsUser();
            string Error = "";
            string TestFullName = new string('A', 49);
            Error = AnUser.Valid(TestFullName, Email, PasswordHash, Address, Phone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMax()
        {
            clsUser AnUser = new clsUser();
            string Error = "";
            string TestFullName = new string('A', 50);
            Error = AnUser.Valid(TestFullName, Email, PasswordHash, Address, Phone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            clsUser AnUser = new clsUser();
            string Error = "";
            string TestFullName = new string('A', 51);
            Error = AnUser.Valid(TestFullName, Email, PasswordHash, Address, Phone);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMid()
        {
            clsUser AnUser = new clsUser();
            string Error = "";
            string TestFullName = new string('A', 25);
            Error = AnUser.Valid(TestFullName, Email, PasswordHash, Address, Phone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameExtremeMax()
        {
            clsUser AnUser = new clsUser();
            string Error = "";
            string TestFullName = new string('A', 500);
            Error = AnUser.Valid(TestFullName, Email, PasswordHash, Address, Phone);
            Assert.AreNotEqual(Error, "");
        }
    }
}