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
        public void AuthTestSuccess()
        {
            var pager = new AuthPage();
            Assert.IsTrue(pager.Auth("Elizor@gmai.com", "yntiRS"));
            Assert.IsTrue(pager.Auth("Vladlena@gmai.com", "07i7Lb"));
            Assert.IsTrue(pager.Auth("Adam@gmai.com", "7SP9CV"));
            Assert.IsTrue(pager.Auth("Kar@gmai.com", "6QF1WB"));
            Assert.IsTrue(pager.Auth("Yli@gmai.com", "GwffgE"));
            Assert.IsTrue(pager.Auth("Vasilisa@gmai.com", "d7iKKV"));
            Assert.IsTrue(pager.Auth("Galina@gmai.com", "8KC7wJ"));
            Assert.IsTrue(pager.Auth("Miron@gmai.com", "x58OAN"));
            Assert.IsTrue(pager.Auth("Vseslava@gmai.com", "fhDSBf"));
            Assert.IsTrue(pager.Auth("Victoria@gmai.com", "9mlPQJ"));
            Assert.IsTrue(pager.Auth("Anisa@gmai.com", "Wh4OYm"));
            Assert.IsTrue(pager.Auth("Feafan@gmai.com", "Kc1PeS"));
        }
    }
}
