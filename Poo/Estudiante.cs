using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    public class Estudiante : Persona
    {
        public string? Carrera { get; set; }

        public string? Matricula { get; set; }

        public Estudiante(string nombre, string ciudad, int edad, string carrera, string matricula) : base(nombre, ciudad, edad)
        {
            Carrera = carrera;
            Matricula = matricula;
        }




        public override void MostrarInfo()
        {
            base.MostrarInfo(); // Llama al método de la clase base para mostrar la información básica
            Console.WriteLine($"Carrera: {Carrera}");
            Console.WriteLine($"Matrícula: {Matricula}");
        }

    }
}
