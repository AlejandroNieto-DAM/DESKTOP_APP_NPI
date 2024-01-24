using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;






namespace Tuto
{


    public partial class MenuComedor : Form
    {


        private int screenHeight = 4096, screenWidth = 2160, formHeight = 1024, formWidth = 540;

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


        public string[] menuDelDia =
        {
            "Menú:\n - Arroz caldoso de pescado\n - Tortilla española\n - Melocotón",
            "Menú:\n - Sopa goulash\n - Pechuga de pollo Montecristo\n - Naranja",
            "Menú:\n - Espaguetis a la napolitana\n - Cazón en adobo\n - Pera",
            "Menú:\n - Cazuela malagueña\n - Rollitos de ternera estofados\n - Talvinas a la miel",
            "Menú:\n - Fideos de montaña\n - Pimientos fritos\n - Piña",
            "Menú:\n - Puchero de hinojos\n - Bacalao al estilo tradicional\n - Naranja",
            "Menú:\n - Arroz pilaf con ternera cazadora\n - Suprema de pollo a la sajona\n - Pera",
            "Menú:\n - Ensalada de patatas con naranja\n - Pizza jamón cocido y queso\n - Melón",
            "Menú:\n - Merluza a la andaluza\n - Ensalada mixta\n - Manzana",
            "Menú:\n - Sopa de cebolla\n - Quiche de membrillo y queso\n - Mandarinas",
            "Menú:\n - Sopa de albóndigas\n - Medallón de lomom con ali-oli\n - Plátano",
            "Menú:\n - Raviolis en salsa de pimientos\n - Merluza en salsa colbert\n - Naranja",
        };
        private int open = -1;
        private int change = -1;
        private int slide = 0; //0: left, 1: right
        //array de grupos de botones
        private Panel[] panelArray = new Panel[6];
        private Button[] collapseArray = new Button[6];
        private Label[] menuArray = new Label[6];
        private Button[] preorderArray = new Button[6];
        //guardado de imagenes que varían
        private Image dropRight;
        private Image dropDown;

        private int ratioHeight;
        private int ratioWidth;

        public MenuComedor()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(238, 186, 164);

            this.DoubleBuffered = true;

            int formHeight = this.Size.Height;
            int formWidth = this.Size.Width;

            ratioHeight = screenHeight / formHeight;
            ratioWidth = screenWidth / formWidth;

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            this.Height = screenHeight;
            this.Width = screenWidth;

            dropRight = Tuto.Properties.Resources.arrowRight2;
            dropDown = Tuto.Properties.Resources.arrowDown2;

            panelArray[0] = MenuPanel0;
            panelArray[1] = MenuPanel1;
            panelArray[2] = MenuPanel2;
            panelArray[3] = MenuPanel3;
            panelArray[4] = MenuPanel4;
            panelArray[5] = MenuPanel5;

            collapseArray[0] = Collapse0;
            collapseArray[1] = Collapse1;
            collapseArray[2] = Collapse2;
            collapseArray[3] = Collapse3;
            collapseArray[4] = Collapse4;
            collapseArray[5] = Collapse5;

            menuArray[0] = Menu0;
            menuArray[1] = Menu1;
            menuArray[2] = Menu2;
            menuArray[3] = Menu3;
            menuArray[4] = Menu4;
            menuArray[5] = Menu5;

            preorderArray[0] = Preorder0;
            preorderArray[1] = Preorder1;
            preorderArray[2] = Preorder2;
            preorderArray[3] = Preorder3;
            preorderArray[4] = Preorder4;
            preorderArray[5] = Preorder5;

            this.button1.Font = new Font("Yu Gothic UI", (int)this.button1.Font.Unit * ratioWidth * 3);

            this.week1Panel.Height = this.week1Panel.Height * ratioHeight;
            this.week1Panel.Width = this.week1Panel.Width * ratioWidth;
            //this.week1Panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, week1Panel.Width, week1Panel.Height, 20, 20));

            int minHeight = (this.collapseArray[0].Height + 5) * ratioHeight;

            for (int i = 0; i < 6; i++)
            {
                this.panelArray[i].MinimumSize = new Size(this.panelArray[i].MinimumSize.Width * ratioWidth, minHeight);
                this.panelArray[i].MaximumSize = new Size(this.panelArray[i].MaximumSize.Width * ratioWidth, this.panelArray[i].MaximumSize.Height * ratioHeight);
                this.panelArray[i].Height = this.panelArray[i].MinimumSize.Height;
                this.panelArray[i].Width = this.panelArray[i].MinimumSize.Width;
                this.panelArray[i].Margin = new Padding(this.panelArray[i].Margin.Left * ratioWidth, 0, this.panelArray[i].Margin.Right * ratioWidth, 0); 
                //
                this.collapseArray[i].Height = minHeight;
                this.collapseArray[i].Width = this.collapseArray[i].Width * ratioWidth;
                this.collapseArray[i].Font = new Font("Yu Gothic UI", (int)this.collapseArray[i].Font.Unit * ratioWidth * 3);
                //
                this.menuArray[i].Location = new Point(panelArray[i].Width/10, (int)(collapseArray[i].Height + 5*ratioHeight));
                this.menuArray[i].Height = this.panelArray[i].MaximumSize.Height / 2;
                this.menuArray[i].Width = this.panelArray[i].MaximumSize.Width / 5 * 4;
                this.menuArray[i].Font = new Font("Yu Gothic UI", (int)this.menuArray[i].Font.Unit * ratioWidth * 3);
                //
                this.menuArray[i].Text = menuDelDia[i];
                this.preorderArray[i].Location = new Point(panelArray[i].Width/10, menuArray[i].Height + menuArray[i].Location.Y + 5*ratioHeight);
                this.preorderArray[i].Height = (int)(this.panelArray[i].MaximumSize.Height / 6.66);
                this.preorderArray[i].Width = this.panelArray[i].MaximumSize.Width / 5 * 4;
                this.preorderArray[i].Font = new Font("Yu Gothic UI", (int)this.preorderArray[i].Font.Unit * ratioWidth * 3);
                //
                this.collapseArray[i].Image = dropRight;
                
            }
            //this.week1.Margin = new Padding(this.week1.Margin.Left * ratioWidth, 0, week1.Margin.Right * ratioWidth, 0);
            this.week1.Height = this.week1.Height * ratioHeight;
            this.week1.Width = this.week1.Width * ratioWidth;
            this.week1.Font = new Font("Yu Gothic UI", (int)this.week1.Font.Unit * ratioWidth * 3);
            this.button1.Font = new Font("Yu Gothic UI", (int)this.button1.Font.Unit * ratioWidth * 7);
            for (int i = 0; i < 6; i++)
            {
                this.panelArray[i].Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelArray[i].Width, panelArray[i].Height, 20 * ratioWidth, 20 * ratioWidth));
                this.collapseArray[i].Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, collapseArray[i].Width, collapseArray[i].Height, 20 * ratioWidth, 20 * ratioWidth));
                this.menuArray[i].Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, menuArray[i].Width, menuArray[i].Height, 20 * ratioWidth, 20 * ratioWidth));
                this.preorderArray[i].Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, preorderArray[i].Width, preorderArray[i].Height, 20 * ratioWidth, 20 * ratioWidth));
            }
            this.week1Panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, week1Panel.Width, week1Panel.Height, 20 * ratioWidth, 20 * ratioWidth));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void CollapseTimer_Tick(object sender, EventArgs e)
        {
            if (open != change && open != -1)
            {
                if (panelArray[open].Height == panelArray[open].MinimumSize.Height)
                {
                    collapseArray[open].Image = dropRight;
                    open = -1;
                }
                else
                {
                    panelArray[open].Height -= 10;
                    this.panelArray[open].Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelArray[open].Width, panelArray[open].Height, 20 * ratioWidth, 20 * ratioWidth));
                }
            }
            else if (open == -1 && change != -1)
            {
                if (collapseArray[change].Image == dropRight)
                    collapseArray[change].Image = dropDown;
                if (panelArray[change].Height == panelArray[change].MaximumSize.Height)
                {
                    open = change;
                    change = -1;
                    CollapseTimer1.Stop();
                }
                else
                {
                    panelArray[change].Height += 10;
                    this.panelArray[change].Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelArray[change].Width, panelArray[change].Height, 20 * ratioWidth, 20 * ratioWidth));
                }
            }
            else if (open == change)
            {
                if (panelArray[open].Height == panelArray[open].MinimumSize.Height)
                {
                    collapseArray[open].Image = dropRight;
                    open = -1;
                    change = -1;
                    CollapseTimer1.Stop();
                }
                else
                {
                    panelArray[open].Height -= 10;
                    this.panelArray[open].Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelArray[open].Width, panelArray[open].Height, 20 * ratioWidth, 20 * ratioWidth));
                }
            }
        }

        private void Collapse0_Click(object sender, EventArgs e)
        {
            if (!CollapseTimer1.Enabled)
            {
                change = 0;
                CollapseTimer1.Start();
            }
        }
        private void Collapse1_Click(object sender, EventArgs e)
        {
            if (!CollapseTimer1.Enabled)
            {
                change = 1;
                CollapseTimer1.Start();
            }
        }

        private void Collapse2_Click(object sender, EventArgs e)
        {
            if (!CollapseTimer1.Enabled)
            {
                change = 2;
                CollapseTimer1.Start();
            }
        }

        private void Collapse3_Click(object sender, EventArgs e)
        {
            if (!CollapseTimer1.Enabled)
            {
                change = 3;
                CollapseTimer1.Start();
            }
        }
        private void Collapse4_Click(object sender, EventArgs e)
        {
            if (!CollapseTimer1.Enabled)
            {
                change = 4;
                CollapseTimer1.Start();
            }
        }

        private void Collapse5_Click(object sender, EventArgs e)
        {
            if (!CollapseTimer1.Enabled)
            {
                change = 5;
                CollapseTimer1.Start();
            }
        }

        private void MenuComedor_Load(object sender, EventArgs e)
        {

        }

        private void week1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu5_Click(object sender, EventArgs e)
        {

        }

        private void Menu4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Preorder5_Click(object sender, EventArgs e)
        {
            QRscan QR = new QRscan("saturday");
            QR.Show();
            this.Hide();
        }

        private void Preorder4_Click(object sender, EventArgs e)
        {
            QRscan QR = new QRscan("friday");
            QR.Show();
            this.Hide();
        }

        private void Preorder3_Click(object sender, EventArgs e)
        {
            QRscan QR = new QRscan("thursday");
            QR.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Preorder2_Click(object sender, EventArgs e)
        {
            QRscan QR = new QRscan("wednesday");
            QR.Show();
            this.Hide();
        }

        private void Preorder1_Click(object sender, EventArgs e)
        {
            QRscan QR = new QRscan("tuesday");
            QR.Show();
            this.Hide();
        }

        private void Preorder0_Click(object sender, EventArgs e)
        {
            QRscan QR = new QRscan("monday");
            QR.Show();
            this.Hide();
        }
    }

    

}