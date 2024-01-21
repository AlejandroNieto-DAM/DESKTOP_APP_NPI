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
            Language.lastForm = this;
            Language.className = "MostrarImagen";

            label1.Width = label1.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            label1.Height = label1.Height * NewHome.ScreenHeight / NewHome.FormHeight;

            label2.Width = label2.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            label2.Height = label2.Height * NewHome.ScreenHeight / NewHome.FormHeight;

            label4.Width = label4.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            label4.Height = label4.Height * NewHome.ScreenHeight / NewHome.FormHeight;


            panel1.Width = panel1.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            panel1.Height = panel1.Height * NewHome.ScreenHeight / NewHome.FormHeight;

            if (Language.SelectedLanguage == 1) { 
                if (optionSelected == 1)
                {
                    label2.Text = "Gira a la derecha y sube las escaleras para subir la 3ra planta. Una vez llegado a la tercera planta verá dos pasillos, uno a la izquierda, otro a la derecha. Consulte" +
                        "en la puerta el nombre del profesor/a que desea visitar.";
                    pictureBox1.Image = Properties.Resources.mapa_despachos_1;
                }

                if (optionSelected == 2)
                {
                    label2.Text = "Mira a la derecha y salga por la puerta hacia el exterior. Continúe el camino hacia el siguiente edificio. Una vez dentro gire a la derecha y suba por las escaleras. En la primera planta" +
                        "encontrará las clases 1.X, en la segunda las clases 2.X y en la tercera las 3.X.";
                    pictureBox1.Image = Properties.Resources.mapa_clases_1;
                }

                if (optionSelected == 3)
                {
                    label2.Text = "Mira a la derecha y salga por la puerta hacia el exterior. Continúe el camino hacia el siguiente edificio. Una vez dentro a la izquierda y a la derecha encontrará las clases 0.X no suba las escaleras" +
                        "o el ascensor.";
                    pictureBox1.Image = Properties.Resources.mapa_clases_1;
                }

                if (optionSelected == 4)
                {
                    label2.Text = "Gira a la derecha y antes de salir por la puerta que da al exterior baje por las escaleras que bajan a la planta inferior. Justo al bajar verá la cafetería y a la derecha el comedor.";
                    pictureBox1.Image = Properties.Resources.mapa_comedor_1;
                }

                if (optionSelected == 5)
                {
                    label2.Text = "A la izquierda puede ver un punto donde pedir ayuda. Si quiere ir al otro debido a que no hay gente debera salir por la puerta que ve a la derecha que da al exterior y continuar el camino hacia" +
                        "el siguiente edificio. Una vez dentro justo a la izquierda lo encontrará.";
                    pictureBox1.Image = Properties.Resources.mapa_informacion_1;
                }

            } else if (Language.SelectedLanguage == 2) {

                if (optionSelected == 1)
                {
                    label2.Text = "Turn right and go up the stairs to the 3rd floor. Once you reach the third floor you will see two corridors, one on the left, one on the right. Consult" +
                    "on the door the name of the teacher you wish to visit.";
                    pictureBox1.Image = Properties.Resources.mapa_despachos_1;
                }

                if (optionSelected == 2)
                {
                    label2.Text = "Look to the right and exit through the door to the outside. Continue the path to the next building. Once inside, turn right and go up the stairs. On the first floor you will find classes 1.X, on the second you will find classes 2.X and on the third you will find 3.X.";
                    pictureBox1.Image = Properties.Resources.mapa_clases_1;
                }

                if (optionSelected == 3)
                {
                    label2.Text = "Look to the right and exit through the door to the outside. Continue the path to the next building. Once inside on the left and right you will find classes 0.X do not go up the stairs or the elevator.";
                    pictureBox1.Image = Properties.Resources.mapa_clases_1;
                }

                if (optionSelected == 4)
                {
                    label2.Text = "Turn right and before leaving through the door that leads outside, go down the stairs that go down to the lower floor. Just as you go down you will see the cafeteria and to the right the dining room.";
                    pictureBox1.Image = Properties.Resources.mapa_comedor_1;
                }

                if (optionSelected == 5)
                {
                    label2.Text = "On the left you can see a point where you can ask for help. If you want to go to the other one because there are no people, you should go out through the door that you see on the right that leads to the outside and continue the path towards the next building. Once inside, just to the left you will find it.";
                    pictureBox1.Image = Properties.Resources.mapa_informacion_1;
                }

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
            this.label2.Font = new Font("Yu Gothic UI", this.label2.Font.Size * (ScreenHeight / FormHeight));

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

        public void close_Form()
        {
            this.Hide();
            Locations nh = new Locations();
            nh.Show();
        }
    }
}
