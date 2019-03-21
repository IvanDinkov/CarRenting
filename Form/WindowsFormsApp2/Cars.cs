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
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(@"C:\Users\User\Desktop\cars\duster.png");

            for (int i = 0; i < 10; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Left = 20;
                pictureBox.Top = (50 * (i + 1)) + (i * 150);
                pictureBox.Height = 195;
                pictureBox.Width = 261;
             
                pictureBox.Image = img;
                pictureBox.Show();
                this.Controls.Add(pictureBox);

                Button btn = new Button();
                btn.Left = 300;
                btn.Width = 70;
                btn.Height = 30;
                btn.Top = (50 * (i + 1)) + i * 150;
                btn.Text = "Order";
                btn.Show();
                this.Controls.Add(btn);

                Label lbl = new Label();
                lbl.Left = 300;
                lbl.Top = (50 * (i + 1)) + i * 100; //to do izmisli formula za labelite
                lbl.Text = "zdr dai pari za pasti";
                lbl.Show();
                this.Controls.Add(lbl);
            }
        }
    }
}
