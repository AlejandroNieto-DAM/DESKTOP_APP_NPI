using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuto
{
    public partial class CalendarWindow : BasicFormLayout
    {
        private bool isNationalExchange;
        public CalendarWindow(bool isNationalExchange)
        {
            InitializeComponent();
            this.isNationalExchange = isNationalExchange;
            this.Language = "es";
            this.Size = FormSize;

            loadRequirements();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void loadRequirements()
        {
            panelInformation.BackColor = Color.White;
            if (isNationalExchange)
            {
                listRequirements.Text = "3 de Enero - Cierre convicatoria";
            }
            else
            {
                listRequirements.Text = "10 de Enero - Cierre convocatoria";
            }
        }
    }
}
