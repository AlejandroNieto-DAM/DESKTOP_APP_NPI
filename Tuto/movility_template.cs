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
    public partial class movility_template : Form
    {
        int multiplier = 1;
        int textFontSize = 16;
        string nameUniversity;
        string number_plazas;
        string duracion;
        string requisitos;
        string notas;

        public movility_template(string nameUniversity, string number_plazas, string duracion, string requisitos, string notas)
        {
            InitializeComponent();

            // Correct the assignment to class members
            this.nameUniversity = nameUniversity;
            this.number_plazas = number_plazas;
            this.duracion = duracion;
            this.requisitos = requisitos;
            this.notas = notas;

            configuredata();
            ApplyCommonStyleLabel();
        }

        public void configuredata()
        {
            // You can use the assigned values here or perform other configuration tasks
            label_fill_duration.Text = duracion;
            label_fill_university.Text = nameUniversity;
            label_fill_places.Text = number_plazas;
            label_fill_notes.Text = notas;
            label_fill_requisitos.Text = requisitos;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ApplyCommonStyleLabel()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;  // Corrected the variable name
                    label.Font = new Font("Yu Gothic UI", multiplier * textFontSize, FontStyle.Regular);
                    label.ForeColor = Color.White;
                }
            }
        }

    }
}

