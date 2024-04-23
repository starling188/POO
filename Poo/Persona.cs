using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    public abstract class Persona
    {
        public string? Nombre { get; set; }
        public string? Ciudad { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Persona(string nombre, string ciudad, DateTime fechaNamicimiento)
        {
            Nombre = nombre;
            Ciudad = ciudad;
            FechaNacimiento = fechaNamicimiento;
            
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Ciudad: {Ciudad}");
            Console.WriteLine($"Edad: {CalcularEdadEnAños()} años");
        }


        public virtual int CalcularEdadEnAños()
        {
            DateTime yearactual = DateTime.Now;
            int edad = yearactual.Year - FechaNacimiento.Year;

            return edad;
        }







    }
}

