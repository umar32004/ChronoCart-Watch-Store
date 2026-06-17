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
    public class tstProductUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsProductUser AnUser = new clsProductUser();
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsProductUser AnUser = new clsProductUser();
            Int32 TestData = 1;
            AnUser.UserID = TestData;
            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsProductUser AnUser = new clsProductUser();
            string TestData = "umar";
            AnUser.UserName = TestData;
            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsProductUser AnUser = new clsProductUser();
            string TestData = "password123";
            AnUser.Password = TestData;
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsProductUser AnUser = new clsProductUser();
            string TestData = "Product Management";
            AnUser.Department = TestData;
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            clsProductUser AnUser = new clsProductUser();
            Boolean Found = false;

            string UserName = "umar";
            string Password = "password123";

            Found = AnUser.FindUser(UserName, Password);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            clsProductUser AnUser = new clsProductUser();
            Boolean Found = false;
            Boolean OK = true;

            string UserName = "umar";
            string Password = "password123";

            Found = AnUser.FindUser(UserName, Password);

            if (AnUser.UserName != UserName || AnUser.Password != Password)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}