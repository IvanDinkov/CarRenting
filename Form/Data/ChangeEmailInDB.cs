using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data
{
    public class ChangeEmailInDB
    {
        //This method changes the email in the Database
        public static void ChangeEmail(string newEmail)
        {
            SqlConnection connection = new SqlConnection(Data.Connection.CONNECTION_STRING);
            string commandString = "update CarRenting.dbo.accounts set email = @newemail where id = @id";
            connection.Open();
            using (connection)
            {
                SqlCommand passwordChange = new SqlCommand(commandString, connection);
                passwordChange.Parameters.AddWithValue("newemail", newEmail);
                passwordChange.Parameters.AddWithValue("id", Data.LoggedInAccountID.ID);
                passwordChange.ExecuteNonQuery();
            }
            connection.Close();
        }
    }
}
