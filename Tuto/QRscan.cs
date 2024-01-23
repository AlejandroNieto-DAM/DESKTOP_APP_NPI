using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leap;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Runtime.CompilerServices;

namespace Tuto
{
    public partial class QRscan : Form
    {


        private Timer timer;
        private int ratioHeight;
        private int ratioWidth;
        private int screenHeight = 4096, screenWidth = 2160;


        public QRscan(string dia)
        {
            InitializeComponent();


            int formHeight = this.Size.Height;
            int formWidth = this.Size.Width;

            ratioHeight = screenHeight / formHeight;
            ratioWidth = screenWidth / formWidth;


            panel2.Padding = new Padding(5 * ratioWidth, 5 * ratioHeight, 5 * ratioWidth, 5 * ratioHeight);
            panel1.Height *= ratioHeight;
            dayLabel.Height *= ratioHeight;
            dayLabel.Width *= ratioWidth;

            if (Language.SelectedLanguage == 1)
            {
                this.label1.Text = "Para acceder necesitas tu código QR personal. \r\nPuedes encontrarlo en tu App de la UGR\r\n";
                this.label2.Text = "Para ir hacia atrás usa el gesto de pasar página hacia atrás";


            }
            else if (Language.SelectedLanguage == 2)
            {
                this.label1.Text = "To log in you need your personal UGR QR code. \r\nYou can find it in your UGR App profile!\r\n";
                this.label2.Text = "To go back use the page back gesture";


            }

            QRCoder.QRCodeGenerator QRgen = new QRCoder.QRCodeGenerator();
            var MyData = QRgen.CreateQrCode("Menu " + dia, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            pictureBox2.Image = code.GetGraphic(50);

        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();   //cerrar ventana para que la camara no siga abierta
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void time_Tick(object sender, EventArgs e)
        {
            // Update the Label's text with the current time
            dayLabel.Text = DateTime.Now.ToString("HH:mm");
            dayLabel.Text = DateTime.Now.ToString("dd.MM.yy");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void close_Form()
        {
            this.Hide();
            NewHome newForm = new NewHome();
            newForm.Show();
        }

        private void closingForm()
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
