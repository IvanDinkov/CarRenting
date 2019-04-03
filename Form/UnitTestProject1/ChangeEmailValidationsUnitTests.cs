using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for ChangeEmailValidationsUnitTests
    /// </summary>
    [TestClass]
    public class ChangeEmailValidationsUnitTests
    {
        string invalidEmail = "Test";
        string validEmail = "test@test.bg";
        string emptyString = "";
        [TestMethod]
        public void TestWithInvalidEmail()
        {
            StringBuilder validationsErrors = new StringBuilder();
            StringBuilder expected = new StringBuilder();
            expected.AppendLine("This is not a valid email.");
            Business.ChangeEmailValidations.ChangeEmailValid(validationsErrors, invalidEmail);
            validationsErrors.ToString().Should().Be(expected.ToString());
        }
        [TestMethod]
        public void TestWithEmptyString()
        {
            StringBuilder validationsErrors = new StringBuilder();
            StringBuilder expected = new StringBuilder();
            expected.AppendLine("Email box can not be empty.");
            Business.ChangeEmailValidations.ChangeEmailValid(validationsErrors, emptyString);
            validationsErrors.ToString().Should().Be(expected.ToString());
        }
        [TestMethod]
        public void TestWithValidEmailAndNoID()
        {
            StringBuilder validationsErrors = new StringBuilder();
            StringBuilder expected = new StringBuilder();
            expected.AppendLine("You can't change your email now.");
            Business.ChangeEmailValidations.ChangeEmailValid(validationsErrors, validEmail);
            validationsErrors.ToString().Should().Be(expected.ToString());
        }
    }
}
