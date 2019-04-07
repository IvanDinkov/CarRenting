using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CheckLoggedInIDUnitTest
    {
        string validUsernameInDB = "Dontdelete";
        string validPasswordInDB = "delete";
        [TestMethod]
        public void CheckIDWithoutLoggingIn()
        {
            Assert.IsFalse(Business.CheckLoggedInID.IDCheck());
        }
        [TestMethod]
        public void CheckIDWithLoggingIn()
        {
            StringBuilder validationErrors = new StringBuilder();
            Business.LoginValidations.LoginValidation(validationErrors, validUsernameInDB, validPasswordInDB);
            Assert.IsTrue(Business.CheckLoggedInID.IDCheck());
        }
    }
}
