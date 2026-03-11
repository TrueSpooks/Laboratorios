using System;

class Program
{
    static void Main()
    {
        int numero;
        int suma = 0;
        int pares = 0;
        int impares = 0;

        Console.Write("Ingrese un número entero: ");
        numero = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= numero; i++)
        {
            suma += i;

            if (i % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
        }

        Console.WriteLine("La suma de los números desde 1 hasta " + numero + " es: " + suma);
        Console.WriteLine("Cantidad de números pares: " + pares);
        Console.WriteLine("Cantidad de números impares: " + impares);
    }
}