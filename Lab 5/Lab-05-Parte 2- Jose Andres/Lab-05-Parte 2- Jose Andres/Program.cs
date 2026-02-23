using System;
{
    {
        int pin;

        Console.Write("Ingrese el PIN: ");
        pin = Convert.ToInt32(Console.ReadLine());

        if (pin >= 1000 && pin <= 9999)
            Console.WriteLine("PIN de 4 dígitos: OK.");
        else
            Console.WriteLine("PIN inválido: debe tener 4 dígitos.");

        if (pin % 2 == 0)
            Console.WriteLine("PIN par.");
        else
            Console.WriteLine("PIN impar.");

        if (pin % 5 == 0)
            Console.WriteLine("Múltiplo de 5.");
        else
            Console.WriteLine("No es múltiplo de 5.");

        if ((pin >= 1000 && pin <= 9999) && (pin % 2 == 0) && (pin % 5 != 0))
            Console.WriteLine("PIN aceptado por política.");
        else
            Console.WriteLine("PIN rechazado por política.");
    }
}