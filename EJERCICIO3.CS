using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Se solicita al usuario ingresar números separados por espacios
        Console.WriteLine("Ingrese los números de la lotería separados por espacios:");
        
        // Se leen los números y se convierten en una lista de enteros
        List<int> numeros = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        // Se ordenan los números de menor a mayor
        numeros.Sort();

        // Se muestran los números ordenados
        Console.WriteLine("Números ordenados:");
        Console.WriteLine(string.Join(", ", numeros));
    }
}
