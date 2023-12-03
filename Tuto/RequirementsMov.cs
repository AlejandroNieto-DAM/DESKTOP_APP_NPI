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
        private bool isNationalExchange;
        public RequirementsMov(bool isNationalExchange)
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

        private void loadRequirements()
        {
            panelInformation.BackColor = Color.White;
            if (isNationalExchange)
            {
                listRequirements.Text = "45 creditos\nCodigo UGR\nMatricula Valida";
            }
            else
            {
                listRequirements.Text = "Certificado de lenguaje de la Universidad";
            }
        }
    }
}
