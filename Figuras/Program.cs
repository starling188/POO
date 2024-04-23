

using Figuras;
using Poo;

Rectangulo rectangulo = new Rectangulo { Base = 5, Altura = 10 };
Circulo circulo = new Circulo { Radio = 7 };
Triangulo triangulo = new Triangulo { Base = 8, Altura = 12 };

// Calcular y mostrar el área de cada figura
Console.WriteLine($"Área del Rectángulo: {rectangulo.CalcularArea()}");
Console.WriteLine($"Área del Círculo: {circulo.CalcularArea()}");
Console.WriteLine($"Área del Triángulo: {triangulo.CalcularArea()}");