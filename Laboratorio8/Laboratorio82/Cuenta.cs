using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio82
{
    public class Cuenta
    {
            private string idCuenta;

            public Cuenta(string printIdCuenta)
            {
                this.idCuenta = printIdCuenta;
                System.Console.WriteLine(
                    "Constructor Class Base para cuenta {0}", printIdCuenta);
            }

            public virtual void CalcularIntereses()
            {
                System.Console.WriteLine(
                    "Cuenta.CalcularIntereses() efectuado para la cuenta {0}",
                    this.idCuenta);
            }

            public string getIdCuenta()
            {
                return this.idCuenta;
            }
        
    }
}
