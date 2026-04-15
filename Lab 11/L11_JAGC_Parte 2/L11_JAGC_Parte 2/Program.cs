using System;

class Program
{
    static void Main()
    {
        string texto;
        string invertido = "";

        Console.Write("Ingrese una cadena: ");
        texto = Console.ReadLine();

        // Recorrer desde el final hasta el inicio
        for (int i = texto.Length - 1; i >= 0; i--)
        {
            invertido += texto[i];
        }

        Console.WriteLine("Texto invertido: " + invertido);
    }
}