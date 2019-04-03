using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Models;
using System.Data.SqlClient;

namespace Data
{
    public class RemoveRentedCarInDB
    {
        private static CarRentingContext context = new CarRentingContext();
        private static List<Cars> list = context.Cars.ToList();
        //This method nulls the taken_by column of the current car
        public static void Remove(string selectedItem)
        {
            SqlConnection sqlCon = new SqlConnection(Data.Connection.CONNECTION_STRING);
            sqlCon.Open();

            using (sqlCon)
            {
                SqlCommand sqlCom = new SqlCommand("update CarRenting.dbo.cars set taken_by = null where model = @CarModel;", sqlCon);
                sqlCom.Parameters.AddWithValue("@CarModel", selectedItem);
                sqlCom.ExecuteNonQuery();
            }
            sqlCon.Close();
        }
    }
}
