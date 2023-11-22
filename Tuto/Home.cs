using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuto
{
    public partial class Home : Form
    {
        private Timer timer;
        public Home()
        {
            InitializeComponent();

            

            // Initialize the timer
            timer = new Timer();
            timer.Interval = 1000; // Set the interval in milliseconds (1000 ms = 1 second)
            timer.Tick += time_Tick;

            // Start the timer
            timer.Start();
        }
        private void time_Tick(object sender, EventArgs e)
        {
            // Update the Label's text with the current time
            hourLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            dayLabel.Text = DateTime.Now.ToString("dd.MM.yy");

        }
        private void dayInfoPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }



        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = languageBox.SelectedIndex;
            if (indice == 1)
            {
                welcomeLabel.Text = "Welcome";
                scheduleButton.Text = "My personal schedule";
                menuButton.Text = "Canteen Menu";
                professorsButton.Text = "Professors information";
                adminButton.Text = "Administrative requests";
                placeButton.Text = "Search place";
            }
            else
            {
                welcomeLabel.Text = "Bienvenidos";
                scheduleButton.Text = "Mi horario";
                menuButton.Text = "Menú cafetería";
                professorsButton.Text = "Información profesores";
                adminButton.Text = "Procesos administrativos";
                placeButton.Text = "Buscar lugar";
            }
        }
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop the timer when the form is closing
            // TODO: is this working?
            timer.Stop();
        }

    }
}
