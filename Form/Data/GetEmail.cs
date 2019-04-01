using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data
{
    public class GetEmail
    {
        public static string GetMail()
        {
            string email = "";
            SqlConnection connection = new SqlConnection(Data.Connection.CONNECTION_STRING);
            string emailCommand = "select email from CarRenting.dbo.accounts where id = @userid";
            connection.Open();
            using (connection)
            {
                using (SqlCommand emailGetter = new SqlCommand(emailCommand, connection))
                {
                    emailGetter.Parameters.AddWithValue("@userid", Data.LoggedInAccountID.ID);
                    SqlDataReader reader = emailGetter.ExecuteReader();
                    while (reader.Read())
                    {
                        email = reader.GetString(0);
                    }
                }
            }
            connection.Close();
            return email;
        }
    }
}
