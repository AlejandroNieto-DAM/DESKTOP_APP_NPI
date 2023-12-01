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
    public partial class NewHome : Form
    {

        public static String userLogged = "";
        public static int ScreenHeight = 1920, ScreenWidth = 1440, FormHeight = 960, FormWidth = 540;

        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy,
                      int dwData, int dwExtraInfo);

        [Flags]
        public enum MouseEventFlags
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010
        }

        public static void LeftClick(int x, int y)
        {
            Cursor.Position = new System.Drawing.Point(x, y);
            mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
            mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public NewHome()
        {
            InitializeComponent();

            if (Language.SelectedLanguage == 1)
            {
                this.label3.Text = "Bienvenido! Escoge una opción entre las siguientes";
                this.label5.Text = "Mi horario personal";
                this.label6.Text = "Menu del comedor";
                this.label7.Text = "Informacion del profesorado";
                this.label8.Text = "Peticiones administrativas";
                this.label4.Text = "Localizaciones";
                this.label9.Text = "Para ir hacia atrás usa el gesto de pasar página hacia atrás";
            }
            else if (Language.SelectedLanguage == 2)
            {
                this.label3.Text = "Welcome! Select an option of the following";
                this.label5.Text = "My personal horario";
                this.label6.Text = "Canteen menu";
                this.label7.Text = "Teacher information";
                this.label8.Text = "Administrative petitions";
                this.label4.Text = "Locations";
                this.label9.Text = "To go back use the page back gesture";
            }


            this.label1.Font = new Font("Yu Gothic UI", this.label1.Font.Size + (ScreenHeight / FormHeight), FontStyle.Bold);
            this.label2.Font = new Font("Yu Gothic UI", this.label2.Font.Size + (ScreenHeight / FormHeight), FontStyle.Bold);

            this.label3.Font = new Font("Yu Gothic UI", this.label3.Font.Size + (ScreenHeight / FormHeight), FontStyle.Bold);

            this.tableLayoutPanel1.Height = this.tableLayoutPanel1.Height * ScreenHeight / FormHeight;

            this.panel2.Height =  this.panel2.Height * ScreenHeight / FormHeight;
            this.panel2.Width =  this.panel2.Width * ScreenWidth / FormWidth;
            this.panel2.Margin = new Padding(this.panel2.Margin.Left * ScreenWidth / FormWidth, this.panel2.Margin.Top * ScreenHeight / FormHeight, this.panel2.Margin.Right * ScreenWidth / FormWidth, this.panel2.Margin.Bottom * ScreenHeight / FormHeight);
            this.panel2.Padding = new Padding(this.panel2.Padding.Left * ScreenWidth / FormWidth, this.panel2.Padding.Top * ScreenHeight / FormHeight, this.panel2.Padding.Right * ScreenWidth / FormWidth, this.panel2.Padding.Bottom * ScreenHeight / FormHeight);
            this.pictureBox1.Height = this.pictureBox1.Height * ScreenHeight / FormHeight;
            this.pictureBox1.Width = this.pictureBox1.Width * ScreenWidth / FormWidth;
            this.label5.Height = this.label5.Height * ScreenHeight / FormHeight;
            this.label5.Width = this.label5.Width * ScreenWidth / FormWidth;
            this.label5.Font = new Font("Yu Gothic UI", this.label5.Font.Size + (ScreenHeight / FormHeight), FontStyle.Bold);


            this.panel3.Height = this.panel3.Height * ScreenHeight / FormHeight;
            this.panel3.Width = this.panel3.Width * ScreenWidth / FormWidth;
            this.panel3.Margin = new Padding(this.panel3.Margin.Left * ScreenWidth / FormWidth, this.panel3.Margin.Top * ScreenHeight / FormHeight, this.panel3.Margin.Right * ScreenWidth / FormWidth, this.panel3.Margin.Bottom * ScreenHeight / FormHeight);
            this.panel3.Padding = new Padding(this.panel3.Padding.Left * ScreenWidth / FormWidth, this.panel3.Padding.Top * ScreenHeight / FormHeight, this.panel3.Padding.Right * ScreenWidth / FormWidth, this.panel3.Padding.Bottom * ScreenHeight / FormHeight);
            this.pictureBox2.Height = this.pictureBox2.Height * ScreenHeight / FormHeight;
            this.pictureBox2.Width = this.pictureBox2.Width * ScreenWidth / FormWidth;
            this.label6.Height = this.label6.Height * ScreenHeight / FormHeight;
            this.label6.Width = this.label6.Width * ScreenWidth / FormWidth;
            this.label6.Font = new Font("Yu Gothic UI", this.label6.Font.Size + (ScreenHeight / FormHeight), FontStyle.Bold);

            this.panel4.Height = this.panel4.Height * ScreenHeight / FormHeight;
            this.panel4.Width = this.panel4.Width * ScreenWidth / FormWidth;
            this.panel4.Margin = new Padding(this.panel4.Margin.Left * ScreenWidth / FormWidth, this.panel4.Margin.Top * ScreenHeight / FormHeight, this.panel4.Margin.Right * ScreenWidth / FormWidth, this.panel4.Margin.Bottom * ScreenHeight / FormHeight);
            this.panel4.Padding = new Padding(this.panel4.Padding.Left * ScreenWidth / FormWidth, this.panel4.Padding.Top * ScreenHeight / FormHeight, this.panel4.Padding.Right * ScreenWidth / FormWidth, this.panel4.Padding.Bottom * ScreenHeight / FormHeight);
            this.pictureBox3.Height = this.pictureBox3.Height * ScreenHeight / FormHeight;
            this.pictureBox3.Width = this.pictureBox3.Width * ScreenWidth / FormWidth;
            this.label7.Height = this.label7.Height * ScreenHeight / FormHeight;
            this.label7.Width = this.label7.Width * ScreenWidth / FormWidth;
            this.label7.Font = new Font("Yu Gothic UI", this.label7.Font.Size + (ScreenHeight / FormHeight), FontStyle.Bold);

            this.panel5.Height = this.panel5.Height * ScreenHeight / FormHeight;
            this.panel5.Width = this.panel5.Width * ScreenWidth / FormWidth;
            this.panel5.Margin = new Padding(this.panel5.Margin.Left * ScreenWidth / FormWidth, this.panel5.Margin.Top * ScreenHeight / FormHeight, this.panel5.Margin.Right * ScreenWidth / FormWidth, this.panel5.Margin.Bottom * ScreenHeight / FormHeight);
            this.panel5.Padding = new Padding(this.panel5.Padding.Left * ScreenWidth / FormWidth, this.panel5.Padding.Top * ScreenHeight / FormHeight, this.panel5.Padding.Right * ScreenWidth / FormWidth, this.panel5.Padding.Bottom * ScreenHeight / FormHeight);
            this.pictureBox4.Height = this.pictureBox4.Height * ScreenHeight / FormHeight;
            this.pictureBox4.Width = this.pictureBox4.Width * ScreenWidth / FormWidth;
            this.label8.Height = this.label8.Height * ScreenHeight / FormHeight;
            this.label8.Width = this.label8.Width * ScreenWidth / FormWidth;
            this.label8.Font = new Font("Yu Gothic UI", this.label8.Font.Size + (ScreenHeight / FormHeight), FontStyle.Bold);


            this.tableLayoutPanel2.Height = this.tableLayoutPanel2.Height * ScreenHeight / FormHeight;

            this.tableLayoutPanel3.Height = this.tableLayoutPanel3.Height * ScreenHeight / FormHeight;

            this.pictureBox5.Height = this.pictureBox5.Height * ScreenHeight / FormHeight;
            this.pictureBox5.Width = this.pictureBox5.Width * ScreenWidth / FormWidth;
            this.label4.Height = this.label4.Height * ScreenHeight / FormHeight;
            this.label4.Width = this.label4.Width * ScreenWidth / FormWidth;
            this.label4.Font = new Font("Yu Gothic UI", this.label4.Font.Size + (ScreenHeight / FormHeight), FontStyle.Bold);

        
            this.label9.Height = this.label9.Height * ScreenHeight / FormHeight;
            this.label9.Width = this.label9.Width * ScreenWidth / FormWidth;
            this.label9.Font = new Font("Yu Gothic UI", this.label9.Font.Size + (ScreenHeight / FormHeight), FontStyle.Bold);

            
            this.panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width,
            panel2.Height, 20, 20));
            
            this.panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width,
            panel3.Height, 20, 20));
            this.panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width,
            panel4.Height, 20, 20));
            this.panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width,
            panel5.Height, 20, 20));
            this.tableLayoutPanel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel3.Width,
            tableLayoutPanel3.Height, 20, 20));

        }

        private void NewHome_Resize(object sender, EventArgs e)
        {
            this.panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width,
            panel2.Height, 20, 20));
            this.panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width,
            panel3.Height, 20, 20));
            this.panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width,
            panel4.Height, 20, 20));
            this.panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width,
            panel5.Height, 20, 20));
            this.tableLayoutPanel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel3.Width,
            tableLayoutPanel3.Height, 20, 20));
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            this.panel3.BackColor = Color.FromArgb(236, 204, 69);     
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            this.panel3.BackColor = Color.Snow;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            this.panel3.BackColor = Color.FromArgb(236, 204, 69);
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            this.panel3.BackColor = Color.FromArgb(236, 204, 69);
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            this.panel2.BackColor = Color.FromArgb(236, 204, 69);
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            this.panel2.BackColor = Color.Snow;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.panel2.BackColor = Color.FromArgb(236, 204, 69);
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            this.panel2.BackColor = Color.FromArgb(236, 204, 69);
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            this.panel4.BackColor = Color.FromArgb(236, 204, 69);
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            this.panel4.BackColor = Color.Snow;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            this.panel4.BackColor = Color.FromArgb(236, 204, 69);
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            this.panel4.BackColor = Color.FromArgb(236, 204, 69);
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            this.panel5.BackColor = Color.FromArgb(236, 204, 69);
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            this.panel5.BackColor = Color.Snow;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            this.panel5.BackColor = Color.FromArgb(236, 204, 69);
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            this.panel5.BackColor = Color.FromArgb(236, 204, 69);
        }

        private void tableLayoutPanel3_MouseHover(object sender, EventArgs e)
        {
            this.tableLayoutPanel3.BackColor = Color.FromArgb(236, 204, 69);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Form2 qrForm = new Form2();
            qrForm.Show();
            this.Hide();
        }

        private void tableLayoutPanel3_MouseLeave(object sender, EventArgs e)
        {
            this.tableLayoutPanel3.BackColor = Color.Snow;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            this.tableLayoutPanel3.BackColor = Color.FromArgb(236, 204, 69);
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            this.tableLayoutPanel3.BackColor = Color.FromArgb(236, 204, 69);
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            adminOptions homeWindow = new adminOptions();
            homeWindow.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MenuComedor horarioV = new MenuComedor();
            horarioV.Show();
            this.Hide();
        }
    }
}
