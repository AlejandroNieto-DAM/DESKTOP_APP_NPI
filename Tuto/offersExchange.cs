using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tuto.Properties;



namespace Tuto
{
    public partial class offersExchange : BasicFormLayout
    {
        bool isNationalExchange;
        string nameUniversity;
        string number_plazas;
        string duracion;
        string requisitos;
        string notas;

        public offersExchange(bool nationalExchange)
        {
            isNationalExchange = nationalExchange;

            InitializeComponent();

            this.Size = FormSize;
            //this.BackColor = Color.Transparent;

            //BackgroundImage = Properties.Resources.Pantalla_Background;
            //BackgroundImageLayout = ImageLayout.Zoom;

            setStyle();
            setdestination();

        }

        public void loadform(object  Form)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }
            
            Form f = Form as Form;
            f.Location = new Point(0, 0);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void MostrarVentanaEmergente(string mensaje)
        {
            MessageBox.Show($"Has hecho clic en el botón: {mensaje}", "Ventana emergente");
        }

        private void setdestination()
        {
            if (isNationalExchange)
            {
                labeltitle.Text = "Movilidad Nacional";
                opt1movbutton.Text = "MADRID";
                opt2movbutton.Text = "SEVILLA";
                opt3movbutton.Text = "ZARAGOZA";
            }
            else
            {
                labeltitle.Text = "ERASMUS";
                opt1movbutton.Text = "AUSTRIA";
                opt2movbutton.Text = "LITUANIA";
                opt3movbutton.Text = "POLONIA";
            }

        }

        private void Form4_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (isNationalExchange)
            {
                nameUniversity = "Universidad de Madrid";
                number_plazas = "2";
                duracion = "Curso completo";
                requisitos = "Haber cursado 45 créditos";
                notas = "No aplica";
            }
            else
            {
                nameUniversity = "Universität Wien";
                number_plazas = "2";
                duracion = "4,5 meses";
                requisitos = "B1 Alemán y/o B2 Inglés";
                notas = " Oferta académica en inglés muy limitada\r\nSolo movilidad en el 2º cuatrimestre";
            }

            movility_template movilitytemplate = new movility_template(nameUniversity, number_plazas, duracion, requisitos, notas);
            loadform(movilitytemplate);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (isNationalExchange)
            {
                nameUniversity = "Universidad de Sevilla";
                number_plazas = "2";
                duracion = "Curso completo";
                requisitos = "Haber cursado 45 créditos";
                notas = "No aplica";
            }
            else
            {
                nameUniversity = "Klaipeda University";
                number_plazas = "1";
                duracion = "5 meses";
                requisitos = "B1 inglés";
                notas = "No se puede realizar TFG";
            }

            movility_template movilitytemplate = new movility_template(nameUniversity, number_plazas, duracion, requisitos, notas);
            loadform(movilitytemplate);

        }

        private void setStyle()
        {
            labeltitle.Font = new Font("Yu Gothic UI", multiplier_size * titleFontSize, FontStyle.Regular);

            foreach (Control control in panelside.Controls)
            {
                if (control is Label)
                {
                    Label boton = (Label)control;
                    boton.Font = new Font("Yu Gothic UI", multiplier_size * titleFontSize, FontStyle.Regular);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (isNationalExchange)
            {
                nameUniversity = "Universidad de Zaragoza";
                number_plazas = "2";
                duracion = "Curso completo";
                requisitos = "Haber cursado 45 créditos";
                notas = "No aplica";
            }
            else
            {
                nameUniversity = "AGH University of Science and Technology";
                number_plazas = "3";
                duracion = "5 meses";
                requisitos = "B2 Inglés";
                notas = "Oferta académica limitada.\nSe puede hacer TFG";
            }

            movility_template movilitytemplate = new movility_template(nameUniversity, number_plazas, duracion, requisitos, notas);
            loadform(movilitytemplate);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void titlelabel_Click(object sender, EventArgs e)
        {

        }

        private void labelUniversity_Click(object sender, EventArgs e)
        {

        }

        private void labeltitle_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {

        }
    }
}



