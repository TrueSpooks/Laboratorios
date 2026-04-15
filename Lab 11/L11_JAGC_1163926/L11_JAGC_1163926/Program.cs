using System;
class Program
{
    static void Main()
    {
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Bienvenido(a), " + nombre);

        string contraseña;
        bool tieneMayuscula = false;
        bool tieneNumero = false;
        bool tieneEspecial = false;
        string errores = "";

        Console.Write("Ingrese la contraseña: ");
        contraseña = Console.ReadLine();

        // Verificar longitud
        if (contraseña.Length < 8)
        {
            errores += "falta longitud mínima, ";
        }

        // Recorrer la cadena
        foreach (char c in contraseña)
        {
            if (char.IsUpper(c))
            {
                tieneMayuscula = true;
            }

            if (char.IsDigit(c))
            {
                tieneNumero = true;
            }

            if (c == '@' || c == '#' || c == '$' || c == '%')
            {
                tieneEspecial = true;
            }
        }

        // Validar condiciones
        if (!tieneMayuscula)
        {
            errores += "falta mayúscula, ";
        }

        if (!tieneNumero)
        {
            errores += "falta número, ";
        }

        if (!tieneEspecial)
        {
            errores += "falta carácter especial, ";
        }

        // Resultado final
        if (errores == "")
        {
            Console.WriteLine("Contraseña válida");
        }
        else
        {
            // Quitar la última coma y espacio
            errores = errores.TrimEnd(',', ' ');
            Console.WriteLine("Inválida: " + errores);
        }
    }
}