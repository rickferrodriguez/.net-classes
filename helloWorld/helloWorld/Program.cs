// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hola estoy aprendiendo a escribir en colemak-dhm mientras aprendo c#");
// Programa que calcula el area de un rectangulo.
using System.Runtime;

// esto es para los numeros enteros
// int ladoA;
// int ladoB;
// int resultado;

// Console.WriteLine("Calculadora de area de un rectangulo");
// Console.WriteLine("Por favor ingrese el valor del lado A");
// ladoA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Por favor ingrese el valor del lado B");
// ladoB = Convert.ToInt32(Console.ReadLine());

// resultado = ladoA * ladoB;
// Console.WriteLine("El area del rectangulo es: " + resultado);

// si quisieramos usar numeros con decimales tenemos que usar el tipo de dato double

// double ladoC;
// double ladoD;
// double resultadoDouble;

// Console.WriteLine("Calculadora de area de un rectangulo en decimales");
// Console.WriteLine("Por favor ingrese el lado C del rectangulo en decimales");
// ladoC = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Por favor ingrese el valor del lado D del rectangulo en decimales");
// ladoD = Convert.ToDouble(Console.ReadLine());

// resultadoDouble = ladoC * ladoD;
// Console.WriteLine("El area del rectangulo en decimales es: " + resultadoDouble);

// la palabra reservada 'var' sirve para declarar una variable que no tiene un tipo fijo.
var ladoA = 1.1; // esto al ser una variable necesita ser declarada primero
var ladoB = 1.1;
var resultado = 2.2;

// apesar de que una variable con 'var' puede tener cualquier tipo de dato, es necesario transformar el valor que se escribe en el console.writeline ya que es un string

Console.WriteLine("Calcula el area de un rectangulo con variables");
Console.WriteLine("Por favor ingrese el valor del lado A del rectangulo");
ladoA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Por favor ingrese el valor del lado B del rectangulo");
ladoB = Convert.ToDouble(Console.ReadLine());

resultado = ladoA * ladoB;
Console.WriteLine("El area del rectangulo es: " + resultado);