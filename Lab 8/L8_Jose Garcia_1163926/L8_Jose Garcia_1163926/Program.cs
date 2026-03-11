using System;
class Program
{
    static void Main()
    {
        // Entrada de usuario
        Console.Write("¿Cómo te llamas? ");
        string nombre = Console.ReadLine();
        // Salida de datos
        Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");

        int aprobados = 0;
        int reprobados = 0;
        double suma = 0;
        double nota;
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Ingrese la nota del estudiante " + i + ": ");
            nota = Convert.ToDouble(Console.ReadLine());

            suma += nota;

            if (nota >= 61)
            {
                aprobados++;
            }
            else
            {
                reprobados++;
            }
        }
        double promedio = suma / 10;

        Console.WriteLine("Promedio de la clase: " + promedio);
        Console.WriteLine("Cantidad de aprobados: " + aprobados);
        Console.WriteLine("Cantidad de reprobados: " + reprobados);
    }
}
