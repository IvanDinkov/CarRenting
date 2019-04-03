using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for LoginValidationsUnitTest
    /// </summary>
    [TestClass]
    public class LoginValidationsUnitTest
    {
        string validUsernameInDB = "Dontdelete";
        string validPasswordInDB = "delete";
        string emptyUsername = "";
        string emptyPassword = "";
        string validUsernameNotInDB = "Test";
        string validPasswordNotInDB = "Test";
        [TestMethod]
        public void TestWithEmptyStrings()
        {
            StringBuilder validationErrors = new StringBuilder();
            StringBuilder expected = new StringBuilder();
            expected.AppendLine("Username can't be empty.");
            expected.AppendLine("Password can't be empty.");
            Business.LoginValidations.LoginValidation(validationErrors, emptyUsername, emptyPassword);
            validationErrors.ToString().Should().Be(expected.ToString());
        }
        [TestMethod]
        public void TestWithValidStringsNotInDB()
        {
            StringBuilder validationErrors = new StringBuilder();
            StringBuilder expected = new StringBuilder();
            expected.AppendLine($"Your username {validUsernameNotInDB} or password is incorrect. Please try again.");
            Business.LoginValidations.LoginValidation(validationErrors, validUsernameNotInDB, validPasswordNotInDB);
            validationErrors.ToString().Should().Be(expected.ToString());
        }
        [TestMethod]
        public void TestWithValidStringInDB()
        {
            StringBuilder validationErrors = new StringBuilder();
            Business.LoginValidations.LoginValidation(validationErrors, validUsernameInDB, validPasswordInDB);
            validationErrors.ToString().Should().BeEmpty();
        }
    }
}
