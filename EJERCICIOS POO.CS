using System;
using System.Collections.Generic;

// Clase que representa un conjunto de asignaturas
class Asignaturas
{
    // Lista donde se almacenan las materias
    public List<string> Materias { get; set; }

    // Constructor que inicializa la lista
    public Asignaturas()
    {
        Materias = new List<string>()
        {
            "Matemáticas", "Física", "Química", "Historia", "Lengua"
        };
    }

    // Método para mostrar las asignaturas
    public void Mostrar()
    {
        Console.WriteLine("Asignaturas del curso:");
        foreach (string materia in Materias)
        {
            Console.WriteLine("- " + materia);
        }
    }
}

class Program
{
    static void Main()
    {
        // Se crea el objeto curso
        Asignaturas curso = new Asignaturas();
        // Se muestran las asignaturas
        curso.Mostrar();
    }
}
