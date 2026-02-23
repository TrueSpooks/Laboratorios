using System;
{
    int code;
    int age;
    int terms;
    int twoFA;
    int score;

    Console.Write("Ingrese el código de activación: ");
    code = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingrese su edad: ");
    age = Convert.ToInt32(Console.ReadLine());

    Console.Write("¿Aceptó términos y condiciones? (1 = Sí, 0 = No): ");
    terms = Convert.ToInt32(Console.ReadLine());

    Console.Write("¿Activó verificación en dos pasos? (1 = Sí, 0 = No): ");
    twoFA = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingrese el puntaje de verificación: ");
    score = Convert.ToInt32(Console.ReadLine());

    if (code == 2026)
        Console.WriteLine("Código correcto.");
    else
        Console.WriteLine("Código incorrecto.");

    if (age >= 18)
        Console.WriteLine("Edad válida.");
    else
        Console.WriteLine("Edad no válida.");

    if (terms == 1)
        Console.WriteLine("Términos aceptados.");
    else
        Console.WriteLine("Debe aceptar términos.");

    if (twoFA == 1)
        Console.WriteLine("2FA activado.");
    else
        Console.WriteLine("2FA no activado.");

    if (score >= 70)
        Console.WriteLine("Puntaje suficiente.");
    else
        Console.WriteLine("Puntaje insuficiente.");

    if (code == 2026 && age >= 18 && terms == 1 && twoFA == 1 && score >= 70)
        Console.WriteLine("Cuenta activada exitosamente.");
    else
        Console.WriteLine("Cuenta NO activada.");
}