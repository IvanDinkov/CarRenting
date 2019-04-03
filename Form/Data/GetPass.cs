using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data
{
    public class GetPass
    {
        //This method gets the password of the currently logged in user
        public static string GetPassword()
        {
            string password = "";
            SqlConnection connection = new SqlConnection(Data.Connection.CONNECTION_STRING);
            string passwordCommand = "select password from CarRenting.dbo.accounts where id = @userid";
            connection.Open();
            using (connection)
            {
                using (SqlCommand passwordGetter = new SqlCommand(passwordCommand, connection))
                {
                    passwordGetter.Parameters.AddWithValue("@userid", LoggedInAccountID.ID);
                    SqlDataReader reader = passwordGetter.ExecuteReader();
                    while (reader.Read())
                    {
                        password = reader.GetString(0);
                    }
                }
            }
            return password;
        }
    }
}
