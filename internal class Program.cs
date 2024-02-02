internal class Program
{
    private static void Main(string[] args)
    {

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[][] matriz = { //Declaración de las matrices y el valor de cada fila y columna.
        new int[] { 1, 1, 1 }, //primer elemento
        new int[] { 1}, //segundo elemento. cada arreglo puede tener longitud diferente. simplemente almacena ese valor.
        new int[] { 1, 1, 2 } //tercer elemento
};
for (int i = 0; i < 3; i++) //iteracion donde por el contador es igual la 0, vaya sumando +1 hasta 3 veces.
{
int sumaFila = 0; //Declaramos las variables suma fila y suma columna.
int sumaColumna = 0;
for (int j = 0; j < matriz[i].Length; j++) //iteracion donde el contador es igual a 0, suma+1 sin superar la cantidad de elementos de la primera fila.
{
if (i < matriz[j].Length) //cuando la iteracion no supera la cantidad de elementos de la fila, sumamos 
{
sumaFila += matriz[i][j];//accedemos a la fila de la matriz y para ello usamos los [] de posicion. hay que añadir [j] porque no solo es una fila, sino tambien la columna.
}
if (j < matriz[i].Length && i < matriz[j].Length) //se cumplen la condición anterior y la condición de que el contador no supera el número de valores del elemento.
{
sumaColumna += matriz[i][j]; //la variable sumaColumna adquiere el valor de la iteración de la columna.
}
}
Console.WriteLine("Suma de fila: " + sumaFila);
Console.WriteLine("Suma de columna: " + sumaColumna);
}
    }
}
}
}