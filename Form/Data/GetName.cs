using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data
{
    public class GetName
    {
        public static string GetFirstAndLastName()
        {
            string name = "";
            SqlConnection connection = new SqlConnection(Data.Connection.CONNECTION_STRING);
            string nameCommand = "select firstname, lastname from CarRenting.dbo.accounts where id = @userid";
            connection.Open();
            using (connection)
            {
                using (SqlCommand nameGetter = new SqlCommand(nameCommand, connection))
                {
                    nameGetter.Parameters.AddWithValue("@userid", Data.LoggedInAccountID.ID);
                    SqlDataReader reader = nameGetter.ExecuteReader();
                    while (reader.Read())
                    {
                        name = reader.GetString(0) + " " + reader.GetString(1);
                    }
                }
            }
            connection.Close();
            return name;
        }
    }
}
