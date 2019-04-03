using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data
{
    public class ChangePassInDB
    {
        //This method changes the password in the database with the new one
        public static void ChangePassInDataBase(string newPassword)
        {
            SqlConnection connection = new SqlConnection(Data.Connection.CONNECTION_STRING);
            string commandString = "update CarRenting.dbo.accounts set password = @newpass where id = @id";
            connection.Open();
            using (connection)
            {
                SqlCommand passwordChange = new SqlCommand(commandString, connection);
                passwordChange.Parameters.AddWithValue("newpass", newPassword);
                passwordChange.Parameters.AddWithValue("id", Data.LoggedInAccountID.ID);
                passwordChange.ExecuteNonQuery();
            }
            connection.Close();
        }
    }
}
