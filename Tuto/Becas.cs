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
    public partial class Becas : BasicFormLayout
    {
        bool isNationalExchange;
        public Becas()
        {
            InitializeComponent();
            //tableLayoutPanel1.BackColor = Color.Transparent;
            //tableLayoutPanel2.BackColor = Color.Transparent;
            this.Size = FormSize;
            ApplyCommonStyleButton();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Form1 optionsWindow = new Form1();
            optionsWindow.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void buttonOffers_Click_1(object sender, EventArgs e)
        {
            offersExchange form4 = new offersExchange(isNationalExchange);
            form4.Show();
            this.Hide();
        }

        private void buttonRequirements_Click_1(object sender, EventArgs e)
        {
            RequirementsMov formRequirements = new RequirementsMov(this.isNationalExchange);
            formRequirements.Show();
            this.Hide();
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            CalendarWindow formCalendar = new CalendarWindow(this.isNationalExchange);
            formCalendar.Show();
            this.Hide();
        }

        private void ApplyCommonStyleButton()
        {
            // TODO: this is not working
            // Iterar sobre todos los controles en el formulario
            foreach (Control control in tableLayoutPanel2.Controls)
            {
                if (control is Button)
                {
                    Button boton = (Button)control;
                    boton.Font = new Font("Arial", 16 * 4, FontStyle.Bold);
                }
            }
        }
    }
}
