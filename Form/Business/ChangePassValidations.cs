using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Business
{
    public static class ChangePassValidations
    {
        //This method checks if the new password is valid
        public static void ChangePass(StringBuilder validationSB, string oldPass, string NewPass, string NewPass2)
        {
            if (Data.LoggedInAccountID.ID == 0)
            {
                validationSB.AppendLine("You can't change password at the moment.");
            }
            else if (oldPass != Data.GetPass.GetPassword())
            {
                validationSB.AppendLine("Old password isn't correct.");
            }
            else if (NewPass != NewPass2)
            {
                validationSB.AppendLine("Passwords don't match.");
            }
            else if (string.IsNullOrWhiteSpace(NewPass))
            {
                validationSB.AppendLine("Password shouldn't be empty.");
            }
            else if (NewPass.Length < 5)
            {
                validationSB.AppendLine("Password should be longer.");
            }
            
        }
    }
}
