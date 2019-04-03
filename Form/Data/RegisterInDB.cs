using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data
{
    public class RegisterInDB
    {
        //This method registers the user into the database
        public static void SuccessfulValidation(string Firstname, string Lastname, string Username, string Password, string Email)
        {
            SqlConnection sqlCon = new SqlConnection(Data.Connection.CONNECTION_STRING);
            sqlCon.Open();

            using (sqlCon)
            {
                SqlCommand sqlCom = new SqlCommand("Insert into CarRenting.dbo.accounts (Firstname,Lastname,Username,Password, Email) values (@Firstname, @Lastname, @Username, @Password, @Email)", sqlCon);
                sqlCom.Parameters.AddWithValue("@Firstname", Firstname);
                sqlCom.Parameters.AddWithValue("@Lastname", Lastname);
                sqlCom.Parameters.AddWithValue("@Username", Username);
                sqlCom.Parameters.AddWithValue("@Password", Password);
                sqlCom.Parameters.AddWithValue("@Email", Email);
                sqlCom.ExecuteNonQuery();
            }
            sqlCon.Close();
        }
    }
}
