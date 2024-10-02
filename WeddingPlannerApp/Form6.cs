using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeddingPlannerApp
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //textboxes
            string date = dateTimePicker1.Text; //date and time picker textbox
            string modeOfConsultation = comboBox1.Text; //consultationmode textbox
            string assignedConsultant = textBox1.Text; //assignedconsultant textbox
            string clientInfo = textBox2.Text;  //client info text box
            string serviceSpecifics = textBox3.Text; //services textbox
            string consultationStatus = comboBox2.Text; //status textbox
            string reminder = comboBox3.Text;  //reminder textbox

           
            string content = $"Date and Time: {date}\n" +
                             $"Mode of Consultation: {modeOfConsultation}\n" +
                             $"Assigned Consultant: {assignedConsultant}\n" +
                             $"Client Information: {clientInfo}\n" +
                             $"Service Specifics: {serviceSpecifics}\n" +
                             $"Consultation Status: {consultationStatus}\n" +
                             $"Reminder: {reminder}\n";

            
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

           
            string directoryPath = Path.Combine(documentsPath, "WeddingPlannerAppData");

            
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath); 
            }

            
            string filePath = Path.Combine(directoryPath, "BookingConfirmation.txt");

            //writes the data to the path
            File.WriteAllText(filePath, content);

            //tell user that data was saved
            MessageBox.Show("Data saved to " + filePath);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
