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

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.io;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            InitializeComponent();
            Timer tm = new Timer();
            tm.Interval = 20000;
            tm.Tick += new EventHandler(changeImage);
            tm.Start();

     
        }

        private void changeImage(object sender, EventArgs e)
        {
            List<Bitmap> bt = new List<Bitmap>();
            bt.Add(Properties.Resources.images);
            bt.Add(Properties.Resources.io);
            bt.Add(Properties.Resources._1);
            int index = DateTime.Now.Second % bt.Count;
            this.BackgroundImage = bt[index];
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
