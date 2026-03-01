using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el tipo de tarjeta: ");
        int tipo = int.Parse(Console.ReadLine());

        Console.Write("Ingrese su límite actual: ");
        double limite = double.Parse(Console.ReadLine());

        double aumento;

        switch (tipo)
        {
            case 1:
                aumento = limite * 0.25;
                break;
            case 2:
                aumento = limite * 0.35;
                break;
            case 3:
                aumento = limite * 0.40;
                break;
            default:
                aumento = limite * 0.50;
                break;
        }

        double nuevoLimite = limite + aumento;

        Console.WriteLine("Nuevo límite de crédito: " + nuevoLimite);
    }
}