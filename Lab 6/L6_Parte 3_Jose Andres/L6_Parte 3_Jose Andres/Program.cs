using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su puntuación (0.0, 0.4, 0.6 o más): ");
        double puntuacion = double.Parse(Console.ReadLine());

        string nivel;
        double dinero;

        if (puntuacion == 0.0)
        {
            nivel = "Inaceptable";
        }
        else if (puntuacion == 0.4)
        {
            nivel = "Aceptable";
        }
        else if (puntuacion >= 0.6)
        {
            nivel = "Meritorio";
        }
        else
        {
            Console.WriteLine("Puntuación inválida.");
            return;
        }

        dinero = 2400 * puntuacion;

        Console.WriteLine("Nivel: " + nivel);
        Console.WriteLine("Dinero recibido: " + dinero);
    }
}