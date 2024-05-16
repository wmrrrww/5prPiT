using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _5prPiT;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void RegistrationTestSuccess()
        {
            var page = new RegPage();
            Assert.IsTrue(page.Register("Tom John", "Tom.J@example.com", "password123", "Пользователь"));
        }

        [TestMethod]
        public void RegistrationTestFail_EmptyFields()
        {
            var page = new RegPage();
            Assert.IsFalse(page.Register("", "", "", ""));
        }
    }
}