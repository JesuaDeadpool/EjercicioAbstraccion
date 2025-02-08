using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    public class Potencias : FormulaMatematica
    {

        public int BasePotencia { get; set; }
        public int Exponente { get; set; }

        public override double Calcular()
        {
            return Math.Pow(BasePotencia, Exponente); 
        }

        public override void Imprimir()
        {
            Console.WriteLine();
            Console.WriteLine($"{BasePotencia}^{Exponente} es igual a : {Calcular().ToString("F2")}");
        }
    }
}
