﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuto
{
    public partial class Locations : Form
    {
        
        public Locations()
        {
            InitializeComponent();

            Language.lastForm = this;
            Language.className = "Locations";


            int ScreenWidth = NewHome.ScreenWidth;
            int FormWidth = NewHome.FormWidth;
            int ScreenHeight = NewHome.ScreenHeight;
            int FormHeight = NewHome.FormHeight;

           if (Language.SelectedLanguage == 1)
            {
                this.label3.Text = "¿A dónde quiere ir?";
                this.label5.Text = "Despachos";
                this.label6.Text = "Laboratorios";
                this.label7.Text = "Clases";
                this.label8.Text = "Comedor";
                this.label4.Text = "Ayuda";
            }
            else if (Language.SelectedLanguage == 2)
            {
                this.label3.Text = "Where do you want to go?";
                this.label5.Text = "Offices";
                this.label6.Text = "Laboratories";
                this.label7.Text = "Class";
                this.label8.Text = "DiningRoom";
                this.label4.Text = "Help";
            }


            this.label1.Height = this.label1.Height * ScreenHeight / FormHeight;
            this.label1.Width = this.label1.Width * ScreenWidth / FormWidth;
            this.label1.Font = new Font("Yu Gothic UI", this.label1.Font.Size * (ScreenHeight / FormHeight), FontStyle.Bold);
            this.label2.Height = this.label2.Height * ScreenHeight / FormHeight;
            this.label2.Width = this.label2.Width * ScreenWidth / FormWidth;
            this.label2.Font = new Font("Yu Gothic UI", this.label2.Font.Size * (ScreenHeight / FormHeight), FontStyle.Bold);

            this.label3.Height = this.label3.Height * ScreenHeight / FormHeight;
            this.label3.Width = this.label3.Width * ScreenWidth / FormWidth;
            this.label3.Font = new Font("Cooper Black", this.label3.Font.Size * (ScreenHeight / FormHeight), FontStyle.Bold);

            this.panel1.Height = this.panel1.Height * ScreenHeight / FormHeight;
            this.panel1.Width = this.panel1.Width * ScreenWidth / FormWidth;

            this.tableLayoutPanel1.Height = this.tableLayoutPanel1.Height * NewHome.ScreenHeight / NewHome.FormHeight;

            this.tableLayoutPanel3.Height = this.tableLayoutPanel3.Height * NewHome.ScreenHeight / NewHome.FormHeight;
            this.tableLayoutPanel3.Width = this.tableLayoutPanel3.Width * ScreenWidth / FormWidth;
            this.tableLayoutPanel3.Margin = new Padding(this.tableLayoutPanel3.Margin.Left * ScreenWidth / FormWidth, this.tableLayoutPanel3.Margin.Top * ScreenHeight / FormHeight, this.tableLayoutPanel3.Margin.Right * ScreenWidth / FormWidth, this.tableLayoutPanel3.Margin.Bottom * ScreenHeight / FormHeight);
            this.tableLayoutPanel3.Padding = new Padding(this.tableLayoutPanel3.Padding.Left * ScreenWidth / FormWidth, this.tableLayoutPanel3.Padding.Top * ScreenHeight / FormHeight, this.tableLayoutPanel3.Padding.Right * ScreenWidth / FormWidth, this.tableLayoutPanel3.Padding.Bottom * ScreenHeight / FormHeight);


            this.panel2.Height =  this.panel2.Height * NewHome.ScreenHeight / NewHome.FormHeight;
            this.panel2.Width =  this.panel2.Width * ScreenWidth / FormWidth;
            this.panel2.Margin = new Padding(this.panel2.Margin.Left * ScreenWidth / FormWidth, this.panel2.Margin.Top * ScreenHeight / FormHeight, this.panel2.Margin.Right * ScreenWidth / FormWidth, this.panel2.Margin.Bottom * ScreenHeight / FormHeight);
            this.panel2.Padding = new Padding(this.panel2.Padding.Left * ScreenWidth / FormWidth, this.panel2.Padding.Top * ScreenHeight / FormHeight, this.panel2.Padding.Right * ScreenWidth / FormWidth, this.panel2.Padding.Bottom * ScreenHeight / FormHeight);
            this.pictureBox1.Height = this.pictureBox1.Height * ScreenHeight / FormHeight;
            this.pictureBox1.Width = this.pictureBox1.Width * ScreenWidth / FormWidth;
            this.label5.Height = this.label5.Height * ScreenHeight / FormHeight;
            this.label5.Width = this.label5.Width * ScreenWidth / FormWidth;
            this.label5.Font = new Font("Yu Gothic UI", this.label5.Font.Size * (ScreenHeight / FormHeight));


            this.panel3.Height = this.panel3.Height * ScreenHeight / FormHeight;
            this.panel3.Width = this.panel3.Width * ScreenWidth / FormWidth;
            this.panel3.Margin = new Padding(this.panel3.Margin.Left * ScreenWidth / FormWidth, this.panel3.Margin.Top * ScreenHeight / FormHeight, this.panel3.Margin.Right * ScreenWidth / FormWidth, this.panel3.Margin.Bottom * ScreenHeight / FormHeight);
            this.panel3.Padding = new Padding(this.panel3.Padding.Left * ScreenWidth / FormWidth, this.panel3.Padding.Top * ScreenHeight / FormHeight, this.panel3.Padding.Right * ScreenWidth / FormWidth, this.panel3.Padding.Bottom * ScreenHeight / FormHeight);
            this.pictureBox2.Height = this.pictureBox2.Height * ScreenHeight / FormHeight;
            this.pictureBox2.Width = this.pictureBox2.Width * ScreenWidth / FormWidth;
            this.label6.Height = this.label6.Height * ScreenHeight / FormHeight;
            this.label6.Width = this.label6.Width * ScreenWidth / FormWidth;
            this.label6.Font = new Font("Yu Gothic UI", this.label6.Font.Size * (ScreenHeight / FormHeight));

            this.panel4.Height = this.panel4.Height * ScreenHeight / FormHeight;
            this.panel4.Width = this.panel4.Width * ScreenWidth / FormWidth;
            this.panel4.Margin = new Padding(this.panel4.Margin.Left * ScreenWidth / FormWidth, this.panel4.Margin.Top * ScreenHeight / FormHeight, this.panel4.Margin.Right * ScreenWidth / FormWidth, this.panel4.Margin.Bottom * ScreenHeight / FormHeight);
            this.panel4.Padding = new Padding(this.panel4.Padding.Left * ScreenWidth / FormWidth, this.panel4.Padding.Top * ScreenHeight / FormHeight, this.panel4.Padding.Right * ScreenWidth / FormWidth, this.panel4.Padding.Bottom * ScreenHeight / FormHeight);
            this.pictureBox3.Height = this.pictureBox3.Height * ScreenHeight / FormHeight;
            this.pictureBox3.Width = this.pictureBox3.Width * ScreenWidth / FormWidth;
            this.label7.Height = this.label7.Height * ScreenHeight / FormHeight;
            this.label7.Width = this.label7.Width * ScreenWidth / FormWidth;
            this.label7.Font = new Font("Yu Gothic UI", this.label7.Font.Size * (ScreenHeight / FormHeight));

            this.panel5.Height = this.panel5.Height * ScreenHeight / FormHeight;
            this.panel5.Width = this.panel5.Width * ScreenWidth / FormWidth;
            this.panel5.Margin = new Padding(this.panel5.Margin.Left * ScreenWidth / FormWidth, this.panel5.Margin.Top * ScreenHeight / FormHeight, this.panel5.Margin.Right * ScreenWidth / FormWidth, this.panel5.Margin.Bottom * ScreenHeight / FormHeight);
            this.panel5.Padding = new Padding(this.panel5.Padding.Left * ScreenWidth / FormWidth, this.panel5.Padding.Top * ScreenHeight / FormHeight, this.panel5.Padding.Right * ScreenWidth / FormWidth, this.panel5.Padding.Bottom * ScreenHeight / FormHeight);
            this.pictureBox4.Height = this.pictureBox4.Height * ScreenHeight / FormHeight;
            this.pictureBox4.Width = this.pictureBox4.Width * ScreenWidth / FormWidth;
            this.label8.Height = this.label8.Height * ScreenHeight / FormHeight;
            this.label8.Width = this.label8.Width * ScreenWidth / FormWidth;
            this.label8.Font = new Font("Yu Gothic UI", this.label8.Font.Size * (ScreenHeight / FormHeight));


            this.tableLayoutPanel2.Height = this.tableLayoutPanel2.Height * ScreenHeight / FormHeight;

            this.tableLayoutPanel3.Height = this.tableLayoutPanel3.Height * ScreenHeight / FormHeight;

            this.pictureBox5.Height = this.pictureBox5.Height * ScreenHeight / FormHeight;
            this.pictureBox5.Width = this.pictureBox5.Width * ScreenWidth / FormWidth;
            this.label4.Height = this.label4.Height * ScreenHeight / FormHeight;
            this.label4.Width = this.label4.Width * ScreenWidth / FormWidth;
            this.label4.Font = new Font("Yu Gothic UI", this.label4.Font.Size * (ScreenHeight / FormHeight));

        
            this.label9.Height = this.label9.Height * ScreenHeight / FormHeight;
            this.label9.Width = this.label9.Width * ScreenWidth / FormWidth;
            this.label9.Font = new Font("Yu Gothic UI", this.label9.Font.Size * (ScreenHeight / FormHeight), FontStyle.Bold);

            
            this.panel2.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, panel2.Width,
            panel2.Height, 20, 20));
            
            this.panel3.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, panel3.Width,
            panel3.Height, 20, 20));
            this.panel4.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, panel4.Width,
            panel4.Height, 20, 20));
            this.panel5.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, panel5.Width,
            panel5.Height, 20, 20));
            this.tableLayoutPanel3.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, tableLayoutPanel3.Width,
            tableLayoutPanel3.Height, 20, 20));

            label1.Text = DateTime.Now.ToString("HH:mm");
            label2.Text = DateTime.Now.ToString("dd.MM.yy");

        }

        private void NewHome_Resize(object sender, EventArgs e)
        {
            this.panel2.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, panel2.Width,
            panel2.Height, 20, 20));
            this.panel3.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, panel3.Width,
            panel3.Height, 20, 20));
            this.panel4.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, panel4.Width,
            panel4.Height, 20, 20));
            this.panel5.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, panel5.Width,
            panel5.Height, 20, 20));
            this.tableLayoutPanel3.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, tableLayoutPanel3.Width,
            tableLayoutPanel3.Height, 20, 20));
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            this.panel3.BackColor = Color.FromArgb(99, 126, 118);     
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            this.panel3.BackColor = Color.Snow;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            this.panel3.BackColor = Color.FromArgb(99, 126, 118);
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            this.panel3.BackColor = Color.FromArgb(99, 126, 118);
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            this.panel2.BackColor = Color.FromArgb(99, 126, 118);
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            this.panel2.BackColor = Color.Snow;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.panel2.BackColor = Color.FromArgb(99, 126, 118);
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            this.panel2.BackColor = Color.FromArgb(99, 126, 118);
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            this.panel4.BackColor = Color.FromArgb(99, 126, 118);
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            this.panel4.BackColor = Color.Snow;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            this.panel4.BackColor = Color.FromArgb(99, 126, 118);
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            this.panel4.BackColor = Color.FromArgb(99, 126, 118);
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            this.panel5.BackColor = Color.FromArgb(99, 126, 118);
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            this.panel5.BackColor = Color.Snow;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            this.panel5.BackColor = Color.FromArgb(99, 126, 118);
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            this.panel5.BackColor = Color.FromArgb(99, 126, 118);
        }

        private void tableLayoutPanel3_MouseHover(object sender, EventArgs e)
        {
            this.tableLayoutPanel3.BackColor = Color.FromArgb(99, 126, 118);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            MostrarImagen.optionSelected = 1;
            MostrarImagen horarioV = new MostrarImagen();
            horarioV.Show();
            this.Hide();
        }

        private void NewHome_Load(object sender, EventArgs e)
        {
            //AnimateWindow(this.Handle, 1000, AW_ACTIVATE | AW_SLIDE | AW_HOR_POSITIVE);
        }

        private void tableLayoutPanel3_MouseLeave(object sender, EventArgs e)
        {
            this.tableLayoutPanel3.BackColor = Color.Snow;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {

        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            this.tableLayoutPanel3.BackColor = Color.FromArgb(99, 126, 118);
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            MostrarImagen.optionSelected = 4;
            MostrarImagen horarioV = new MostrarImagen();
            horarioV.Show();
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }



        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        public void printGesture()
        {
            //this.label1.Text = "A" + Language.FormStates;

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            MostrarImagen.optionSelected = 2;
            MostrarImagen horarioV = new MostrarImagen();
            horarioV.Show();
            this.Hide();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            MostrarImagen.optionSelected = 3;
            MostrarImagen horarioV = new MostrarImagen();
            horarioV.Show();
            this.Hide();
        }

        private void tableLayoutPanel3_Click(object sender, EventArgs e)
        {
            MostrarImagen.optionSelected = 5;
            MostrarImagen horarioV = new MostrarImagen();
            horarioV.Show();
            this.Hide();
        }

        public void close_Form()
        {
            this.Hide();
            NewHome nh = new NewHome();
            nh.Show();
           
        }

        private void tableLayoutPanel1_MouseHover(object sender, EventArgs e)
        {
            this.panel2.BackColor = Color.Snow;
            this.panel3.BackColor = Color.Snow;
            this.panel4.BackColor = Color.Snow;
            this.panel5.BackColor = Color.Snow;
            this.tableLayoutPanel3.BackColor = Color.Snow;
        }
    }
}
