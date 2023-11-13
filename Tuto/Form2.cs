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

namespace Tuto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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
        }

        private void botonStart_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[dispositivo.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame (object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image =(Bitmap)eventArgs.Frame.Clone();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(captureDevice.IsRunning)
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
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1 ();
            f1.Show();
            this.Close();   //cerrar ventana para que la camara no siga abierta
        }
    }
}
