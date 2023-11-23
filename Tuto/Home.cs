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

            ApplyCommonStyleButton();
            AdjustBackgroundPicture();
        }

        private void AdjustBackgroundPicture()
        {
            try
            {
                this.BackgroundImage = Properties.Resources.Pantalla_Background;
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception ex)
            {
                this.BackColor = Color.FromArgb(27, 127, 121);
                MessageBox.Show("Error al cargar la imagen de fondo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyCommonStyleButton()
        {
            // TODO: this is not working
            // Iterar sobre todos los controles en el formulario
            foreach (Control control in tableLayoutOptions.Controls)
            {
                if (control is Button)
                {
                    Button boton = (Button)control;
                    // Hacer algo con el botón, por ejemplo:
                    // boton.BackColor = Color.FromArgb(255, 128, 0);
                    // boton.ForeColor = Color.White;
                    boton.Font = new Font("Arial", 20, FontStyle.Bold);

                    // Verificar si el botón tiene una imagen
                    if (boton.Image != null)
                    {
                        Image originalImage = boton.Image;
                        // Especificar la nueva altura deseada
                        int nuevaAltura = 50;  // Reemplaza con la altura deseada

                        // Calcular la nueva proporción para mantener la relación de aspecto
                        int nuevaAnchura = (int)((double)nuevaAltura / originalImage.Height * originalImage.Width);

                        // Crear una nueva imagen con la altura ajustada
                        Image nuevaImagen = new Bitmap(originalImage, new Size(nuevaAnchura, nuevaAltura));

                        // Asignar la nueva imagen al botón
                        boton.Image = nuevaImagen;
                    }
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
