using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class LogOut
    {
        public static void Logout()
        {
            Data.LoggedInAccountID.ID = 0;
        }
    }
}
