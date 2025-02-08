using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    public class AreaTriangulo : FormulaMatematica
    {

        public double Base { get; set; }

        public double Altura { get; set; }

        public override double Calcular()
        { 
            return ((Base * Altura) / 2);
        }

        public override void Imprimir()
        {
            Console.WriteLine(); 
            Console.WriteLine($"Un triangulo con su Base {Base} y su altura {Altura}, Su Area es de : {Calcular()}m2"); 
            
        }
    }
}
