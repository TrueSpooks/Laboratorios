class Program
{
    public Program()
    {
    }

    static void Main()
    {
        // 1. Declarar variable short
        short sensoresActivos = 128;

        // 2. Declarar variable int
        int registroProcesador;

        // 3. Asignar el valor de sensoresActivos a registroProcesador
        registroProcesador = sensoresActivos;

        // 4. Declarar variable double y asignarle el valor de registroProcesador
        double precisionTotal = registroProcesador;

        // 5. Imprimir precisionTotal
        Console.WriteLine("Precisión total: " + precisionTotal);

        Console.ReadLine();
    }
}
