using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace GestorTareasTechSolutions
{
    public partial class FormReadme : Form
    {
        // Variable para guardar el texto que nos pasen
        private string contenidoDelReadme = "";

        // Constructor MODIFICADO
        // Le pedimos que nos pase el texto del README al crearlo
        public FormReadme(string textoLeido)
        {
            InitializeComponent();
            contenidoDelReadme = textoLeido;
        }



        // Evento CLICK del botón guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Abre el diálogo de "Guardar como..."
            using (SaveFileDialog dialogo = new SaveFileDialog())
            {
                dialogo.Filter = "Archivo de Texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                dialogo.Title = "Guardar README como...";
                dialogo.FileName = "README.txt";

                // Si el usuario hace clic en "Guardar"
                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Escribe el contenido del TextBox en el archivo
                        File.WriteAllText(dialogo.FileName, txtContenido.Text);
                        MessageBox.Show("Archivo guardado con éxito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"No se pudo guardar el archivo. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Evento LOAD (Se dispara cuando el formulario se carga)
        private void FormReadme_Load(object sender, EventArgs e)
        {
            // Ponemos el texto que recibimos en el TextBox
            txtContenido.Text = contenidoDelReadme;
            txtContenido.SelectionStart = 0; // Mueve el cursor al inicio
            txtContenido.ScrollToCaret();    // Mueve la vista al inicio
        }

        
    }
}
