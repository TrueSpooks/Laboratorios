using System;

class Program
{
    static void Main()
    {
        // Declarar string señalOxigeno
        string señalOxigeno = "true";

        // Convertir a bool usando Convert.ToBoolean()
        bool estadoOxigeno = Convert.ToBoolean(señalOxigeno);

        // Declarar string temperaturaCabina
        string temperaturaCabina = "22.8";

        // Convertir a double usando Convert.ToDouble()
        double tempoeratura = Convert.ToDouble(temperaturaCabina);

        // Mostrar resultados
        Console.WriteLine("Estado del oxígeno: " + estadoOxigeno);
        Console.WriteLine("Temperatura de la cabina: " + temperaturaCabina);

        Console.ReadLine();
    }
}