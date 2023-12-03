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
    public partial class adminOptions : BasicFormLayout
    {
        private Timer timer;
        bool national = false;
        public adminOptions()
        {
            InitializeComponent();
        
            
            // Initialize the timer
            timer = new Timer();
            timer.Interval = 1000; // Set the interval in milliseconds (1000 ms = 1 second)
            timer.Tick += time_Tick;

            // Start the timer
            timer.Start();
            
            
            ApplyCommonStyleButton();
            //AdjustBackgroundPicture();

            //hourLabel.Text = hourLabelText;
            //dayLabel.Text = dayLabelText;

            this.Size = FormSize;


        }

        private void AdjustBackgroundPicture()
        {
            try
            {
                this.BackgroundImage = Properties.Resources.Pantalla_Background;
                this.BackgroundImageLayout = ImageLayout.Zoom;
            }
            catch (Exception ex)
            {
                //this.BackColor = Color.FromArgb(27, 127, 121);
                MessageBox.Show("Error al cargar la imagen de fondo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyCommonStyleButton()
        {
            // TODO: this is not working
            // Iterar sobre todos los controles en el formulario
            foreach (Control control in tableLayoutPanel2.Controls)
            {
                if (control is Button)
                {
                    Button boton = (Button)control;
                    boton.Font = new Font("Arial", 16, FontStyle.Bold);
                }
            }
        }
        
        private void time_Tick(object sender, EventArgs e)
        {
            // Update the Label's text with the current time
            hourLabel.Text = DateTime.Now.ToString("HH:mm");
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
        /*
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = languageBox.SelectedIndex;
            if (indice == 1)
            {
                welcomeLabel.Text = "Welcome";
                nationalButton.Text = "My personal schedule";
                menuButton.Text = "Canteen Menu";
                Button.Text = "Professors information";
                adminButton.Text = "Administrative requests";
                placeButton.Text = "Search place";
            }
            else
            {
                welcomeLabel.Text = "Bienvenidos";
                nationalButton.Text = "Mi horario";
                menuButton.Text = "Menú cafetería";
                Button.Text = "Información profesores";
                adminButton.Text = "Procesos administrativos";
                placeButton.Text = "Buscar lugar";
            }
        }
        
        */
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop the timer when the form is closing
            // TODO: is this working?
            timer.Stop();
        }

        private void nationalButton_Click(object sender, EventArgs e)
        {

        }

        private void welcomePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void buttonMovNacional_Click(object sender, EventArgs e)
        {
            national = !national;
            administrativeMenu nationalWindow = new administrativeMenu(true);
            nationalWindow.Show();
            this.Hide();
        }

        private void buttonMovInterna_Click(object sender, EventArgs e)
        {
            administrativeMenu nationalWindow = new administrativeMenu(national);
            nationalWindow.Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
