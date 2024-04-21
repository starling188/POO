using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    public class Persona
    {
        public string? Nombre { get; set; }
        public string? Ciudad { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, string ciudad, int edad)
        {
            Nombre = nombre;
            Ciudad = ciudad;
            Edad= edad;
            
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Ciudad: {Ciudad}");
            Console.WriteLine($"Edad: {Edad} años");
        }


        public int CalcularEdadEnAños()
        {
            DateTime fechaActual = DateTime.Now;
            int anioActual = fechaActual.Year;

            return anioActual - Edad;
        }







    }
}

