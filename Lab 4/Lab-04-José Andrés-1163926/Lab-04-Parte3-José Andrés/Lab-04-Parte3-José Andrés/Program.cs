using System;

class Program
{
    static void Main()
    {
        // 1. Declarar variable double
        double energiaGenerada = 987.65;

        // 2. Crear variable int
        int energiaLimitada;

        // 3. Casting explícito de double a int
        energiaLimitada = (int)energiaGenerada;

        // 4. Imprimir ambos valores
        Console.WriteLine("Energía generada: " + energiaGenerada);
        Console.WriteLine("Energía limitada: " + energiaLimitada);

        Console.ReadLine();
    }
}
