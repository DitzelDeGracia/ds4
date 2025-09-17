internal class Program
{
    private static void Main(string[] args)
    {
        double base1, altura, resp;

        Console.Write("Primer numero:");
        base1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Segundo numero:");
        altura = Convert.ToInt32(Console.ReadLine());

        resp = perimetroRectangulo(base1, altura);

        Console.WriteLine("El perimetro es: {0}", resp);


    }
    public static double perimetroRectangulo(double base1, double altura)
    {
        double resp;
        resp = 2 * (base1 + altura);

        return resp;

    }
}