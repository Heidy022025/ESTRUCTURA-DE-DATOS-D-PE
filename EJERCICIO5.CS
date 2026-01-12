using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lista de precios
        List<int> precios = new List<int>() { 50, 75, 46, 22, 80, 65, 8 };

        // Variables para almacenar el menor y mayor precio
        int menor = int.MaxValue;
        int mayor = int.MinValue;

        // Se recorre la lista para encontrar el menor y el mayor
        foreach (int precio in precios)
        {
            if (precio < menor)
                menor = precio;

            if (precio > mayor)
                mayor = precio;
        }

        // Se muestran los resultados
        Console.WriteLine("El menor precio es: " + menor);
        Console.WriteLine("El mayor precio es: " + mayor);
    }
}
