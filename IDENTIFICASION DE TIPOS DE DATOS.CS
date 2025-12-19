using System;
using System.Collections.Generic;

namespace AgendaTelefonica
{
    // Estructura que representa un contacto
    public struct Contacto
    {
        public string Nombre;
        public string Telefono;
        public string Correo;
        public string Grupo;
    }

    // Clase Agenda que maneja la lógica del sistema
    public class Agenda
    {
        // Vector (lista) para almacenar los contactos
        private List<Contacto> contactos = new List<Contacto>();

        // Método para agregar un contacto
        public void AgregarContacto()
        {
            Contacto nuevoContacto = new Contacto();

            Console.Write("Ingrese el nombre: ");
            nuevoContacto.Nombre = Console.ReadLine();

            Console.Write("Ingrese el teléfono: ");
            nuevoContacto.Telefono = Console.ReadLine();

            Console.Write("Ingrese el correo: ");
            nuevoContacto.Correo = Console.ReadLine();

            Console.Write("Ingrese el grupo (Familia, Trabajo, Amigos): ");
            nuevoContacto.Grupo = Console.ReadLine();

            contactos.Add(nuevoContacto);
            Console.WriteLine("\nContacto agregado correctamente.\n");
        }

        // Método para mostrar todos los contactos
        public void MostrarContactos()
        {
            if (contactos.Count == 0)
            {
                Console.WriteLine("\nNo hay contactos registrados.\n");
                return;
            }

            Console.WriteLine("\nLISTA DE CONTACTOS\n");

            foreach (var c in contactos)
            {
                Console.WriteLine($"Nombre: {c.Nombre}");
                Console.WriteLine($"Teléfono: {c.Telefono}");
                Console.WriteLine($"Correo: {c.Correo}");
                Console.WriteLine($"Grupo: {c.Grupo}");
                Console.WriteLine("--------------------------");
            }
        }

        // Reporte usando matriz
        public void ReporteMatriz()
        {
            if (contactos.Count == 0)
            {
                Console.WriteLine("\nNo hay datos para el reporte.\n");
                return;
            }

            // Matriz para el reporte (Nombre - Teléfono)
            string[,] reporte = new string[contactos.Count, 2];

            for (int i = 0; i < contactos.Count; i++)
            {
                reporte[i, 0] = contactos[i].Nombre;
                reporte[i, 1] = contactos[i].Telefono;
            }

            Console.WriteLine("\nREPORTE DE CONTACTOS (MATRIZ)\n");

            for (int i = 0; i < contactos.Count; i++)
            {
                Console.WriteLine($"Nombre: {reporte[i, 0]} - Teléfono: {reporte[i, 1]}");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            int opcion;

            do
            {
                Console.WriteLine("===== AGENDA TELEFÓNICA =====");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Mostrar contactos");
                Console.WriteLine("3. Reporte (Matriz)");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                // Validación de entrada
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida.\n");
                    continue;
                }

                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        agenda.AgregarContacto();
                        break;
                    case 2:
                        agenda.MostrarContactos();
                        break;
                    case 3:
                        agenda.ReporteMatriz();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.\n");
                        break;
                }

            } while (opcion != 4);
        }
    }
}
