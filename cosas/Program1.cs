using System;

namespace cosas
{
    class Program1
    {
        static void Main()
        {
            string[] nombres = new string[100];
            int contador = 0;

            while (true)
            {
                Console.Write("Introduce un nombre (o escribe 'stop' para terminar): ");
                string nombre = Console.ReadLine();

                if (nombre.ToLower() == "stop")
                    break;

                nombres[contador] = nombre;
                contador++;

                if (contador == 100)
                {
                    Console.WriteLine("Se ha alcanzado el límite de 100 nombres.");
                    break;
                }
            }

            Console.WriteLine("\nLista de nombres introducidos:");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine(nombres[i]);
            }
        }
    }
}


namespace cosas
{
class Program2
{
    static void Main()
    {
        int[] diasPorMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        Console.Write("Introduce un número de mes (1=enero, 12=diciembre): ");
        int mes = Convert.ToInt32(Console.ReadLine());

        if (mes >= 1 && mes <= 12)
        {
            int dias = diasPorMes[mes - 1];
            Console.WriteLine("El mes {0} tiene {1} días.", mes, dias);
        }
        else
        {
            Console.WriteLine("Número de mes inválido. Debe estar entre 1 y 12.");
        }
    }
}
}

namespace cosas
{
class Program3
{
    static void Main()
    {
        int[] diasPorMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        Console.Write("Introduce un número de mes (1=enero, 12=diciembre): ");
        int mes = Convert.ToInt32(Console.ReadLine());

        if (mes >= 1 && mes <= 12)
        {
            int dias = diasPorMes[mes - 1];
            Console.WriteLine("El mes {0} tiene {1} días.", mes, dias);
        }
        else
        {
            Console.WriteLine("Número de mes inválido. Debe estar entre 1 y 12.");
        }
    }
}
}

namespace cosas
{
class Program4
{
    static void Main()
    {
        decimal[] valores = new decimal[7];

        for (int i = 0; i < 7; i++)
        {
            Console.Write("Introduce el valor {0}: ", i + 1);
            valores[i] = Convert.ToDecimal(Console.ReadLine());
        }

        Array.Sort(valores);
        Array.Reverse(valores);

        Console.WriteLine("Valores ordenados de mayor a menor:");
        foreach (var valor in valores)
        {
            Console.WriteLine(valor);
        }
    }
}
}
namespace cosas
{
class Program5
{
    static void Main()
    {
        int numerosPares = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Introduce el número {0}: ", i + 1);
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                numerosPares++;
            }
        }

        Console.WriteLine("Cantidad de números pares: {0}", numerosPares);
    }
}
}