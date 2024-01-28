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
using Tuto.Properties;

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
            this.Size = FormSize;
            this.typeScholarship = typeScholarship;
            change_language();
            setStyle();
            loadRequirements();
           
        }

        public void change_language()
        {
            if (Language.SelectedLanguage == 1)
            {
                labelTitle.Text = "Requisitos";
                labelreq.Text = "Escanee el código QR para obtener más información";
            }
            else if (Language.SelectedLanguage == 2)
            {
                labelTitle.Text = "Requirements";
                labelreq.Text = "Scan QR code for more information";
            }
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
                //labelreq.Text = "Beca UGR";
                pictureBox1.Image = Resources.ugr_becas;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            } 
            else if (typeScholarship == "ANDALUCIA")
            {
                pictureBox1.Image = Resources.andaluciaqr;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            } 
            else if (typeScholarship == "MINISTERIO")
            {
                pictureBox1.Image = Resources.ministerioqr;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
