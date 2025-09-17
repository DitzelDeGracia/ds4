using Laboratorio31;
using System;
internal class Program

{
    private static void Main(string[] args)
    {
        double numero, numero1, resp;

        CalculosMatematicos calc = new CalculosMatematicos();

        Console.Write("Introduce el numero:");
        numero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce otro numero:");
        numero1 = Convert.ToInt32(Console.ReadLine());

        resp = calc.Calcular(numero, numero1);

        Console.WriteLine("El resultado de la operacion es: {0}",resp);
    }


}