using System;
{
    int grade;
    int lateMinutes;
    int solvency;
    int id;
    int calculator;

    Console.Write("Ingrese su nota previa: ");
    grade = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingrese los minutos de llegada tarde: ");
    lateMinutes = Convert.ToInt32(Console.ReadLine());

    Console.Write("¿Tiene solvencia de pagos? (1 = Sí, 0 = No): ");
    solvency = Convert.ToInt32(Console.ReadLine());

    Console.Write("¿Trae identificación física? (1 = Sí, 0 = No): ");
    id = Convert.ToInt32(Console.ReadLine());

    Console.Write("¿Trae calculadora permitida? (1 = Sí, 0 = No): ");
    calculator = Convert.ToInt32(Console.ReadLine());

    if (grade >= 61)
        Console.WriteLine("Requisito académico aprobado.");
    else
        Console.WriteLine("Requisito académico NO aprobado.");

    if (lateMinutes <= 10)
        Console.WriteLine("Hora válida.");
    else
        Console.WriteLine("Llegada tarde: fuera de tiempo.");

    if (solvency == 1)
        Console.WriteLine("Solvencia validada.");
    else
        Console.WriteLine("Sin solvencia.");

    if (id == 1)
        Console.WriteLine("Identificación validada.");
    else
        Console.WriteLine("Sin identificación.");

    if (calculator == 1)
        Console.WriteLine("Calculadora permitida: OK.");
    else
        Console.WriteLine("Sin calculadora permitida.");

    if (grade >= 61 && lateMinutes <= 10 && solvency == 1 && id == 1)
        Console.WriteLine("Acceso a sala de examen concedido.");
    else
        Console.WriteLine("Acceso denegado.");

    if (lateMinutes > 0 && lateMinutes <= 10)
        Console.WriteLine("Advertencia: llegó tarde, pero aún puede ingresar.");
}