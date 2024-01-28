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
using Leap;

namespace Tuto
{
    public partial class adminOptions : BasicFormLayout
    {
        private Timer timer;
        bool national = false;
        public adminOptions()
        {
            InitializeComponent();

            Language.className = "adminOptions"; 
            Language.lastForm = this;

            // Initialize the timer
            timer = new Timer();
            timer.Interval = 1000; // Set the interval in milliseconds (1000 ms = 1 second)
            timer.Tick += time_Tick;

            // Start the timer
            timer.Start();

            change_language();
            ApplyCommonStyleButton();
           

            //hourLabel.Text = hourLabelText;
            //dayLabel.Text = dayLabelText;

            this.Size = FormSize;


        }

        private void change_language()
        {
            if (Language.SelectedLanguage == 1)
            {
                labelTitle.Text = "Trámites";
                buttonMovInterna.Text = "Movilidad Internacional";
                buttonMovNacional.Text = "Movilidad Nacional";
                buttonBecas.Text = "Becas";
            }
            else if (Language.SelectedLanguage == 2)
            {
                labelTitle.Text = "Procedures";
                buttonMovInterna.Text = "International exchange";
                buttonMovNacional.Text = "National exchange";
                buttonBecas.Text = "Scholarships";
            }
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
                    boton.Font = new Font("Yu Gothic UI", textFontSize * multiplier_size, FontStyle.Bold);
                }
            }
            labelTitle.Font = new Font("Yu Gothic UI", titleFontSize * multiplier_size, FontStyle.Bold);
        }
        
        private void time_Tick(object sender, EventArgs e)
        {
            // Update the Label's text with the current time
            hourLabel.Text = DateTime.Now.ToString("HH:mm");
            dayLabel.Text = DateTime.Now.ToString("dd.MM.yy");

        }


        public void close_Form()
        {
            this.Hide();
            NewHome h = new NewHome();
            h.Show();
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
            offersExchange offers_window = new offersExchange(true);
            offers_window.Show();
            this.Hide();
        }

        private void buttonMovInterna_Click(object sender, EventArgs e)
        {
            offersExchange offers_window = new offersExchange(national);
            offers_window.Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Becas becas = new Becas();
            becas.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
