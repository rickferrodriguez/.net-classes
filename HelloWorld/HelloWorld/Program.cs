// See https://aka.ms/new-console-template for more information
var ladoA = 0d;
var ladoB = 0d;
var resultado = 0d;

Console.WriteLine("Calcula el valor del area de un rectangulo");

Console.WriteLine("por favor ingrese el valor del lado A");
ladoA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Por favor ingrese el valor del lado B");
ladoB = Convert.ToDouble(Console.ReadLine());

resultado = ladoA * ladoB;
Console.WriteLine("El valor del area del rectángulo es: " + resultado);
