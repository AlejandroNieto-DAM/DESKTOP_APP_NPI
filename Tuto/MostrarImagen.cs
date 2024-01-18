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
    public partial class MostrarImagen : Form
    {

        public static int optionSelected = 0;

        public MostrarImagen()
        {
            InitializeComponent();

            label1.Width = label1.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            label1.Height = label1.Height * NewHome.ScreenHeight / NewHome.FormHeight;

            label2.Width = label2.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            label2.Height = label2.Height * NewHome.ScreenHeight / NewHome.FormHeight;

            label4.Width = label4.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            label4.Height = label4.Height * NewHome.ScreenHeight / NewHome.FormHeight;


            panel1.Width = panel1.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            panel1.Height = panel1.Height * NewHome.ScreenHeight / NewHome.FormHeight;

            if (optionSelected == 1)
            {
                pictureBox1.Image = Properties.Resources.mapa_despachos;
            }

            if (optionSelected == 2)
            {
                pictureBox1.Image = Properties.Resources.mapa_clases;
            }

            if (optionSelected == 3)
            {
                pictureBox1.Image = Properties.Resources.mapa_clases;
            }

            if (optionSelected == 4)
            {
                pictureBox1.Image = Properties.Resources.mapa_comedor;
            }

            if (optionSelected == 5)
            {
                pictureBox1.Image = Properties.Resources.mapa_informacion;
            }

            int ScreenWidth = NewHome.ScreenWidth;
            int FormWidth = NewHome.FormWidth;
            int ScreenHeight = NewHome.ScreenHeight;
            int FormHeight = NewHome.FormHeight;

           // this.label1.Margin = new Padding(this.label1.Margin.Left * ScreenWidth / FormWidth, this.label1.Margin.Top * ScreenHeight / FormHeight, this.label1.Margin.Right * ScreenWidth / FormWidth, this.label1.Margin.Bottom * ScreenHeight / FormHeight);
            //this.label1.Padding = new Padding(this.label1.Padding.Left * ScreenWidth / FormWidth, this.label1.Padding.Top * ScreenHeight / FormHeight, this.label1.Padding.Right * ScreenWidth / FormWidth, this.label1.Padding.Bottom * ScreenHeight / FormHeight);
            this.label1.Font = new Font("Yu Gothic UI", this.label1.Font.Size * (ScreenHeight / FormHeight), FontStyle.Bold);

            //this.label2.Width = this.label2.Width * ScreenWidth / FormWidth;
            //this.label2.Margin = new Padding(this.label2.Margin.Left * ScreenWidth / FormWidth, this.label2.Margin.Top * ScreenHeight / FormHeight, this.label2.Margin.Right * ScreenWidth / FormWidth, this.label2.Margin.Bottom * ScreenHeight / FormHeight);
            this.label2.Font = new Font("Yu Gothic UI", this.label2.Font.Size * (ScreenHeight / FormHeight), FontStyle.Bold);

            //this.label4.Margin = new Padding(this.label4.Margin.Left * ScreenWidth / FormWidth, this.label4.Margin.Top * ScreenHeight / FormHeight, this.label4.Margin.Right * ScreenWidth / FormWidth, this.label4.Margin.Bottom * ScreenHeight / FormHeight);
            //this.label4.Padding = new Padding(this.label4.Padding.Left * ScreenWidth / FormWidth, this.label4.Padding.Top * ScreenHeight / FormHeight, this.label4.Padding.Right * ScreenWidth / FormWidth, this.label4.Padding.Bottom * ScreenHeight / FormHeight);
            this.label4.Font = new Font("Yu Gothic UI", this.label4.Font.Size * (ScreenHeight / FormHeight), FontStyle.Bold);

            this.pictureBox1.Height = this.pictureBox1.Height * NewHome.ScreenHeight / NewHome.FormHeight;
            this.pictureBox1.Width = this.pictureBox1.Width * ScreenWidth / FormWidth;
            this.pictureBox1.Margin = new Padding(this.pictureBox1.Margin.Left * ScreenWidth / FormWidth, this.pictureBox1.Margin.Top * ScreenHeight / FormHeight, this.pictureBox1.Margin.Right * ScreenWidth / FormWidth, this.pictureBox1.Margin.Bottom * ScreenHeight / FormHeight);
            this.pictureBox1.Padding = new Padding(this.pictureBox1.Padding.Left * ScreenWidth / FormWidth, this.pictureBox1.Padding.Top * ScreenHeight / FormHeight, this.pictureBox1.Padding.Right * ScreenWidth / FormWidth, this.pictureBox1.Padding.Bottom * ScreenHeight / FormHeight);

            this.panel1.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            this.label4.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, label4.Width, label4.Height, 20, 20));

        }

        private void NewSchedule_Load(object sender, EventArgs e)
        {

        }

        private void NewSchedule_Resize(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Resize(object sender, EventArgs e)
        {

            this.panel1.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            this.label4.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, label4.Width, label4.Height, 20, 20));

        }
    }
}
