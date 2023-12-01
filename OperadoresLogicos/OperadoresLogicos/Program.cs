// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Clase de operadores lógicos (&& , ||, ! , ^)
// ! -> negación
// ^ -> exclusive OR en otras palabras es como negar un OR, en donde es true si x = true y 'y' = false (alrevés)

using System.Reflection.Metadata;

bool valor2()
{
  Console.WriteLine("Evaluates the second value");
  return true;
}
// bool valor1 = true;
// bool valor3 = false;
// bool valor4 = false;

// otra forma te crear multiples variables booleanas es la siguiente
var (valor1, valor3, valor4) = (false, false, false);

// and &&
bool result = valor1 && valor2(); //true (if) es decir si los dos son true da true y si uno de los dos es false da false
bool resultado = valor1 && valor3 && valor2(); // false si alguno es false da false directamente, no evalua los demas valores

Console.WriteLine("result is: " + result + " y resultado es: " + resultado);

// OR ||
bool res = valor1 || valor3 || valor4; // true (or) es decir si el primero es true deja de evaluar y devuelve true

Console.WriteLine("el operador OR es: " + res);

// negated !
bool resNegated = !valor1 && valor2();
Console.WriteLine("resultado negado es: " + resNegated); // deberia dar false, valor1 era true negado es false

// XOR exclusive or
bool resXor = valor1 ^ valor2();
Console.WriteLine("XOR result is:" + resXor); // da false porque ambos son iguales (true ^ true)
bool resXorNeg = !valor1 ^ valor2();
Console.WriteLine("XOR negado da: " + resXorNeg); // da true porque son opuestos ( true(negado) ^ true) => false ^ true

// combinacion de operadores logicos

Console.WriteLine("Combinación de operadores lógicos");
bool resultAndOr = (valor1 && valor2()) || valor3;
Console.WriteLine("El resultado And or es: " + resultAndOr);
System.Console.WriteLine("que diferencia tiene"); // no tiene ninguna diferencia