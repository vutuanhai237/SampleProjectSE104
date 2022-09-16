using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Employee adam = new Employee("Adam");
        [TestMethod]
        public void TestExportInfo()
        {
            Assert.AreEqual("Adam: 0", adam.exportInfor());
        }

        [TestMethod]
        public void TestCalculateSalary1()
        {
            adam.calculateSalary(5);
            Assert.AreEqual(500, adam.salary);
        }

        [TestMethod]
        public void TestCalculateSalary2()
        {
            adam.calculateSalary(0);
            Assert.AreEqual(0, adam.salary);
        }

    }
}
