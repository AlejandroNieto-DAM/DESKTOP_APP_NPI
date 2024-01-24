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
using System.Runtime.InteropServices;
using System.Windows.Media;

namespace Tuto
{
    public partial class QRscan : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
             int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
             int nHeightEllipse
         );


        private Timer timer;
        private int ratioHeight;
        private int ratioWidth;
        private int screenHeight = 4096, screenWidth = 2160;


        public QRscan(string dia)
        {
            InitializeComponent();

            int formHeight = this.Size.Height;
            int formWidth = this.Size.Width;

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            ratioHeight = screenHeight / formHeight;
            ratioWidth = screenWidth / formWidth;

            panel2.Padding = new Padding(5 * ratioWidth, 5 * ratioHeight, 5 * ratioWidth, 5 * ratioHeight);

            if (Language.SelectedLanguage == 1)
            {
                this.label1.Text = "Scanea el QR para hacer preorder";
            }
            else if (Language.SelectedLanguage == 2)
            {
                this.label1.Text = "Scan the QR to preorder your meal";
            }


            label1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, label1.Size.Width * ratioWidth, label1.Size.Height * ratioHeight, 20 * ratioWidth, 20 * ratioWidth));
            this.label1.Font = new Font("Yu Gothic UI", (int)this.label1.Font.Unit * ratioWidth * 10);


            QRCoder.QRCodeGenerator QRgen = new QRCoder.QRCodeGenerator();
            var MyData = QRgen.CreateQrCode("Menu " + dia, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            pictureBox1.Image = code.GetGraphic(50);

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

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
