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
    public partial class Horario : Form
    {

        int labelScaleX;
        int labelScaleY;
        int label2ScaleX;
        int label2ScaleY;
        int label3ScaleX;
        int label3ScaleY;
        int panelScaleX;
        int panelScaleY;
        int panel2ScaleX;
        int panel2ScaleY;
        int panel6ScaleX;
        int panel6ScaleY;
        int tableScaleX;
        int tableScaleY;
        int distanceBtwLabel1Panel;

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

        public Horario()
        {



            InitializeComponent();

            /*
            labelScaleX = label1.Width;
            labelScaleY = label1.Height;

       

            label3ScaleX = label3.Width;
            label3ScaleY = label3.Height;



            panel6ScaleX = panel6.Width;
            panel6ScaleY = panel6.Height;

            panel2ScaleX = panel2.Width;
            panel2ScaleY = panel2.Height;

            tableScaleX = tableLayoutPanel1.Width;
            tableScaleY = tableLayoutPanel1.Height;


            int heightRel = 2560; //2560
            int widthRel = 1440; //1440


            this.label1.Width = labelScaleX * widthRel / 540;
            this.label1.Height = labelScaleY * heightRel / 960;



            this.label3.Width = label3ScaleX * widthRel / 540;
            this.label3.Height = label3ScaleY * heightRel / 960;

            this.panel2.Width = panel2ScaleX * widthRel / 540;
            this.panel2.Height = panel2ScaleY * heightRel / 960;
            this.panel6.Width = panel6ScaleX * widthRel / 540;
            this.panel6.Height = panel6ScaleY * heightRel / 960;
            this.tableLayoutPanel1.Width = tableScaleX * widthRel / 540;
            this.tableLayoutPanel1.Height = tableScaleY * heightRel / 960;


            this.label3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, label3.Width,
            label3.Height, 10, 10));

            this.panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width,
            panel2.Height, 10, 10));


            this.tableLayoutPanel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel1.Width,
            tableLayoutPanel1.Height, 10, 10));

            this.Refresh();

            */
        }


        private void Horario_ResizeEnd(object sender, EventArgs e)
        {






            this.label3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, label3.Width,
            label3.Height, 30, 30));

            this.panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width,
            panel2.Height, 30, 30));


            this.tableLayoutPanel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel1.Width,
            tableLayoutPanel1.Height, 30, 30));


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
