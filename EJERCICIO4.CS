using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lista para almacenar los números
        List<int> numeros = new List<int>();

        // Se agregan los números del 1 al 10
        for (int i = 1; i <= 10; i++)
        {
            numeros.Add(i);
        }

        // Se invierte el orden de la lista
        numeros.Reverse();

        // Se muestran los números en orden inverso
        Console.WriteLine("Números en orden inverso:");
        Console.WriteLine(string.Join(", ", numeros));
    }
}
