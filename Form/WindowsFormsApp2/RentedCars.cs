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

namespace WindowsFormsApp2
{
    public partial class RentedCars : Form
    {
        private static CarRentingContext context = new CarRentingContext();
        private List<Models.Cars> list = context.Cars.Where(e => e.TakenBy == Data.LoggedInAccountID.ID).ToList();
        public RentedCars()
        {
            InitializeComponent();
        }

        private void RentedCars_Load(object sender, EventArgs e)
        {
            LoadRentedCars();
        }
        //This method loads the currently rented cars of the user who is logged in
        private void LoadRentedCars()
        {
            foreach (var item in list)
            {
                comboBox1.Items.Add(item.Brand + " " + item.Model);
            }
        }
        //This method puts the car's info into the labels
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = list.FindIndex(w => w.Brand + " " + w.Model == comboBox1.SelectedItem.ToString());
            lblBrand.Text = "Brand: " + list[selectedItem].Brand;
            lblCarType.Text = "Type: " + list[selectedItem].CarType;
            lblDoorCount.Text = "Doors: " + list[selectedItem].DoorCount.ToString();
            lblFuelCons.Text = "Consumption: " + list[selectedItem].FuelConsumption;
            lblModel.Text = "Model: " + list[selectedItem].Model;
            lblPricePerDay.Text = "Price/Day: " + list[selectedItem].PricePerDay.ToString();
            lblSeatCount.Text = "Seats: " + list[selectedItem].SeatCount.ToString();
            lblTransmission.Text = "Transmission:" + list[selectedItem].Transmission.ToString();
            pictureBox1.Image = (Image)new ImageConverter().ConvertFrom(list[selectedItem].Picture);
        }
        //This method gets the model of the selected car and sends it over to the remove method to remove the car
        private void btnRemove_Click(object sender, EventArgs e)
        {

            var selectedItem = list.FindIndex(w => w.Brand + " " + w.Model == comboBox1.SelectedItem.ToString());
            string model = list[selectedItem].Model;
            Data.RemoveRentedCarInDB.Remove(model);
            comboBox1.Items.Remove(selectedItem);
            RentedCars rented = new RentedCars();
            this.Close();
            rented.Show();
            MessageBox.Show("Car removed successfully.");
        }
    }
}
