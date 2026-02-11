using System;

namespace ProgramaEstudiante
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar el nombre del estudiante
            Console.Write("Ingrese el nombre del estudiante: ");
            string nombreEstudiante = Console.ReadLine();

            // Solicitar el nombre del curso
            Console.Write("Ingrese el nombre del curso: ");
            string nombreCurso = Console.ReadLine();

            // Mostrar los datos y mensajes personalizados
            Console.WriteLine("\nLab de Pensamiento Computacional");
            Console.WriteLine($"{nombreEstudiante}, entrena muchach@! Tienes que mejorar en {nombreCurso}.");
            Console.WriteLine("A que vienen tantos nervios?");
            Console.WriteLine("Tu puedes hacerlo.");

            // Finalizar el programa presionando una tecla
            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}