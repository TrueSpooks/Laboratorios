using System;

class Program
{
    static void Main()
    {
        // 1. Pedir el precio por galón como texto
        Console.Write("Ingrese el precio por galón de Litio: ");
        string entradaPrecio = Console.ReadLine()!;

        // 2. Convertir a double
        double precioGalon = Convert.ToDouble(entradaPrecio);

        // 3. Calcular el impuesto galáctico (12%)
        double impuesto = precioGalon * 0.12;

        // 4. Calcular el costo total
        double costoTotal = precioGalon + impuesto;

        // 6. Casting explícito a int (trunca los decimales)
        int costoFinal = (int)costoTotal;

        // 5. Mostrar el resultado
        Console.WriteLine("El costo final de suministro es: " + costoFinal);

        Console.ReadLine();
    }
}
