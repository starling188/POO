// See https://aka.ms/new-console-template for more information

using Poo;


//PUNTO 1

Persona persona1 = new Persona("Juan", "Buenos Aires", 30);
persona1.MostrarInfo();
int edadEnAnios = persona1.CalcularEdadEnAños();
Console.WriteLine($"La edad de {persona1.Nombre} es aproximadamente {edadEnAnios} años.");


//PUNTO 2

Estudiante estudiante1 = new Estudiante("Pepe", "pr", 30, "Software", "2022-2031");
estudiante1.MostrarInfo();


