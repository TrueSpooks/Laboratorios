using System;
class Program
{
    static void Main(string[] args)
    {
        // Variable
        string nombre;

        // Input
        Console.Write("Ingrese su nombre: ");
        nombre = Console.ReadLine();

        // Llamada a los métodos
        Saludo(nombre);
        InfoCurso();

        Console.ReadKey();
    }

    // Método 1: recibe el nombre como parámetro
    static void Saludo(string nombre)
    {
        Console.WriteLine("Hola, " + nombre + "! Bienvenido a programación, la clase mortal!");
    }

    // Método 2: no recibe parámetros
    static void InfoCurso()
    {
        Console.WriteLine("Curso: Pensamiento Computacional");
        Console.WriteLine("Número del laboratorio: 9");
    }
}