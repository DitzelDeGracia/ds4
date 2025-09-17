internal class Program
{
    private static void Main(string[] args)
    {
        double radio, resp;

        Console.Write("Radio: ");
        radio = Convert.ToInt32(Console.ReadLine()); 


        resp = calculoArea(radio);

        Console.WriteLine("El área del círculo es: {0}", resp);
    }

    private static double calculoArea(double a)
    {
        double resultado;

        resultado = Math.PI * Math.Pow(a, 2);
        return resultado;
    }
}
