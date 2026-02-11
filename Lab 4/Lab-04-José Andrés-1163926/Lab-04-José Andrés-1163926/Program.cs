using System;
class Program {
    static void Main() {
        Console.Write("¿Cómo te llamas? ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Hola, " + nombre + "¡Bienvenido a C#!");
    }
}

using System;
class Program
{
    static void Main()
    {
        // Declaración de variables
        string modelo;
        int capacidadCarga;
        float nivelCombustible;
        bool motorSaltoActivo;

        // Solicitar datos al usuario
        Console.Write("Ingrese el modelo de la nave: ");
        modelo = Console.ReadLine();

        Console.Write("Ingrese la capacidad de carga: ");
        capacidadCarga = int.Parse(ConsoleReadLine());

        Console.Write("Ingrese el nivel de combustible: ");
        nivelCombustible = float.Parse(Console.ReadLine());

        Console.Write("¿El motor de salto está activo? (true/false): ");
        motorSaltoActivo = bool.Parse(Console.ReadLine());

        // Mostrar datos en un bloque organizado usando concatenacíón
        Console.WriteLine("\n--- FICHA TECNICA DE LA NAVE ---");
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Capacidad de carga: " + capacidadCarga);
        Console.WriteLine("Nivel de combustible: " + nivelCombustible);
        Console.WriteLine("Motor de salto activo: " + motorSaltoActivo);

        Console.ReadLine();
    }
}

using System;
class Program
{
    static void Main()
    {
        // Declarar variable short
        short sensoresActivos = 128;

        // Declarar variable int
        int registroProcesador;

        // Declarar el valor de sensoresActivos a registroProcesador
        registroProcesador = sensoresActivos;

        // Declarar variable double y asignarle el valor de registroProcesador
        double presicionTotal = registroProcesador;

        // Imprimir precisionTotal
        Console.WriteLine("Precision total: " + precisionTotal);

        Console.ReadLine();
    }
}

using System;
class Program
{
    static void Main()
    {
        // Declarar variable double
        double energiaGenerada = 987.65;

        // Crear variable int
        int energiaLimitada;

        // Casting explicito de double a int
        energiaLimitada = (int)energiaGenerada;

        // Imprimir ambos valores
        Console.WriteLine("Energia generada (double): " + energiaGenerada);
        Console.WriteLine("Energia limitada (int): " + energiaLimitada);

        Console.ReadLine();
    }
}

using System;
class Program
{
    static void Main()
    {
        // 
    }
}