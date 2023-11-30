using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuto
{
    public partial class Language : Form
    {
        public static int SelectedLanguage = -1;
        public Language()
        {
            InitializeComponent();

            this.label1.Height = this.label1.Height * NewHome.ScreenHeight / NewHome.FormHeight;
            this.label1.Width = this.label1.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            this.label1.Font = new Font("Yu Gothic UI", this.label1.Font.Size + (NewHome.ScreenHeight / NewHome.FormHeight), FontStyle.Bold);

            this.tableLayoutPanel1.Height = this.tableLayoutPanel1.Height * NewHome.ScreenHeight / NewHome.FormHeight;
            
            this.panel1.Height = this.panel1.Height * NewHome.ScreenHeight / NewHome.FormHeight;
            this.panel1.Width = this.panel1.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            this.panel1.Margin = new Padding(this.panel1.Margin.Left * NewHome.ScreenWidth / NewHome.FormWidth, this.panel1.Margin.Top * NewHome.ScreenHeight / NewHome.FormHeight, this.panel1.Margin.Right * NewHome.ScreenWidth / NewHome.FormWidth, this.panel1.Margin.Bottom * NewHome.ScreenHeight / NewHome.FormHeight);
            this.panel1.Padding = new Padding(this.panel1.Padding.Left * NewHome.ScreenWidth / NewHome.FormWidth, this.panel1.Padding.Top * NewHome.ScreenHeight / NewHome.FormHeight, this.panel1.Padding.Right * NewHome.ScreenWidth / NewHome.FormWidth, this.panel1.Padding.Bottom * NewHome.ScreenHeight / NewHome.FormHeight);
            this.pictureBox1.Height = this.pictureBox1.Height * NewHome.ScreenHeight / NewHome.FormHeight;
            this.label2.Height = this.label2.Height * NewHome.ScreenHeight / NewHome.FormHeight;
            this.label2.Width = this.label2.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            this.label2.Font = new Font("Yu Gothic UI", this.label2.Font.Size + (NewHome.ScreenHeight / NewHome.FormHeight), FontStyle.Bold);

            this.panel2.Height = this.panel2.Height * NewHome.ScreenHeight / NewHome.FormHeight;
            this.panel2.Width = this.panel2.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            this.panel2.Margin = new Padding(this.panel2.Margin.Left * NewHome.ScreenWidth / NewHome.FormWidth, this.panel2.Margin.Top * NewHome.ScreenHeight / NewHome.FormHeight, this.panel2.Margin.Right * NewHome.ScreenWidth / NewHome.FormWidth, this.panel2.Margin.Bottom * NewHome.ScreenHeight / NewHome.FormHeight);
            this.panel2.Padding = new Padding(this.panel2.Padding.Left * NewHome.ScreenWidth / NewHome.FormWidth, this.panel2.Padding.Top * NewHome.ScreenHeight / NewHome.FormHeight, this.panel2.Padding.Right * NewHome.ScreenWidth / NewHome.FormWidth, this.panel2.Padding.Bottom * NewHome.ScreenHeight / NewHome.FormHeight);
            this.pictureBox2.Height = this.pictureBox2.Height * NewHome.ScreenHeight / NewHome.FormHeight;
            this.label3.Height = this.label3.Height * NewHome.ScreenHeight / NewHome.FormHeight;
            this.label3.Width = this.label3.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            this.label3.Font = new Font("Yu Gothic UI", this.label3.Font.Size + (NewHome.ScreenHeight / NewHome.FormHeight), FontStyle.Bold);


            this.panel1.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, panel2.Width,
            panel1.Height, 20, 20));
            this.panel2.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, panel2.Width,
            panel2.Height, 20, 20));
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.FromArgb(236, 204, 69);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.Snow;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            this.panel2.BackColor = Color.FromArgb(236, 204, 69);
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            this.panel2.BackColor = Color.Snow;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Language.SelectedLanguage = 1;
            NewHome home = new NewHome();
            home.Show();
            this.Hide();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Language.SelectedLanguage = 2;
            NewHome home = new NewHome();
            home.Show();
            this.Hide();
        }

        private void Language_Resize(object sender, EventArgs e)
        {
            this.panel1.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, panel2.Width,
            panel1.Height, 20, 20));
            this.panel2.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, panel2.Width,
            panel2.Height, 20, 20));
        }
    }
}
