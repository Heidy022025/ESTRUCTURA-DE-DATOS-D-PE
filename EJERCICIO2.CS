using System;
using System.Collections.Generic;

// Clase que representa una asignatura con su nota
class AsignaturaNota
{
    public string Nombre { get; set; }
    public double Nota { get; set; }

    // Método para pedir la nota al usuario
    public void PedirNota()
    {
        Console.Write($"Ingrese la nota de {Nombre}: ");
        Nota = Convert.ToDouble(Console.ReadLine());
    }

    // Método para mostrar la nota
    public void Mostrar()
    {
        Console.WriteLine($"En {Nombre} has sacado {Nota}");
    }
}

class Program
{
    static void Main()
    {
        // Lista de asignaturas
        List<AsignaturaNota> lista = new List<AsignaturaNota>()
        {
            new AsignaturaNota { Nombre = "Matemáticas" },
            new AsignaturaNota { Nombre = "Física" },
            new AsignaturaNota { Nombre = "Química" }
        };

        // Solicita las notas
        foreach (AsignaturaNota asign in lista)
        {
            asign.PedirNota();
        }

        // Muestra los resultados
        foreach (AsignaturaNota asign in lista)
        {
            asign.Mostrar();
        }
    }
}
