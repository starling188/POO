using Poo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Triangulo : Figura
    {

        // Propiedades de Triángulo
        public double Base { get; set; }
        public double Altura { get; set; }


        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }
    }
}
