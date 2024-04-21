using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    public abstract class Figura
    {
        public abstract double CalcularArea();
    }


    public class Rectangulo : Figura
    {
       
        public double Base { get; set; }
        public double Altura { get; set; }

        
        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }

 
    public class Circulo : Figura
    {
      
        public double Radio { get; set; }

       
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }
    }

   
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
