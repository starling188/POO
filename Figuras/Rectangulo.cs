using Poo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Rectangulo :Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }


        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
