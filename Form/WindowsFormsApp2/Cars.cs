using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Models;
using System.Data.SqlClient;


namespace WindowsFormsApp2
{
    public partial class Cars : Form
    {
        private static CarRentingContext context = new CarRentingContext();
        private List<Models.Cars> list = context.Cars.ToList();

        public Cars()
        {
            InitializeComponent();
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void LoadCars()
        {
            LoadRentableCars();
        }

        private void LoadRentableCars()
        {
            foreach (var item in list)
            {
                comboBox1.Items.Add(item.Brand + " " + item.Model);
            } 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = list.FindIndex(w =>w.Brand + " " + w.Model == comboBox1.SelectedItem.ToString());
            lblBrand.Text = "Brand: " + list[selectedItem].Brand;
            lblCarType.Text = "Type: " + list[selectedItem].CarType;
            lblDoorCount.Text = "Doors: " + list[selectedItem].DoorCount.ToString();
            lblFuelCons.Text = "Consumption: " + list[selectedItem].FuelConsumption;
            lblModel.Text = "Model: " + list[selectedItem].Model;
            lblPricePerDay.Text = "Price/Day: " + list[selectedItem].PricePerDay.ToString();
            lblSeatCount.Text = "Seats: " + list[selectedItem].SeatCount.ToString();
            lblTransmission.Text ="Transmission:" + list[selectedItem].Transmission.ToString();
            pictureBox1.Image = (Image)new ImageConverter().ConvertFrom(list[selectedItem].Picture);
            if (list[selectedItem].TakenBy.ToString() == "")
            {
                lblStatus.Text = "Status: Free";
            }
            else
            {
                lblStatus.Text =  "Status: Occupied";
            }
        }
        private void btnRent_Click(object sender, EventArgs e)
        {        
            if (lblStatus.Text == "Status: Free")
            {

                var idOfUser = Data.LoggedInAccountID.ID;
                var selectedItem = list.FindIndex(w => w.Brand + " " + w.Model == comboBox1.SelectedItem.ToString());
                int idSelectedCar = list[selectedItem].Id;
                SqlConnection sqlCon = new SqlConnection(Data.Connection.CONNECTION_STRING);
                sqlCon.Open();

                using (sqlCon)
                {
                    SqlCommand sqlCom = new SqlCommand("update CarRenting.dbo.cars set taken_by = @id where id = @brand  ", sqlCon);
                    sqlCom.Parameters.AddWithValue("@id", idOfUser);
                    sqlCom.Parameters.AddWithValue("@brand", idSelectedCar);
                    sqlCom.ExecuteNonQuery();
                }
                sqlCon.Close();
                lblStatus.Text = "Occupied";
                MessageBox.Show("Car rented successfully");
                
            }
            else
            {
                MessageBox.Show("The car is already being occupied");
                
            }

        }
    }
}
