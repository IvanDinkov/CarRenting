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
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            var context = new CarRentingContext();
            var list = context.Cars.ToList();
            




            for (int i = 0; i < 10; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Left = 20;
                pictureBox.Top = (50 * (i + 1)) + (i * 150);
                pictureBox.Height = 195;
                pictureBox.Width = 261;

                pictureBox.Image = (Bitmap)((new ImageConverter().ConvertFrom(list[i].Picture)));
                pictureBox.Show();
                this.Controls.Add(pictureBox);

                Button btn = new Button();
                btn.Left = 300;
                btn.Width = 70;
                btn.Height = 30;
                btn.Top = (50 * (i + 1)) + (i * 150);
                btn.Text = "Order";
                btn.Show();
                this.Controls.Add(btn);

                Label lblBrand = new Label();
                lblBrand.Left = 300;
                lblBrand.Top = ((50 * (i + 1)) + (i * 150)) + 35;
                lblBrand.Text = "Brand: " +list[i].Brand;
                lblBrand.Show();
                this.Controls.Add(lblBrand);

                Label lblModel = new Label();
                lblModel.Left = 450;
                lblModel.Top = ((50 * (i + 1)) + (i * 150)) + 35;
               
                lblModel.Text = "Model: " + list[i].Model;
                lblModel.Show();
                this.Controls.Add(lblModel);

                Label lblCarType = new Label();
                lblCarType.Left = 300;
                lblCarType.Top = ((50 * (i + 1)) + (i * 150)) + 75;
                lblCarType.Text = "Type: " + list[i].CarType;
                lblCarType.Show();
                this.Controls.Add(lblCarType);

                Label lblPricePerDay = new Label();
                lblPricePerDay.Left = 450;
                lblPricePerDay.Top = ((50 * (i + 1)) + (i * 150)) + 75;
                lblPricePerDay.Text = "Price: " + list[i].PricePerDay + " lv";
                lblPricePerDay.Show();
                this.Controls.Add(lblPricePerDay);

                Label lblFuelConsumption = new Label();
                lblFuelConsumption.Left = 300;
                lblFuelConsumption.Top = ((50 * (i + 1)) + (i * 150)) + 115;
                lblFuelConsumption.AutoSize = false;
                lblFuelConsumption.Width = 120;
                lblFuelConsumption.Text = "Fuel Cons: " + list[i].FuelConsumption;
                lblFuelConsumption.Show();
                this.Controls.Add(lblFuelConsumption);

                Label lblTrasnmission = new Label();
                lblTrasnmission.Left = 450;
                lblTrasnmission.Top = ((50 * (i + 1)) + (i * 150)) + 115;
                lblTrasnmission.Text = "Transm: " + list[i].Transmission;
                lblTrasnmission.Show();
                this.Controls.Add(lblTrasnmission);

                Label lblDoorCount = new Label();
                lblDoorCount.Left = 300;
                lblDoorCount.Top = ((50 * (i + 1)) + (i * 150)) + 155;
                lblDoorCount.Text = "Doors: " + list[i].DoorCount;
                lblDoorCount.Show();
                this.Controls.Add(lblDoorCount);

                Label lblSeatCount = new Label();
                lblSeatCount.Left = 450;
                lblSeatCount.Top = ((50 * (i + 1)) + (i * 150)) + 155;
                lblSeatCount.Text = "Seats: " + list[i].SeatCount;
                lblSeatCount.Show();
                this.Controls.Add(lblSeatCount);
            }
        }
    }
}
