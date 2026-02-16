using System;

class Program
{
    static void Main()
    {
        // Crear variable double
        double velocidadLuz = 299792.458;

        // Convertir a string usando ToString()
        string velocidadTexto = velocidadLuz.ToString();

        // Usar formato N3, separador de miles y 3 decimales
        string velocidadFormato = velocidadLuz.ToString("N3");

        // Mostrar resultados
        Console.WriteLine("Velocidad Original: " + velocidadTexto);
        Console.WriteLine("Velocidad con formato: " + velocidadFormato);

        Console.ReadLine();
    }
}