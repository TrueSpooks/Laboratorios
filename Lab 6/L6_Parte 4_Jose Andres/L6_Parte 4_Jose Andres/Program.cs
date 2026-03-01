using System;

class Program
{
    static void Main()
    {
        Console.Write("¿Quiere pizza vegetariana? (si/no): ");
        string opcion = Console.ReadLine().ToLower();

        string ingrediente = "";

        if (opcion == "si")
        {
            Console.WriteLine("Ingredientes disponibles:");
            Console.WriteLine("1. Pimiento");
            Console.WriteLine("2. Tofu");

            Console.Write("Elija un ingrediente: ");
            int eleccion = int.Parse(Console.ReadLine());

            switch (eleccion)
            {
                case 1:
                    ingrediente = "Pimiento";
                    break;
                case 2:
                    ingrediente = "Tofu";
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    return;
            }

            Console.WriteLine("\nPizza vegetariana con: Mozzarella, Tomate y " + ingrediente);
        }
        else if (opcion == "no")
        {
            Console.WriteLine("Ingredientes disponibles:");
            Console.WriteLine("1. Peperoni");
            Console.WriteLine("2. Jamón");
            Console.WriteLine("3. Salmón");

            Console.Write("Elija un ingrediente: ");
            int eleccion = int.Parse(Console.ReadLine());

            switch (eleccion)
            {
                case 1:
                    ingrediente = "Peperoni";
                    break;
                case 2:
                    ingrediente = "Jamón";
                    break;
                case 3:
                    ingrediente = "Salmón";
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    return;
            }

            Console.WriteLine("\nPizza no vegetariana con: Mozzarella, Tomate y " + ingrediente);
        }
        else
        {
            Console.WriteLine("Respuesta inválida.");
        }
    }
}