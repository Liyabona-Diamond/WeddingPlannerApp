using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeddingPlannerApp
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            Form3 profileForm = new Form3();

            profileForm.Show();
        }

        private void servicebutton_Click(object sender, EventArgs e)
        {
            Form2 serviceForm = new Form2();
            serviceForm.Show();
        }

        private void AboutUsButoon_Click(object sender, EventArgs e)
        {
            Form9 AbouUsForm = new Form9();
            AbouUsForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
