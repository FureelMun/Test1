using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace FirstTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Password_10contain10_return()
        {
            string password = "Test123@!'";
            int right_password = 10;

            EnterPassword enterPassword = new EnterPassword();
            int actual = enterPassword.Enter_contain10(password);
            Assert.AreEqual(actual, right_password);

        }
        [TestMethod]
        public void Password_PasContainSp_return()
        {
            string password = "Test123@!'";
            var regex = new Regex(@"[\W_]");
            int contain = password.Count(c => regex.IsMatch(c.ToString()));

            EnterPassword enterPassword = new EnterPassword();
            int actual = enterPassword.Enter_containSpecS(password);
            Assert.AreEqual(actual, contain);

        }
        [TestMethod]
        public void Password_PasContainNam_return()
        {
            string password = "Test123@!'";
            var regex = new Regex(@"[0-9]");
            int contain = password.Count(c => regex.IsMatch(c.ToString()));

            EnterPassword enterPassword = new EnterPassword();
            int actual = enterPassword.Enter_containNum(password);
            Assert.AreEqual(actual, contain);

        }
        [TestMethod]
        public void Password_PasContainZog_return()
        {
            string password = "Test123@!'";
            var regex = new Regex(@"[A-Z]");
            int contain = password.Count(c => regex.IsMatch(c.ToString()));

            EnterPassword enterPassword = new EnterPassword();
            int actual = enterPassword.Enter_containZog(password);
            Assert.AreEqual(actual, contain);

        }
        [TestMethod]
        public void Password_PasContainNZog_return()
        {
            string password = "Test123@!'";
            var regex = new Regex(@"[a-z]");
            int contain = password.Count(c => regex.IsMatch(c.ToString()));

            EnterPassword enterPassword = new EnterPassword();
            int actual = enterPassword.Enter_containNZog(password);
            Assert.AreEqual(actual, contain);

        }
        public void TestMethod1()
        {

        }
    }
}
