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

        private static extern IntPtr CreateRoundRectRgn
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

            /*
            this.panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width,
            panel2.Height, 20, 20));
            this.panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width,
            panel3.Height, 20, 20));
            this.panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width,
            panel4.Height, 20, 20));
            this.panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width,
            panel5.Height, 20, 20));
            this.tableLayoutPanel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel3.Width,
            tableLayoutPanel3.Height, 20, 20));*/
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {

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
