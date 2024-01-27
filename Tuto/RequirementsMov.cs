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
    public partial class RequirementsMov : BasicFormLayout
    {
        private string typeScholarship;
        public RequirementsMov(string typeScholarship)
        {
            InitializeComponent();
            Language.className = "RequirementsMov";
            Language.lastForm = this;
            this.LayoutLanguage = "es";
            this.Size = FormSize;
            this.typeScholarship = typeScholarship;

            setStyle();
            loadRequirements();
           
        }

        public void close_Form()
        {
            this.Hide();
            adminOptions adminOptions = new adminOptions();
            adminOptions.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
        }
        private void setStyle()
        {
            labelTitle.Font = new Font("Yu Gothic UI", multiplier_size * titleFontSize, FontStyle.Regular);
            labelreq.Font = new Font("Yu Gothic UI", multiplier_size * textFontSize, FontStyle.Regular);
        }
        private void loadRequirements()
        {
            if (typeScholarship == "UGR")
            {
                labelreq.Text = "Beca UGR";
            } else if (typeScholarship == "ANDALUCIA")
            {
                labelreq.Text = "Beca Andalucia";
            } else if (typeScholarship == "MINISTERIO")
            {
                labelreq.Text = "Beca Ministerio";
            }
            else
            {
                labelreq.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
