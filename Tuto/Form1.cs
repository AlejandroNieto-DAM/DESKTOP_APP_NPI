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
using Leap;

namespace Tuto
{

    public partial class Form1 : Form
    {

        private Controller controller;
        private long currentTime;
        private long previousTime;
        private long timeChange;
        private int waitUntilMoveCursor;

        public Form1()
        {
            InitializeComponent();
         
          

            
        }
        


        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Green;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Transparent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonQR_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminOptions homeWindow = new adminOptions();
            homeWindow.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.richTextBox1.AppendText("Hemos clickado" + Environment.NewLine);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Language horarioV = new Language();
            horarioV.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewHome horarioV = new NewHome();
            horarioV.Show();
            this.Hide();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.S)
            {
                this.richTextBox2.AppendText("Pulsado S" + Environment.NewLine);
                //
            }
            else if (e.KeyCode == Keys.L)
            {
                //Some Other Code
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NewSchedule horarioV = new NewSchedule();
            horarioV.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MenuComedor menuCom = new MenuComedor();
            menuCom.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Locations menuCom = new Locations();
            menuCom.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MostrarImagen menuCom = new MostrarImagen();
            menuCom.Show();
            this.Hide();
        }
    }


}


