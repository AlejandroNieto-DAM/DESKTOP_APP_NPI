using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuto
{
    public partial class keyboard_screen : Form
    {
        private readonly Button[] numberButtons;
        private readonly TextBox targetTextBox;
        string letterPressed;
        string name2search = "";

        public keyboard_screen()
        {
            InitializeComponent();
            stylebuttons();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ShowKeyboardAtBottom();
            updateName();
        }

        private void ShowKeyboardAtBottom()
        {
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            // Position the form at the bottom center of the screen
            int formWidth = ClientSize.Width;
            int formHeight = ClientSize.Height;

            int formX = (screenWidth - formWidth) / 2;
            int formY = screenHeight - formHeight;

            Location = new System.Drawing.Point(formX, formY);

            // ... (rest of the code remains the same)
        }
        private void updateName()
        {
            labelName.Text = name2search;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (name2search.Length > 0)
            {
                name2search = name2search.Substring(0, name2search.Length - 1);
                updateName();
            }
        }

        public string GetName2Search()
        {
            return name2search;
        }


        private void stylebuttons()
        {
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            foreach (Button control in tableLayoutPanel1.Controls)
            {
                if (control is Button)
                {
                    Button boton = (Button)control;
                    boton.Font = new Font("Yu Gothic UI", 30, FontStyle.Bold);
                    boton.Margin = new Padding(10);
                    boton.Dock = DockStyle.Fill;

                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            letterPressed = "A";
            name2search += letterPressed;
            updateName();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            letterPressed = "B";
            name2search += letterPressed;
            updateName();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            letterPressed = "C";
            name2search += letterPressed;
            updateName();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            letterPressed = "D";
            name2search += letterPressed;
            updateName();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            letterPressed = "E";
            name2search += letterPressed;
            updateName();
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            letterPressed = "F";
            name2search += letterPressed;
            updateName();
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            letterPressed = "G";
            name2search += letterPressed;
            updateName();
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            letterPressed = "H";
            name2search += letterPressed;
            updateName();
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            letterPressed = "I";
            name2search += letterPressed;
            updateName();
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            letterPressed = "J";
            name2search += letterPressed;
            updateName();
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            letterPressed = "K";
            name2search += letterPressed;
            updateName();
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            letterPressed = "L";
            name2search += letterPressed;
            updateName();
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            letterPressed = "M";
            name2search += letterPressed;
            updateName();
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            letterPressed = "N";
            name2search += letterPressed;
            updateName();
        }

        private void buttonN2_Click(object sender, EventArgs e)
        {
            letterPressed = "Ñ";
            name2search += letterPressed;
            updateName();
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            letterPressed = "O";
            name2search += letterPressed;
            updateName();
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            letterPressed = "P";
            name2search += letterPressed;
            updateName();
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            letterPressed = "Q";
            name2search += letterPressed;
            updateName();
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            letterPressed = "R";
            name2search += letterPressed;
            updateName();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            letterPressed = "S";
            name2search += letterPressed;
            updateName();
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            letterPressed = "T";
            name2search += letterPressed;
            updateName();
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            letterPressed = "U";
            name2search += letterPressed;
            updateName();
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            letterPressed = "V";
            name2search += letterPressed;
            updateName();
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            letterPressed = "W";
            name2search += letterPressed;
            updateName();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            letterPressed = "X";
            name2search += letterPressed;
            updateName();
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            letterPressed = "Y";
            name2search += letterPressed;
            updateName();
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            letterPressed = "Z";
            name2search += letterPressed;
            updateName();
        }
    }
}

