using System;

class Program
{
    static void Main()
    {
        // 1 y 2. Pedir dato y guardarlo en string
        Console.Write("Ingrese la distancia al planeta más cercano: ");
        string entradaRadar = Console.ReadLine();

        // 3. Convertir string a int usando Parse
        int distancia = int.Parse(entradaRadar);

        // 4. Sumar margen de seguridad
        int distanciaFinal = distancia + 100;

        // Mostrar resultado
        Console.WriteLine("Distancia original: " + distancia);
        Console.WriteLine("Distancia final con margen de seguridad: " + distanciaFinal);

        Console.ReadLine();
    }
}
