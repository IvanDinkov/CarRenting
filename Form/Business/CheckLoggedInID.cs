using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class CheckLoggedInID
    {
        private static int id = Data.LoggedInAccountID.ID;
        //This method checks if a user is logged in by checking the currently saved ID
        public static bool IDCheck()
        {
            if (id == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
