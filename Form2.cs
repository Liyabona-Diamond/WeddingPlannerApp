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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.ShowUpDown = true;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {

        }

        private void GownsButton(object sender, EventArgs e)
        {

        }

        private void SuitesButton(object sender, EventArgs e)
        {

        }

        private void ShoesButton(object sender, EventArgs e)
        {

        }

        private void AccessoriesButton(object sender, EventArgs e)
        {

        }

        private void AttireButton(object sender, EventArgs e)
        {

        }

        private void BackButton1(object sender, EventArgs e)
        {

        }

        private void SaveButton1(object sender, EventArgs e)
        {

        }

        private void MenuButton(object sender, EventArgs e)
        {

        }

        private void MediaButton(object sender, EventArgs e)
        {



        }

        private void DecorButton(object sender, EventArgs e)
        {

        }

        private void ScheduleButton(object sender, EventArgs e)
        {


        }

        private void BackButton2(object sender, EventArgs e)
        {

        }

        private void SaveButton2(object sender, EventArgs e)
        {

        }

        private void BackButton(object sender, EventArgs e)
        {


        }

        private void StartersButton(object sender, EventArgs e)
        {

        }

        private void MainsButton(object sender, EventArgs e)
        {

        }

        private void DessertButton(object sender, EventArgs e)
        {

        }

        private void BeveragesButton(object sender, EventArgs e)
        {

        }

        private void btnDjSound_Click(object sender, EventArgs e)
        {

        }

        private void btnLiveBand_Click(object sender, EventArgs e)
        {

        }

        private void ColourSchemeButton(object sender, EventArgs e)
        {

        }

        private void ThemeButton(object sender, EventArgs e)
        {

        }

        private void TableSettingButton(object sender, EventArgs e)
        {

        }

        private void LightingButton(object sender, EventArgs e)
        {

        }

        private void SeatArrangementsButton(object sender, EventArgs e)
        {

        }

        private void SaveButton4(object sender, EventArgs e)
        {

        }

        private void BackButton4(object sender, EventArgs e)
        {

        }

        private void CeremonyTimeButton(object sender, EventArgs e)
        {

        }

        private void MeetingButton(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnPhotoVideographer_Click(object sender, EventArgs e)
        {

        }

        private void btnCelebrityPerform_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {



        }

        private void ColorSchemeButton(object sender, EventArgs e)
        {

        }

        private void ButtonColorScheme(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Classic Elegant");
            comboBox1.Items.Add("Rustic Charm");
            comboBox1.Items.Add("Modern Minimalist");
            comboBox1.Items.Add("Vintage Glamour");

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Fairy Lights & string lights");
            comboBox2.Items.Add("Candles Lights & Candelabras lights"); 
            comboBox2.Items.Add("Chandeliers");
            comboBox2.Items.Add("Lanterns");
            comboBox2.Items.Add("Projected Lighting");

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Add("Traditional (Bride & Groom at the centre)");
            comboBox3.Items.Add("Sweetheart Table (Bride & Groom at their own table)");
            comboBox3.Items.Add("Long Table (Bride & Groom seated with famili/friends)");
            comboBox3.Items.Add("U-shape (Guests around, with Bride & Groom at the top)");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void dateTimDatePicker1_ValueChange(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChange(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpDate.Value.Date;
            DateTime selectedTime = dtpTime.Value;

            string fullDateandTime = selectedDate.ToShortDateString() + " " + selectedTime.ToShortDateString();

            MessageBox.Show("Selected Date and Time:\nDate & Time:" + fullDateandTime);
               
       
        }

        private void ReceptionButton(object sender, EventArgs e)
        {

        }

        private void GuestActivitiesButton(object sender, EventArgs e)
        {

        }

        private void BackButton3(object sender, EventArgs e)
        {

        }

        private void SaveButton3(object sender, EventArgs e)
        {

        }

        private void BackButton5(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click5(object sender, EventArgs e)
        {

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {

        }
    }
}
