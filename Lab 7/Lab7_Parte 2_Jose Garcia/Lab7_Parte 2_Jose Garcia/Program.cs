using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\nMENU DE CONVERSIONES");
            Console.WriteLine("1. Convertir Celsius a Fahrenheit");
            Console.WriteLine("2. Convertir Fahrenheit a Celsius");
            Console.WriteLine("3. Convertir Kilómetros a Millas");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese temperatura en Celsius: ");
                    double celsius = double.Parse(Console.ReadLine());
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine("Resultado: " + fahrenheit.ToString("F2") + " °F");
                    break;

                case 2:
                    Console.Write("Ingrese temperatura en Fahrenheit: ");
                    double f = double.Parse(Console.ReadLine());
                    double c = (f - 32) * 5 / 9;
                    Console.WriteLine("Resultado: " + c.ToString("F2") + " °C");
                    break;

                case 3:
                    Console.Write("Ingrese kilómetros: ");
                    double km = double.Parse(Console.ReadLine());
                    double millas = km * 0.621371;
                    Console.WriteLine("Resultado: " + millas.ToString("F2") + " millas");
                    break;

                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

        } while (opcion != 4);
    }
}