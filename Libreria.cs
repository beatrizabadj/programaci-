using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

internal class Libreria
{
    static void Main()
    {
        string archivo = "libros.txt";

        while (true)
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Añadir libro");
            Console.WriteLine("2. Mostrar libros");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AñadirLibros(archivo);
                    break;
                case "2":
                    MostrarLibrosOrdenadosPorAutor(archivo);
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                    break;
            }
        }
    }

    private static void AñadirLibros(string archivo)
    {
        List<string> libros = new List<string>();

        while (true)
        {
            Console.WriteLine("Título? (o escriba 'salir' para finalizar)");
            string titulo = Console.ReadLine();
            if (titulo.ToLower() == "salir") break;

            Console.WriteLine("Autor? ");
            string autor = Console.ReadLine();

            Console.WriteLine("Editorial? ");
            string editorial = Console.ReadLine();

            libros.Add($"{titulo};{autor};{editorial}");
        }

        using (StreamWriter libreria = new StreamWriter(archivo, true))
        {
            foreach (string libro in libros)
            {
                libreria.WriteLine(libro);
            }
        }
    }

    private static void MostrarLibrosOrdenadosPorAutor(string archivo)
    {
        if (!File.Exists(archivo))
        {
            Console.WriteLine("No hay libros registrados.");
            return;
        }

        List<string[]> libros = new List<string[]>();

        using (StreamReader libreria = new StreamReader(archivo))
        {
            string linea;
            while ((linea = libreria.ReadLine()) != null)
            {
                string[] datosLibro = linea.Split(';');
                libros.Add(datosLibro);
            }
        }

        libros = libros.OrderBy(libro => libro[1]).ToList();

        foreach (var datosLibro in libros)
        {
            Console.WriteLine("Título: {0}", datosLibro[0]);
            Console.WriteLine("Autor: {0}", datosLibro[1]);
            Console.WriteLine("Editorial: {0}", datosLibro[2]);
            Console.WriteLine();
        }
    }
}
