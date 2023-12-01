// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Operadores relacionales (== | >= | <= | > < |)

using System.ComponentModel;

var (valor1, valor2, valor3) = (10, 22, 1);

bool resultado1 = valor1 == valor2;
Console.WriteLine("El resultado 1 es: " + resultado1); // es falso porque no son iguales

bool resultado2 = valor1 > valor3;
Console.WriteLine("El resultado 2 es: " + resultado2); // es verdadero porque 10 si es mayor que 1

bool resultado3 = valor1 <= valor2;
Console.WriteLine("El resultado 3 es: " + resultado3); // es verdadero porque 10 si es menor o igual que 22

bool resultado4 = valor1 != valor2;
Console.WriteLine("El resultado del valor 4 es: " + resultado4); // es verdadero porque si son valores diferentes
