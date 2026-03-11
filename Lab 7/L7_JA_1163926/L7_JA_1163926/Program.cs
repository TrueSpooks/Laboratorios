using System;
class Program
{
    static void Main()
    {
        int N = 0;

        Console.Write("¿Cuántos números desea sumar?: ");
        N = int.Parse(Console.ReadLine());

        // Validación: N debe ser mayor que 0
        while (N <= 0)
        {
            Console.Write("Error. Ingrese un número mayor que 0: ");
            N = int.Parse(Console.ReadLine());
        }

        int contador = 1;
        double suma = 0;

        while (contador <= N)
        {
            Console.Write("Ingrese un número: ");
            double numero = double.Parse(Console.ReadLine());

            suma += numero;
            contador++;
        }

        double promedio = suma / N;

        Console.WriteLine("La suma total es: " + suma);
        Console.WriteLine("El promedio es: " + promedio);
    }
}