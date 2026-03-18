using System;

class Program
{
    static void Main(string[] args)
    {
        double lado, baseRect, alturaRect, baseTri, alturaTri;

        // Área del cuadrado
        Console.Write("Ingrese el lado del cuadrado: ");
        lado = Convert.ToDouble(Console.ReadLine());
        AreaCuadrado(lado);

        // Área del rectángulo
        Console.Write("\nIngrese la base del rectángulo: ");
        baseRect = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la altura del rectángulo: ");
        alturaRect = Convert.ToDouble(Console.ReadLine());
        AreaRectangulo(baseRect, alturaRect);

        // Área del triángulo
        Console.Write("\nIngrese la base del triángulo: ");
        baseTri = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la altura del triángulo: ");
        alturaTri = Convert.ToDouble(Console.ReadLine());
        AreaTriangulo(baseTri, alturaTri);

        Console.ReadKey();
    }

    // Método 1
    static void AreaCuadrado(double lado)
    {
        double area = lado * lado;
        Console.WriteLine("Área del cuadrado: " + area);
    }

    // Método 2
    static void AreaRectangulo(double baseRect, double alturaRect)
    {
        double area = baseRect * alturaRect;
        Console.WriteLine("Área del rectángulo: " + area);
    }

    // Método 3
    static void AreaTriangulo(double baseTri, double alturaTri)
    {
        double area = (baseTri * alturaTri) / 2;
        Console.WriteLine("Área del triángulo: " + area);
    }
}