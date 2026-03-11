using System;

class Program
{
    static void Main()
    {
        int opcion;
        int clientes = 0;
        double totalVentas = 0;
        double monto;

        do
        {
            Console.WriteLine("\n--- MENU DE LA TIENDA ---");
            Console.WriteLine("1) Registrar compra");
            Console.WriteLine("2) Mostrar total de ventas");
            Console.WriteLine("3) Mostrar cantidad de clientes atendidos");
            Console.WriteLine("4) Salir");
            Console.Write("Seleccione una opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el monto de la compra: ");
                    monto = Convert.ToDouble(Console.ReadLine());

                    totalVentas += monto;
                    clientes++;

                    Console.WriteLine("Compra registrada correctamente.");
                    break;

                case 2:
                    Console.WriteLine("Total de ventas del dia: " + totalVentas);
                    break;

                case 3:
                    Console.WriteLine("Cantidad de clientes atendidos: " + clientes);
                    break;

                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opcion no valida.");
                    break;
            }

        } while (opcion != 4);
    }
}