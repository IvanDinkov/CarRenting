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
        private void OnTimerEvent(object sender, EventArgs e)
        {
            PreloadForms();
            this.BackgroundImage = imageCollection[counter];
            counter++;
            countChecker();
            TimerSet();
        }
        private void TimerSet()
        {
            timer.Interval = 10000;
            timer.Start();
        }
        private void backgroundImageLoader()
        {
            for (int i = 0; i < 4; i++)
            {
                imageCollection[i] = Image.FromFile($"C:\\Users\\kinib\\Desktop\\Project\\CarRenting\\Images\\MainForm Backgrounds\\Image{i}.jpg");
            }
        }
        private void countChecker()
        {
            if (counter > 3)
            {
                counter = 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Data.LoggedInAccountID.ID = 0;
            this.Hide();
            LoginForm form = new LoginForm();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            Cars cars = new Cars();
            cars.Show();
        }

        private void AccSettings_Click(object sender, EventArgs e)
        {
            AccountSettingsForm accountSettingsForm = new AccountSettingsForm();
            accountSettingsForm.Show();
        }

        private void RentedCars_Click(object sender, EventArgs e)
        {
            RentedCars cars = new RentedCars();
            cars.Show();
        }

        private void PreloadForms()
        {
            Cars cars = new Cars();
            RentedCars rentedCars = new RentedCars();
        }
    }
}
