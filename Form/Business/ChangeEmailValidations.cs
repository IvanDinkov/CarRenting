using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ChangeEmailValidations
    {
        //This method checks if the new email is valid
        public static void ChangeEmailValid(StringBuilder ValidationsErrors, string NewEmail)
        {
            if (!CheckLoggedInID.IDCheck())
            {
                ValidationsErrors.AppendLine("You can't change your email now.");
            }
            else if (string.IsNullOrWhiteSpace(NewEmail))
            {
                ValidationsErrors.AppendLine("Email box can not be empty.");
            }
            else if (NewEmail.Length < 5)
            {
                ValidationsErrors.AppendLine("This is not a valid email.");
            }
        }
    }
}
