using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    public class MillasKilometros : FormulaMatematica
    {
 
        public double Millas { get; set; }

        public override double Calcular()
        {
            return Millas * 1.60934; 


        }

        public override void Imprimir()
        {
            Console.WriteLine();
            Console.WriteLine($"Las milla {Millas} a kilometros equivalen a : {Calcular().ToString("F2")}");
        }
    }
}
