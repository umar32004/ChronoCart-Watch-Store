using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;

namespace Testing1
{
    [TestClass]
    public class tstProduct
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsProduct AProduct = new clsProduct();
            Assert.IsNotNull(AProduct);
        }
    }
}