using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using Tuto.Properties;
using System.Reflection;

namespace Tuto
{
    public partial class professorMain : BasicFormLayout
    {
        string search_name = "";
        List<string> namesProfessors = new List<string>();
        List<string> departamentoProfessors = new List<string>();
        List<string> tutorias1 = new List<string>();
        List<string> tutorias2 = new List<string>();
        public professorMain()
        {
            InitializeComponent();
            setStyle();
            readfileCSV();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            keyboard_screen keyboard = new keyboard_screen();
            keyboard.ShowDialog();
            search_name = keyboard.GetName2Search();
            labelname.Text = search_name.ToUpper();
            int index_info = searchNameOnList();
            if (index_info == -1)
            {
                labelresult.Text = $"Ningun profesor coincide con la búsqueda {search_name}. Por favor vuelva a intentar";
            }
            else
            {
                labelresult.Text = $"Nombre {namesProfessors[index_info]}\nDepartamento: {departamentoProfessors[index_info]}\nTutorias Primer semestre:\n{tutorias1[index_info]}\nTutorias segundo semestre:\n{tutorias2[index_info]}:";
            }
        }

        private void setStyle()
        {
            labeltitle.Font = new Font("Yu Gothic UI", multiplier_size * titleFontSize, FontStyle.Regular);
            labelname.Font = new Font("Yu Gothic UI", multiplier_size * textFontSize, FontStyle.Regular);
            buttonsearch.Font = new Font("Yu Gothic UI", multiplier_size* textFontSize, FontStyle.Regular);
            labelresult.Font = new Font("Yu Gothic UI", multiplier_size * textFontSize, FontStyle.Regular);
        }

        private void readfileCSV()
        {

            string currentDirectory = Directory.GetCurrentDirectory();
            string pathUntilTuto = "";

            // Get the directory path until "Tuto"
            int tutoIndex = currentDirectory.IndexOf("Tuto", StringComparison.OrdinalIgnoreCase);

            if (tutoIndex != -1)
            {
                pathUntilTuto = currentDirectory.Substring(0, tutoIndex + "Tuto".Length);
            }
            else
            {
                Console.WriteLine("The word 'Tuto' is not present in the path.");
            }

            string filePath = pathUntilTuto + "\\Resources\\professors.csv"; // Reemplaza con la ruta de tu archivo CSV
            Console.WriteLine(filePath + "\n");

            // Comprueba si el archivo existe
            if (File.Exists(filePath))
            {
                using(var reader = new StreamReader(filePath))
                {
                     while (reader.EndOfStream == false)
                     {
                        var content = reader.ReadLine();
                        var cells = content.Split(',').ToList();
                        if (RowHasData(cells))
                        {
                            namesProfessors.Add(cells[0]);
                            departamentoProfessors.Add(cells[1]);
                            tutorias1.Add(cells[2]);
                            tutorias2.Add(cells[3]);
                        }

                     }
                }
            }
            else
            {
                Console.WriteLine("El archivo no existe.");
            }


        }

        static bool RowHasData(List<string> cells)
        {
            return cells.Any(x => x.Length > 0);
        }

        private int searchNameOnList()
        {
            for(int i= 0;i< namesProfessors.Count;i++)
            {
                if (namesProfessors[i].ToUpper().Contains(search_name)) return i;
            }
            return -1;
        }
    }
}
