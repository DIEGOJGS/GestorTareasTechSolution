/*
 * CLASE: Tarea
 * Autor: Diego Garcia
 * Fecha: 12/11/2025
 * Descripción: Define la estructura de cada ticket de soporte.
 */
using System;

public class Tarea
{
    // Propiedades principales
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Prioridad { get; set; }
    public DateTime FechaRegistro { get; set; }
    public string Descripcion { get; set; }

    // Constructor: El método que "crea" el objeto
    public Tarea(int id, string nombre, string prioridad, string descripcion)
    {
        Id = id;
        Nombre = nombre;
        Prioridad = prioridad;
        FechaRegistro = DateTime.Now; // La fecha se pone sola
        Descripcion = descripcion;
    }

    // Método para mostrar en las listas (ListBox)
    // Esto es lo que se verá en la lista principal
    public override string ToString()
    {
        string fechaCorta = FechaRegistro.ToShortDateString();
        // Formato: [ID] - Nombre (Prioridad)
        return $"[{Id}] - {fechaCorta} - {Nombre} ({Prioridad})";
    }

    // Método para mostrar el detalle completo en un mensaje
    public string ObtenerDetalleCompleto()
    {
        return $"--- DETALLE DE TAREA ---\n\n" +
               $"ID: {Id}\n" +
               $"Nombre: {Nombre}\n" +
               $"Prioridad: {Prioridad}\n" +
               $"Registrada: {FechaRegistro.ToString("g")}\n\n" +
               $"Descripción:\n{Descripcion}";
    }
}