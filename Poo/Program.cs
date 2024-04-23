// See https://aka.ms/new-console-template for more information

using Poo;


//PUNTO 1

DateTime fechaNacimiento = new DateTime(2004, 5, 5);

Persona persona = new Estudiante("oscar","PR",fechaNacimiento,"Matricula", "2022-7896");
Console.WriteLine("====Persona====");
int edad = persona.CalcularEdadEnAños();
persona.MostrarInfo();
Console.WriteLine($"La edad de {persona.Nombre} es {edad} years"  );
Console.WriteLine("\n");


//PUNTO 2

Console.WriteLine("====Estudiante====");

Estudiante estudiante1 = new Estudiante("Pepe", "pr", fechaNacimiento, "Software", "2022-2031");

estudiante1.MostrarInfoestudiante();


