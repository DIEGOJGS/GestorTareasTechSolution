using System;
using System.Collections.Generic; // Para las listas
using System.Windows.Forms;     // Para los formularios
using System.Reflection;
using System.Diagnostics;
using System.IO;                

// Asegúrate que el namespace sea el mismo nombre de tu proyecto
namespace GestorTareasTechSolutions
{
    public partial class Form1 : Form
    {
        // Creamos una instancia "global" del gestor para que
        // todos los botones la puedan usar.
        private GestorTareas gestorDeSoporte;

        public Form1()
        {
            InitializeComponent();

            // Inicializamos el gestor en el constructor del formulario
            gestorDeSoporte = new GestorTareas();
            gestorDeSoporte.RegistrarNuevaTarea(new Tarea(101, "Instalar Office 2023", "Media", "Instalar en laptop de Gerencia."));
            gestorDeSoporte.RegistrarNuevaTarea(new Tarea(102, "Revisar backup Servidor", "Alta", "El backup de anoche falló."));
            gestorDeSoporte.RegistrarNuevaTarea(new Tarea(103, "Cambiar tóner impresora", "Baja", "Impresora de contabilidad no tiene tinta."));
            ActualizarListasVisuales();
        }

        // --- EVENTOS DE BOTONES ---

        // Este método se crea solo si haces doble clic en el botón "Registrar Tarea"
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Usamos 'try-catch' para capturar errores,
            // por ejemplo si escriben "abc" en el ID
            try
            {
                // 1. Validar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(txtId.Text) ||
                    string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    cmbPrioridad.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe completar ID, Nombre y Prioridad.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Crear la Tarea
                Tarea tareaNueva = new Tarea(
                    int.Parse(txtId.Text), // Convertimos el texto del ID a número
                    txtNombre.Text,
                    cmbPrioridad.Text,
                    txtDescripcion.Text
                );

                // 3. Registrarla en el gestor
                bool exito = gestorDeSoporte.RegistrarNuevaTarea(tareaNueva);

                // 4. Dar retroalimentación
                if (exito)
                {
                    MessageBox.Show("Tarea registrada en la cola.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    ActualizarListasVisuales();
                }
                else
                {
                    MessageBox.Show("Error: Ese ID ya existe.", "ID Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: El ID debe ser un número.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Este método se crea solo si haces doble clic en el botón "Procesar Siguiente Tarea"
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            // 1. Pedir al gestor que procese
            Tarea tareaAtendida = gestorDeSoporte.ProcesarSiguienteTarea();

            // 2. Mostrar resultado
            if (tareaAtendida != null)
            {
                // Usamos el método de detalle que creamos en la clase Tarea
                MessageBox.Show(tareaAtendida.ObtenerDetalleCompleto(), "Tarea Procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarListasVisuales(); // Actualizamos las listas
            }
            else
            {
                MessageBox.Show("No hay tareas pendientes en la cola.", "Cola Vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Este método se crea solo si haces doble clic en el botón "Ayuda / README"
        private void btnVerReadme_Click(object sender, EventArgs e)
        {
            try
            {
                string textoReadme = LeerReadmeIncrustado();

                // Creamos una instancia del FormReadme
                // y le pasamos el texto en su constructor
                FormReadme frmReadme = new FormReadme(textoReadme);

                // Mostramos el formulario como un diálogo
                frmReadme.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo de ayuda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- MÉTODOS DE AYUDA (PRIVADOS) ---

        // Método para limpiar los campos después de registrar
        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            cmbPrioridad.SelectedIndex = -1; // Limpia el ComboBox
            txtId.Focus(); // Pone el cursor de vuelta en el ID
        }

        // Este método actualiza AMBAS listas
        private void ActualizarListasVisuales()
        {
            // Limpiamos
            lstPendientes.Items.Clear();
            lstHistorial.Items.Clear();

            // Llenamos Pendientes (Queue)
            foreach (Tarea t in gestorDeSoporte.TareasPendientes)
            {
                // Usamos el método ToString() de la Tarea
                lstPendientes.Items.Add(t.ToString());
            }

            // Llenamos Historial (List)
            foreach (Tarea t in gestorDeSoporte.TareasAtendidas)
            {
                lstHistorial.Items.Add(t.ToString());
            }

            // Actualizamos los contadores
            lblConteoPendientes.Text = $"({gestorDeSoporte.TareasPendientes.Count})";
            lblConteoHistorial.Text = $"({gestorDeSoporte.TareasAtendidas.Count})";
        }

        // Esta es la "magia" para leer el archivo incrustado
        private string LeerReadmeIncrustado()
        {
            var assembly = Assembly.GetExecutingAssembly();
            // OJO: El nombre debe coincidir: "TuProyecto.README.txt"
            string nombreRecurso = $"{assembly.GetName().Name}.README.txt";

            using (Stream stream = assembly.GetManifestResourceStream(nombreRecurso))
            {
                if (stream == null)
                {
                    throw new Exception("No se encontró el recurso 'README.txt'. ¿Olvidaste marcarlo como 'Recurso Incrustado' en el Paso 4?");
                }
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        private void btnEspiar_Click(object sender, EventArgs e)
        {
            // Llamamos a nuestro NUEVO método del gestor
            Tarea proximaTarea = gestorDeSoporte.EspiarProximaTarea();

            if (proximaTarea != null)
            {
                MessageBox.Show(proximaTarea.ObtenerDetalleCompleto(), "Próxima Tarea en la Cola");
            }
            else
            {
                MessageBox.Show("No hay tareas pendientes para espiar.", "Cola Vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            // ¡¡CAMBIA ESTA URL POR LA DE TU REPOSITORIO!!
            string url = "https://github.com/TuUsuario/TuRepositorio";

            try
            {
                // Esta línea abre el navegador por defecto
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir el enlace. Error: {ex.Message}", "Error al Abrir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}