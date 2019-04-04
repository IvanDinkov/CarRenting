using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;


namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for RegisterValidationUnitTest
    /// </summary>
    [TestClass]
    public class RegisterValidationUnitTest
    {
        [TestMethod]
        public void TestWithInvalidFirstOrLastName()
        {
            StringBuilder invalidFirstOrLastName = new StringBuilder();
            StringBuilder expected = new StringBuilder();
            expected.AppendLine("First/Last name should be longer.");
            expected.AppendLine("First/Last name should be longer.");
            Business.RegisterValidations.fullValidation(invalidFirstOrLastName, "qwerty1", "q", "w", "123456", "123456", "gosho39@abv.bg");
            invalidFirstOrLastName.ToString().Should().Be(expected.ToString());
        }
        [TestMethod]
        public void TestWithInvalidPassword()
        {
            StringBuilder invalidPassword = new StringBuilder();
            StringBuilder expected = new StringBuilder();
            expected.AppendLine("Password should be longer.");
            Business.RegisterValidations.fullValidation(invalidPassword, "qwerty1", "ivancho", "ivanov", "12", "12", "gosho39@abv.bg");
            invalidPassword.ToString().Should().Be(expected.ToString());
        }
        [TestMethod]
        public void TestWithEmptyPassword()
        {
            StringBuilder emptyPassword = new StringBuilder();
            StringBuilder expected = new StringBuilder();
            expected.AppendLine("Password shouldn't be empty.");
            Business.RegisterValidations.fullValidation(emptyPassword, "qwerty1", "ivancho", "ivanov", "", "", "gosho39@abv.bg");
            emptyPassword.ToString().Should().Be(expected.ToString());
        }
        [TestMethod]
        public void TestWithWrongPassword()
        {
            StringBuilder wrongPasswords = new StringBuilder();
            StringBuilder expected = new StringBuilder();
            expected.AppendLine("Passwords don't match.");
            Business.RegisterValidations.fullValidation(wrongPasswords, "qwerty1", "ivancho", "ivanov", "12345678", "1234567", "gosho39@abv.bg");
            wrongPasswords.ToString().Should().Be(expected.ToString());
        }
        [TestMethod]
        public void TestWithWrongUsername()
        {
            StringBuilder wrongUsername = new StringBuilder();
            StringBuilder expected = new StringBuilder();
            expected.AppendLine("Username should be longer.");
            Business.RegisterValidations.fullValidation(wrongUsername, "q1", "ivancho", "ivanov", "12345678", "12345678", "gosho39@abv.bg");
            wrongUsername.ToString().Should().Be(expected.ToString());
        }
        [TestMethod]
        public void TestWithAlreadyUsedEmail()
        {
            StringBuilder alreadyUsedEmail = new StringBuilder();
            StringBuilder expected = new StringBuilder();
            expected.AppendLine("This E-mail is already in use.");
            Business.RegisterValidations.fullValidation(alreadyUsedEmail, "q2345w", "ivancho", "ivanov", "12345678", "12345678", "qwertyuiop[");
            alreadyUsedEmail.ToString().Should().Be(expected.ToString());
        }
        [TestMethod]
        public void TestWithAlreadyUsedUsername()
        {
            StringBuilder alreadyUsedUsername = new StringBuilder();
            StringBuilder expected = new StringBuilder();
            expected.AppendLine("This Username is already in use.");
            Business.RegisterValidations.fullValidation(alreadyUsedUsername, "Dontdelete", "ivancho", "ivanov", "12345678", "12345678", "qwertyuiop[]");
            alreadyUsedUsername.ToString().Should().Be(expected.ToString());
        }
    }
}
