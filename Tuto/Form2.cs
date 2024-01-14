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
    public partial class Form2 : Form
    {


        private Timer timer;



        public Form2()
        {
            InitializeComponent();


            /*
            this.WindowState = FormWindowState.Maximized;
            /*int screenWidth = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            Resolution objFormResizer = new Resolution();
            objFormResizer.ResizeForm(this, screenHeight, screenWidth);*/

            // Initialize the timer
            timer = new Timer();
            timer.Interval = 1000; // Set the interval in milliseconds (1000 ms = 1 second)
            timer.Tick += time_Tick;

            // Start the timer
            timer.Start();

            if (Language.SelectedLanguage == 1)
            {
                this.label1.Text = "Para acceder necesitas tu código QR personal. \r\nPuedes encontrarlo en tu App de la UGR\r\n";
                this.label3.Text = "¡Escanea tu código QR aquí!";
                this.label2.Text = "Para ir hacia atrás usa el gesto de pasar página hacia atrás";


            }
            else if (Language.SelectedLanguage == 2)
            {
                this.label1.Text = "To log in you need your personal UGR QR code. \r\nYou can find it in your UGR App profile!\r\n";
                this.label3.Text = "Scan your QR code here!";
                this.label2.Text = "To go back use the page back gesture";


            }

        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {


            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                dispositivo.Items.Add(filterInfo.Name);
            dispositivo.SelectedIndex = 0;

            captureDevice = new VideoCaptureDevice(filterInfoCollection[dispositivo.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();

        }

        private void botonStart_Click(object sender, EventArgs e)
        {

        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    txtQRcode.Text = result.ToString();
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();
                    }

                    NewHome.userLogged = result.ToString().Split('@')[0];
                    NewSchedule schedule = new NewSchedule();
                    schedule.Show();
                    this.Hide();

                }
            }
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
            hourLabel.Text = DateTime.Now.ToString("HH:mm");
            dayLabel.Text = DateTime.Now.ToString("dd.MM.yy");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closingForm()
        {
            this.Hide();
        }
    }
    /*
    public class Resolution
    {
        float heightRatio = new float();
        float widthRatio = new float();
        int standardHeight, standardWidth;
        public void ResizeForm(Form objForm, int DesignerHeight, int DesignerWidth)
        {
            standardHeight = DesignerHeight;
            standardWidth = DesignerWidth;
            int presentHeight = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;//.Bounds.Height;
            int presentWidth = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            heightRatio = (float)((float)presentHeight / (float)standardHeight);
            widthRatio = (float)((float)presentWidth / (float)standardWidth);
            objForm.AutoScaleMode = AutoScaleMode.None;
            objForm.Scale(new SizeF(widthRatio, heightRatio));
            foreach (Control c in objForm.Controls)
            {
                if (c.HasChildren)
                {
                    ResizeControlStore(c);
                }
                else
                {
                    c.Font = new Font(c.Font.FontFamily, c.Font.Size * heightRatio, c.Font.Style, c.Font.Unit, ((byte)(0)));
                }
            }
            objForm.Font = new Font(objForm.Font.FontFamily, objForm.Font.Size * heightRatio, objForm.Font.Style, objForm.Font.Unit, ((byte)(0)));
        }

        private void ResizeControlStore(Control objCtl)
        {
            if (objCtl.HasChildren)
            {
                foreach (Control cChildren in objCtl.Controls)
                {
                    if (cChildren.HasChildren)
                    {
                        ResizeControlStore(cChildren);

                    }
                    else
                    {
                        cChildren.Font = new Font(cChildren.Font.FontFamily, cChildren.Font.Size * heightRatio, cChildren.Font.Style, cChildren.Font.Unit, ((byte)(0)));
                    }
                }
                objCtl.Font = new Font(objCtl.Font.FontFamily, objCtl.Font.Size * heightRatio, objCtl.Font.Style, objCtl.Font.Unit, ((byte)(0)));
            }
            else
            {
                objCtl.Font = new Font(objCtl.Font.FontFamily, objCtl.Font.Size * heightRatio, objCtl.Font.Style, objCtl.Font.Unit, ((byte)(0)));
            }

        }
    }*/
}
