using Microsoft.VisualStudio.TestTools.UnitTesting;
using _5prPiT;
using System;
using System.Windows;
using System.Windows.Controls;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            var pager = new AuPage();
            Assert.IsFalse(pager.saveData("123", "123@", "1234", "д", "Администратор", "1234"));
            Assert.IsTrue(pager.saveData("123", "12346", "1234", "д", "Администратор", "1234567890"));
        }
    }
}
