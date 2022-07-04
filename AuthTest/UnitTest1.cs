using _15_09_Lombard.Auth.Presention;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class AuthTest
    {
        [TestMethod]
        public void AutorizationTest()
        {
            string login = "maxim";
            string password = "123123123";

            bool result = AuthPage.Auth(login, password);

            Assert.AreEqual(result, false);
        }
    }
}
