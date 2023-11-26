using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuto
{
    public partial class NewSchedule : Form
    {

        private int height = 2100;
        private int width = 1080;

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

        public NewSchedule()
        {
            InitializeComponent();

            /*
            
            label1.Width = label1.Width * width / 540;
            label1.Height = label1.Height * height / 960;

            label2.Width = label2.Width * width / 540;
            label2.Height = label2.Height * height / 960;

            label3.Width = label3.Width * width / 540;
            label3.Height = label3.Height * height / 960;

            label4.Width = label4.Width * width / 540;
            label4.Height = label4.Height * height / 960;

            label6.Width = label6.Width * width / 540;
            label6.Height = label6.Height * height / 960;

            label7.Width = label7.Width * width / 540;
            label7.Height = label7.Height * height / 960;

            label8.Width = label8.Width * width / 540;
            label8.Height = label8.Height * height / 960;

            label9.Width = label9.Width * width / 540;
            label9.Height = label9.Height * height / 960;

            label10.Width = label10.Width * width / 540;
            label10.Height = label10.Height * height / 960;

            label11.Width = label11.Width * width / 540;
            label11.Height = label11.Height * height / 960;

            label12.Width = label12.Width * width / 540;
            label12.Height = label12.Height * height / 960;

            label13.Width = label13.Width * width / 540;
            label13.Height = label13.Height * height / 960;

            label14.Width = label14.Width * width / 540;
            label14.Height = label14.Height * height / 960;

            label15.Width = label15.Width * width / 540;
            label15.Height = label15.Height * height / 960;

          
           

            panel1.Width = panel1.Width * width / 540;
            panel1.Height = panel1.Height * height / 960;

            

            tableLayoutPanel1.Width = tableLayoutPanel1.Width * width / 540;
            tableLayoutPanel1.Height = tableLayoutPanel1.Height * height / 960;

            */

            this.panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width,
            panel1.Height, 20, 20));

            this.label11.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, label11.Width,
            label11.Height, label11.Height/3, label11.Height/3));

            this.label12.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, label12.Width,
            label12.Height, label12.Height / 3, label12.Height / 3));


            this.label13.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, label13.Width,
            label13.Height, label13.Height / 3, label13.Height / 3));

            this.label14.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, label14.Width,
            label14.Height, label14.Height / 3, label14.Height / 3));

            this.label15.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, label15.Width,
            label15.Height, label15.Height / 3, label15.Height / 3));

        }

        private void NewSchedule_Load(object sender, EventArgs e)
        {

        }
    }
}
