using System;

namespace Laboratorio31
{
    public class CalculosMatematicos
    {


        public CalculosMatematicos() {}

        public double Calcular(double x, double y)
        {
            double a, b, resu;

            a = x + y;
            b = x - y;
            resu = a * b;

            return resu;
        }
    }
}
