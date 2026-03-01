using System;
class Program
{
    static void Main()
    {
        //Entrada de usuario
        Console.Write("¿Cómo te llamas?");
        string nombre = Console.ReadLine();

        //Salida de datos
        Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");

        Console.WriteLine("Ingrese la opcion de desee");
        Console.WriteLine("1. bicicleta");
        Console.WriteLine("2. Motocicleta");
        Console.WriteLine("3. Auto");
        Console.WriteLine("4. Camión");
        Console.WriteLine("5. Autobus");
        int opcion = Convert.ToInt32(Console.ReadLine());
        switch (opcion) {
            case 1:
                Console.WriteLine("No motorizado");
                break;
            case 2:
                Console.WriteLine("Ligero");
                break;
            case 3:
                Console.WriteLine("Mediano");
                break;
            case 4:
                Console.WriteLine("Pesado");
                break;
            case 5:
                Console.WriteLine("Transporte público");
                break;
            default: Console.WriteLine("ingreso una opcion no disponible");
                break;
        }
    }
}