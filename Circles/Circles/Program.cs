// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bienvenidos calculemos circulos");

// A = pi * (radio*radio) --- pi*r^2

double radio; // tambien puede ser declarada con 'var' pero se debe definir con un 0.0 ó 1.1 para que se entienda que es un double por ejemplo: var radio = 0.0;
const double ValorPI = Math.PI; // para usar Pi de forma correcta usa Math
double resultado;

Console.WriteLine("Por favor ingrese el valor del radio");
radio = Convert.ToDouble(Console.ReadLine());

resultado = ValorPI * Math.Pow(radio, 2); // para elevar un valor a la potencia que se necesite usa Math.pow
Console.WriteLine("El valor del area del circulo es: " + resultado);

