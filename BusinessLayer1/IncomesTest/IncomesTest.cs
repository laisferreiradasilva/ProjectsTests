using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IncomesTest
{
    [TestClass]
    public class IncomesTest
    {
        [TestMethod]
        public void Receipts_Cancelation_Success()
        {
            BusinessLayer1.Incomes incomes = new BusinessLayer1.Incomes();
            bool informedValue = incomes.Cancelation(1);
            Assert.IsTrue(informedValue);
        }
        [TestMethod]
        public void Receipts_Cancelation_Failure()
        {
            BusinessLayer1.Incomes incomes = new BusinessLayer1.Incomes();
            bool informedValue = incomes.Cancelation(-1);
            Assert.IsFalse(informedValue);
        }
        [TestMethod]
        public void Receipts_Devolution_Success()
        {
            BusinessLayer1.Incomes incomes = new BusinessLayer1.Incomes();
            bool informedValue = incomes.Devolution(100);
            Assert.IsTrue(informedValue);
        }
        [TestMethod]
        public void Receipts_Devolution_Failure()
        {
            BusinessLayer1.Incomes incomes = new BusinessLayer1.Incomes();
            bool informedValue = incomes.Devolution(-100);
            Assert.IsFalse(informedValue);
        }
        [TestMethod]
        public void Receipts_Shipping_Success()
        {
            BusinessLayer1.Incomes incomes = new BusinessLayer1.Incomes();
            bool informedValue = incomes.Shipping(12);
            Assert.IsTrue(informedValue);
        }
        [TestMethod]
        public void Receipts_Shipping_Failured()
        {
            BusinessLayer1.Incomes incomes = new BusinessLayer1.Incomes();
            bool informedValue = incomes.Shipping(0);
            Assert.IsFalse(informedValue);
        }
    }
}
