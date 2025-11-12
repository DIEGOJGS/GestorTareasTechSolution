/*
 * CLASE: GestorTareas
 * Autor: Diego Garcia
 * Descripción: Controla toda la lógica de negocio,
 * como agregar, procesar y consultar tareas.
 */
using System.Collections.Generic; 
using System.Linq; 

public class GestorTareas
{
    // ESTRUCTURA DE DATOS: Usamos una Cola (Queue)
    // porque atiende en orden de llegada (FIFO)
    private Queue<Tarea> colaDePendientes;

    // Usamos una Lista para el historial, es más fácil de consultar
    private List<Tarea> historialDeAtendidas;

    // Propiedades para que el Formulario pueda "leer" las listas
    // (Usamos "ReadOnly" para protegerlas)
    public IReadOnlyCollection<Tarea> TareasPendientes => colaDePendientes;
    public IReadOnlyCollection<Tarea> TareasAtendidas => historialDeAtendidas;

    // Constructor: Inicializa las listas cuando se crea el gestor
    public GestorTareas()
    {
        colaDePendientes = new Queue<Tarea>();
        historialDeAtendidas = new List<Tarea>();
    }

    // 1. REGISTRAR
    public bool RegistrarNuevaTarea(Tarea nuevaTarea)
    {
        // Validación de ID duplicado
        if (IdYaExiste(nuevaTarea.Id))
        {
            return false; // Falla
        }

        // Enqueue: Agrega la tarea al final de la cola
        colaDePendientes.Enqueue(nuevaTarea);
        return true; // Éxito
    }

    // 2. PROCESAR
    public Tarea ProcesarSiguienteTarea()
    {
        // Control de estructura vacía
        if (colaDePendientes.Count == 0)
        {
            return null; // No hay nada que procesar
        }

        // Dequeue: Saca el primer elemento de la cola
        Tarea tareaProcesada = colaDePendientes.Dequeue();

        // Lo mandamos al historial
        historialDeAtendidas.Add(tareaProcesada);

        return tareaProcesada; // Devuelve la tarea para mostrarla
    }
    // 3. ESPIAR (PEEK)
    public Tarea EspiarProximaTarea()
    {
        if (colaDePendientes.Count == 0)
        {
            return null; // No hay nada que espiar
        }

        // Usamos Peek() aquí, DENTRO de la clase
        return colaDePendientes.Peek();
    }

    // 3. Método de ayuda (privado) para validar IDs
    private bool IdYaExiste(int id)
    {
        // Revisa si el ID existe en CUALQUIERA de las dos listas
        bool enPendientes = colaDePendientes.Any(t => t.Id == id);
        bool enAtendidas = historialDeAtendidas.Any(t => t.Id == id);
        return enPendientes || enAtendidas;
    }
}