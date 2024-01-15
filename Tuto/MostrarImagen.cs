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


        }

        private void NewSchedule_Load(object sender, EventArgs e)
        {

        }

        private void NewSchedule_Resize(object sender, EventArgs e)
        {

        }
    }
}
