using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private int counter = 0;
        Timer timer = new Timer();
        Image[] imageCollection = new Image[5];
        private void MainForm_Load(object sender, EventArgs e)
        {
            PreloadForms();
            backgroundImageLoader();
            this.BackgroundImage = imageCollection[3];
            timer.Tick += new System.EventHandler(OnTimerEvent);
            TimerSet();
        }
        //This method changes the background image when the timer is done counting
        private void OnTimerEvent(object sender, EventArgs e)
        {
            PreloadForms();
            this.BackgroundImage = imageCollection[counter];
            counter++;
            countChecker();
            TimerSet();
        }
        //This method resets the timer
        private void TimerSet()
        {
            timer.Interval = 10000;
            timer.Start();
        }
        //This method loads images from a folder into an image array
        private void backgroundImageLoader()
        {
            for (int i = 0; i < 4; i++)
            {
                imageCollection[i] = Image.FromFile($"C:\\Users\\kinib\\Desktop\\Project\\CarRenting\\Images\\MainForm Backgrounds\\Image{i}.jpg");
            }
        }
        //This method checks for the background images that have already gone so it repeats in the end
        private void countChecker()
        {
            if (counter > 3)
            {
                counter = 0;
            }
        }
        //This method logs off of account and nulls the recorded ID
        private void button1_Click(object sender, EventArgs e)
        {
            Business.LogOut.Logout();
            this.Hide();
            LoginForm form = new LoginForm();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
        //This method opens Cars form
        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            Cars cars = new Cars();
            cars.Show();
        }
        //This method opens AccountSettingsForm
        private void AccSettings_Click(object sender, EventArgs e)
        {
            AccountSettingsForm accountSettingsForm = new AccountSettingsForm();
            accountSettingsForm.Show();
        }
        //This method opens RentedCars form
        private void RentedCars_Click(object sender, EventArgs e)
        {
            RentedCars rentedCars = new RentedCars();
            rentedCars.Show();
        }
        //This method preloads the Cars form and the RentedCars form so when clicking the button it instantly loads
        private void PreloadForms()
        {
            Cars cars = new Cars();
            RentedCars rentedCars = new RentedCars();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Information inf = new Information();
            inf.Show();
        }
    }
}
