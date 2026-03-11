using System;

class Program
{
    static void Main()
    {
        int numero;
        int cantidad = 0;
        int positivos = 0;
        int negativos = 0;
        int suma = 0;

        Console.Write("Ingrese un número: ");
        numero = Convert.ToInt32(Console.ReadLine());

        while (numero != 0)
        {
            cantidad++;
            suma += numero;

            if (numero > 0)
            {
                positivos++;
            }
            else if (numero < 0)
            {
                negativos++;
            }

            Console.Write("Ingrese otro número: ");
            numero = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Cantidad de números ingresados: " + cantidad);
        Console.WriteLine("Cantidad de números positivos: " + positivos);
        Console.WriteLine("Cantidad de números negativos: " + negativos);
        Console.WriteLine("Suma total: " + suma);
    }
}