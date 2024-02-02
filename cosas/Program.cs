using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[][] localidades = { //definicion de la matriz 
            new int[] {1,1,1},
            new int[] {1,0,1,1},
            new int[] {0,0,1,1,1},
            new int[] {1,1,1,1,1},
            new int[] {0,1,0,1,1}
        };
        
            int localidadesVendidas = 0;
            int localidadesLibres = 0;
            
            for (int i=0; i < localidades.Length; i++) //iteración por las filas
            {
                for (int j=0; j < localidades[i].Length;j++) //itera sobre cada columna en la fila actual localidades[i]. recorre cada elemento en esa fila específica.
                {
                    if (localidades[i][j] == 1)
                    {
                        localidadesVendidas++;
                    }
                    else if (localidades[i][j] == 0)
                    {
                        localidadesLibres++;
                    }
                }
            }
            Console.WriteLine("Hay " + localidadesVendidas + " localidades vendidas.");
            Console.WriteLine("Hay " + localidadesLibres+ " localidades disponibles.");
                
            }
        }


public class Program
    {
        static void Main(string[] args)
        {
            string[][] sistemaReservas = {
                new string[] { "O", "X", "X", "X", "X" },
                new string[] { "X", "X", "X", "O", "X" },
                new string[] { "X", "X", "X", "X", "X" },
                new string[] { "X", "O", "X", "X", "X" },
                new string[] { "X", "X", "X", "X", "X" },
                new string[] { "O", "X", "X", "X", "X" },
                new string[] { "X", "O", "X", "X" },
                new string[] { "X", "X", "X" },
            };
            int contadorOcupado = 0;
            int contadorLibre = 0;

            for (int i = 0; i < sistemaReservas.Length; i++)
            {
                for (int j = 0; j < sistemaReservas[i].Length; j++)
                {
                    if (sistemaReservas[i][j] == "X")
                    {
                        contadorOcupado++;
                    }
                    else if (sistemaReservas[i][j] == "O")
                    {
                        contadorLibre++;
                    }
                }
            }

            Console.WriteLine("El número de habitaciones disponibles es: " + contadorLibre);
            Console.WriteLine("El número de habitaciones reservadas es: " + contadorOcupado);
            Console.WriteLine("¿Quieres reservar una habitación? (S/N): ");
            string respuesta = Console.ReadLine().ToUpper();

            if (respuesta == "S")
            {
                Console.Write("Inserta la fila: ");
                int fila = Convert.ToInt32(Console.ReadLine());

                Console.Write("Inserta la columna: ");
                int columna = Convert.ToInt32(Console.ReadLine());

                if (fila >= 0 && fila < sistemaReservas.Length && columna >= 0 && columna < sistemaReservas[fila].Length)
                {
                    if (sistemaReservas[fila][columna] == "O")
                    {
                        sistemaReservas[fila][columna] = "X";
                        contadorLibre--;
                        contadorOcupado++;
                        Console.WriteLine("¡Has reservado una habitación!");

                        Console.WriteLine("Matriz actualizada: ");
                        for (int i = 0; i < sistemaReservas.Length; i++)
                        {
                            for (int j = 0; j < sistemaReservas[i].Length; j++)
                            {
                                Console.Write(sistemaReservas[i][j] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("La habitación no está libre para reservar.");
                    }
                }
                else
                {
                    Console.WriteLine("No hay ninguna habitación en esta posición.");
                }
            }
        }
    }



public class Program
{
    public static void Main()
    {
        int[,] ventas = {
            { 10, 5, 8, 12 },
            { 7, 15, 20, 10 },
            { 5, 3, 6, 8 },
            { 12, 8, 10, 18 },
            { 6, 10, 15, 7 }
        };
        int suma = 0;
        int filas = ventas.GetLength(0);
        int columnas = ventas.GetLength(1);
        int sumaFilas = 0;
        int sumaColumnas = 0;
		
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                sumaFilas += ventas[i, j];
            }
            Console.WriteLine("La suma de la fila " + (i + 1) + " es de " + sumaFilas);
            sumaFilas = 0; 
        }

        for (int j = 0; j < columnas; j++)
        {
            for (int i = 0; i < filas; i++)
            {
                sumaColumnas += ventas[i, j];
            }
            Console.WriteLine("La suma de la columna " + (j + 1) + " es de " + sumaColumnas);
            sumaColumnas = 0; 
        }

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                suma += ventas[i, j];
            }
        }
        Console.WriteLine("La suma total de las ventas es de " + suma);
    }
}

	
public class Program
{
	public static void Main()
	{
		bool[,] asistencia = {
		{ true, false, true, true, false },
		{ true, true, true, true, true },
		{ false, false, true, true, false },
		{ true, true, true, false, true },
		{ true, false, true, false, true }
};
		Console.Write("¿Qué día? 1-5 :");
		int dia = Convert.ToInt32(Console.ReadLine());
		Console.Write("¿Qué semana? 1-5: ");
		int semana = Convert.ToInt32(Console.ReadLine());
		if (dia >=1 && dia <= 5 && semana >= 1 && semana <= 5)
		{
			bool asistenciaEstudiante = asistencia[dia - 1, semana - 1]; //restamos 1 pq la posición empieza en 0.
			if (asistenciaEstudiante)
			{
				Console.WriteLine("El estudiante SÍ asistió.");
			}
			else
			{
				Console.WriteLine("El estudiante NO asistió.");
			}
		}
	}
}

	
public class Program
{
	public static void Main()
	{
int[][] matriz = { //definición de la matriz
new int[] { 1, 1, 1 },
new int[] { 1},
new int[] { 1, 1, 2 }
};
for (int i = 0; i < 3; i++) //iteramos por cada elemento hasta 3 veces
{
int sumaFila = 0;
int sumaColumna = 0;
for (int j = 0; j < matriz[i].Length; j++) //itera por cada columna y va incrementando el contador
{
if (i < matriz[j].Length) //dentro del bucle anidado, si el valor es adquirido es menor a la longitud de la columna
{
sumaFila += matriz[i][j]; //la variable sumaFila adquiere los valores que ha ido incrementando el contador fila
}
if (j < matriz[i].Length && i < matriz[j].Length) //hasta que la columna llegue a tantas veces la longitud de la columna y fila
{
sumaColumna += matriz[i][j]; //la variable columna adquiere los valores que se le han ido incrementando
}
}
Console.WriteLine("Suma de fila: " + sumaFila);
Console.WriteLine("Suma de columna: " + sumaColumna);
}
	}
}