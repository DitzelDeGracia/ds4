internal class Program
{
    private static void Main(string[] args) 
    {
        int primerNumero, segundoNumero, suma;

        Console.Write("Primer numero:");
        primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Segundo numero:");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        suma = primerNumero + segundoNumero;

        Console.WriteLine("La suma de {0} y {1} es:  {2}", primerNumero, segundoNumero, suma);

    }
}