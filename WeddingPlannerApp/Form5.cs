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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDateandTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblNotesforConsultation_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxConsultationMode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.ShowUpDown = true;

            comboBoxConsultationMode.Items.Add("In-Person");
            comboBoxConsultationMode.Items.Add("online");
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpDate.Value.Date;
            DateTime selectedTime = dtpTime.Value;

            string selectedMode = comboBoxConsultationMode.SelectedItem.ToString();
            string specialNotes = txtNotes.Text;

            string fullDateandTime = selectedDate.ToShortDateString() + " " + selectedTime.ToShortTimeString();

            MessageBox.Show("Consultation Details:\nDate & Time:" + fullDateandTime +
                           "\nConsultation Mode:" + selectedMode +
                           "\nSpecial notes added:" + specialNotes);

        }
    }
}
