using System;
class Program
{
    static void Main()
    {
        int userId;
        int pin;
        int token;
        int secureMode;

        Console.WriteLine("Ingrese su ID: ");
        userId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese su PIN: ");
        pin = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el token de seguridad: ");
        token = Convert.ToInt32(Console.ReadLine());

        Console.Write("¿Modo seguro activado? (1 = Sí, 0 = No): ");
        secureMode = Convert.ToInt32(Console.ReadLine());

        if (userId == 2026)
            Console.WriteLine("Usuario reconocido.");
        else
            Console.WriteLine("Usuario no reconocido.");

        if (pin == 1234)
            Console.WriteLine("PIN correcto.");
        else
            Console.WriteLine("PIN incorrecto.");

        if (token == 777)
            Console.WriteLine("Token válido.");
        else
            Console.WriteLine("Token inválido.");

        if (secureMode == 1)
            Console.WriteLine("Modo seguro activado: se aplican reglas extra.");
        else
            Console.WriteLine("Modo seguro desactivado.");

        if (userId == 2026 && pin == 1234 && token == 777)
            Console.WriteLine("Acceso total concedido.");
        else
            Console.WriteLine("Acceso denegado.");

        if (secureMode == 1)
        {
            if (token >= 700)
                Console.WriteLine("Regla extra aprobada.");
            else
                Console.WriteLine("Regla extra fallida.");
        }


    }
}