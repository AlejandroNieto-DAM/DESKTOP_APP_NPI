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

       
        public NewSchedule()
        {
            InitializeComponent();

            if (Language.SelectedLanguage == 1)
            {
                this.label1.Text = "Bienvenido! " + NewHome.userLogged;
                this.label2.Text = "Tu proxima clase comienza en: ";
                this.label3.Text = "HOY";
                this.label4.Text = "Para ir hacia atras haz el gesto de retornar pagina";
                
                if  (NewHome.userLogged  == "Alejandro" || NewHome.userLogged == "Nieto")
                {
                    this.label11.Text = "Vision por computador";
                    this.label12.Text = "Fundamentos de Redes";
                    this.label13.Text = "Sistemas operativos";
                    this.label14.Text = "Algoritmica";
                    this.label15.Text = "Física";
                }
                else if (NewHome.userLogged == "Joel")
                {
                    this.label11.Text = "Sistemas y procesos";
                    this.label12.Text = "Diseño de interfaces";
                    this.label13.Text = "Ingenieria del conocimiento";
                    this.label14.Text = "Álgebra";
                    this.label15.Text = "Fundamentos de software";
                }
                else if (NewHome.userLogged == "Dani")
                {
                    this.label11.Text = "Estadistica";
                    this.label12.Text = "Logica y Metodos Discretos";
                    this.label13.Text = "Estructura de Datos";
                    this.label14.Text = "Inteligencia Artificial";
                    this.label15.Text = "Informática Gráfica";
                }
                else if (NewHome.userLogged == "Jolie")
                {
                    this.label11.Text = "Sistemas y procesos";
                    this.label12.Text = "Diseño de interfaces";
                    this.label13.Text = "Ingenieria del conocimiento";
                    this.label14.Text = "Álgebra";
                    this.label15.Text = "Fundamentos de software";
                }
                else if (NewHome.userLogged == "Alli")
                {
                    this.label11.Text = "Estadistica";
                    this.label12.Text = "Logica y Metodos Discretos";
                    this.label13.Text = "Estructura de Datos";
                    this.label14.Text = "Inteligencia Artificial";
                    this.label15.Text = "Informática Gráfica";
                }

            } else if(Language.SelectedLanguage == 2)
            {
                this.label1.Text = "Welcome! " + NewHome.userLogged;
                this.label3.Text = "TODAY";
                this.label4.Text = "For coming back do the return page gesture";


                if (NewHome.userLogged == "Alejandro" || NewHome.userLogged == "Nieto")
                {
                    this.label11.Text = "Computer vision";
                    this.label12.Text = "Network Fundamentals";
                    this.label13.Text = "Operating Systems";
                    this.label14.Text = "Algorithmic";
                    this.label15.Text = "Physics";
                }
                else if (NewHome.userLogged == "Joel")
                {
                    this.label11.Text = "System and processes";
                    this.label12.Text = "Interface Design";
                    this.label13.Text = "Knowledge Engineering";
                    this.label14.Text = "Algebra";
                    this.label15.Text = "Software fundamentals";
                }
                else if (NewHome.userLogged == "Dani")
                {
                    this.label11.Text = "Statistics";
                    this.label12.Text = "Logic and Discrete Methods";
                    this.label13.Text = "Data Structure";
                    this.label14.Text = "Artificial Intelligence";
                    this.label15.Text = "Computer Graphics";
                }
                else if (NewHome.userLogged == "Jolie")
                {
                    this.label11.Text = "System and processes";
                    this.label12.Text = "Interface Design";
                    this.label13.Text = "Knowledge Engineering";
                    this.label14.Text = "Algebra";
                    this.label15.Text = "Software fundamentals";
                }
                else if (NewHome.userLogged == "Alli")
                {
                    this.label11.Text = "Statistics";
                    this.label12.Text = "Logic and Discrete Methods";
                    this.label13.Text = "Data Structure";
                    this.label14.Text = "Artificial Intelligence";
                    this.label15.Text = "Computer Graphics";
                }
            }

            
            
            label1.Width = label1.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            label1.Height = label1.Height * NewHome.ScreenHeight / NewHome.FormHeight;

            label2.Width = label2.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            label2.Height = label2.Height * NewHome.ScreenHeight / NewHome.FormHeight;

            label3.Width = label3.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            label3.Height = label3.Height * NewHome.ScreenHeight / NewHome.FormHeight;

            label4.Width = label4.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            label4.Height = label4.Height * NewHome.ScreenHeight / NewHome.FormHeight;

            label6.Width = label6.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            label6.Height = label6.Height * NewHome.ScreenHeight / NewHome.FormHeight;

            label7.Width = label7.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            label7.Height = label7.Height * NewHome.ScreenHeight / NewHome.FormHeight;

            label8.Width = label8.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            label8.Height = label8.Height * NewHome.ScreenHeight / NewHome.FormHeight;

            label9.Width = label9.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            label9.Height = label9.Height * NewHome.ScreenHeight / NewHome.FormHeight;

            label10.Width = label10.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            label10.Height = label10.Height * NewHome.ScreenHeight / NewHome.FormHeight;

            label11.Width = label11.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            label11.Height = label11.Height * NewHome.ScreenHeight / NewHome.FormHeight;

            label12.Width = label12.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            label12.Height = label12.Height * NewHome.ScreenHeight / NewHome.FormHeight;

            label13.Width = label13.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            label13.Height = label13.Height * NewHome.ScreenHeight / NewHome.FormHeight;

            label14.Width = label14.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            label14.Height = label14.Height * NewHome.ScreenHeight / NewHome.FormHeight;

            label15.Width = label15.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            label15.Height = label15.Height * NewHome.ScreenHeight / NewHome.FormHeight;

          
           

            panel1.Width = panel1.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            panel1.Height = panel1.Height * NewHome.ScreenHeight / NewHome.FormHeight;

            

            tableLayoutPanel1.Width = tableLayoutPanel1.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            tableLayoutPanel1.Height = tableLayoutPanel1.Height * NewHome.ScreenHeight / NewHome.FormHeight;

            

            
            this.panel1.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, panel1.Width,
            panel1.Height, 20, 20));

            this.label11.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, label11.Width,
            label11.Height, label11.Height/3, label11.Height/3));

            this.label12.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, label12.Width,
            label12.Height, label12.Height / 3, label12.Height / 3));


            this.label13.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, label13.Width,
            label13.Height, label13.Height / 3, label13.Height / 3));

            this.label14.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, label14.Width,
            label14.Height, label14.Height / 3, label14.Height / 3));

            this.label15.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, label15.Width,
            label15.Height, label15.Height / 3, label15.Height / 3));

            this.label3.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, label3.Width,
            label3.Height, 20, 20));


        }

        private void NewSchedule_Load(object sender, EventArgs e)
        {

        }

        private void NewSchedule_Resize(object sender, EventArgs e)
        {
            this.panel1.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, panel1.Width,
           panel1.Height, 20, 20));

            this.label11.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, label11.Width,
            label11.Height, label11.Height / 3, label11.Height / 3));

            this.label12.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, label12.Width,
            label12.Height, label12.Height / 3, label12.Height / 3));


            this.label13.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, label13.Width,
            label13.Height, label13.Height / 3, label13.Height / 3));

            this.label14.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, label14.Width,
            label14.Height, label14.Height / 3, label14.Height / 3));

            this.label15.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, label15.Width,
            label15.Height, label15.Height / 3, label15.Height / 3));

            this.label3.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, label3.Width,
            label3.Height, 20, 20));

            this.label4.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, label4.Width,
            label4.Height, 20, 20));
        }
    }
}
