using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for CheckPassValidationUnitTest
    /// </summary>
    [TestClass]
    public class CheckPassValidationUnitTest
    {
        string invalidOldPass = "qwerty";
        string validUsernameInDB = "Dontdelete";
        string validPasswordInDB = "delete";

        [TestMethod]
        public void TestWithInvalidOldPassword()
        {
            StringBuilder oldPasswordErrors = new StringBuilder();
            StringBuilder expected = new StringBuilder();
            expected.AppendLine("Old password isn't correct.");
            Business.LoginValidations.LoginValidation(oldPasswordErrors, validUsernameInDB, validPasswordInDB);
            Business.ChangePassValidations.ChangePass(oldPasswordErrors, invalidOldPass, "QAZWSXEDC" , "QAZWSXEDC");
            oldPasswordErrors.ToString().Should().Be(expected.ToString());
        }
        [TestMethod]
        public void TestDiffrentNewPasswords()
        {
            StringBuilder newPasswordsErrors = new StringBuilder();
            StringBuilder expected = new StringBuilder();
            expected.AppendLine("Passwords don't match.");
            Business.LoginValidations.LoginValidation(newPasswordsErrors, validUsernameInDB, validPasswordInDB);
            Business.ChangePassValidations.ChangePass(newPasswordsErrors, validPasswordInDB, "qwerty" , "qwertyu");
            newPasswordsErrors.ToString().Should().Be(expected.ToString());
        }
        [TestMethod]
        public void TestWithEmptyNewPassword()
        {
            StringBuilder newPasswordsErrors = new StringBuilder();
            StringBuilder expected = new StringBuilder();
            expected.AppendLine("Password shouldn't be empty.");
            Business.LoginValidations.LoginValidation(newPasswordsErrors, validUsernameInDB, validPasswordInDB);
            Business.ChangePassValidations.ChangePass(newPasswordsErrors, validPasswordInDB, "", "");
            newPasswordsErrors.ToString().Should().Be(expected.ToString());
        }
        [TestMethod]
        public void TestWithNotLongEnoughPassword()
        {
            StringBuilder newPasswordsErrors = new StringBuilder();
            StringBuilder expected = new StringBuilder();
            expected.AppendLine("Password should be longer.");
            Business.LoginValidations.LoginValidation(newPasswordsErrors, validUsernameInDB, validPasswordInDB);
            Business.ChangePassValidations.ChangePass(newPasswordsErrors, validPasswordInDB, "qwe", "qwe");
            newPasswordsErrors.ToString().Should().Be(expected.ToString());
        }
        [TestMethod]
        public void TestWithNotLoggenInUser()
        {
            StringBuilder notLoggedInUser = new StringBuilder();
            StringBuilder expected = new StringBuilder();
            expected.AppendLine("You can't change password at the moment.");
            Business.ChangePassValidations.ChangePass(notLoggedInUser, validPasswordInDB, "qwe", "qwe");
            notLoggedInUser.ToString().Should().Be(expected.ToString());
        }
    }
}
