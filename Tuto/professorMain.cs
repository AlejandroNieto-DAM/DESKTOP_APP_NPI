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
    public partial class professorMain : BasicFormLayout
    {
        string search_name = "";
        public professorMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            keyboard_screen keyboard = new keyboard_screen();
            keyboard.ShowDialog();
            search_name = keyboard.GetName2Search();
            labelname.Text = search_name;
        }
    }
}
