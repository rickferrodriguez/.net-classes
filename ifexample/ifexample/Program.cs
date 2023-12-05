// See https://aka.ms/new-console-template for more information

Console.WriteLine("Bienvenido al juego de 21 BlackJack");

int totalJugador = new Random().Next(1, 21);
int totalDealer = new Random().Next(1, 21);
string message = "";
string? switchControl = "gato";


Console.WriteLine("Bienvenido al CASINO \n Escriba menú para ingresar");
switchControl = Console.ReadLine();

while (true)
{
  if (switchControl == "menu")
  {
    Console.WriteLine("Escriba 21 para jugar");
    switchControl = Console.ReadLine();
  }

  if (Convert.ToInt32(switchControl) == 21)
  {
    Console.WriteLine("Esperando al dealer...");
    if (totalJugador > totalDealer && totalJugador <= 21)
    {
      message =
        $"Felicidades! Le ganaste al dealer porque tu total es de {totalJugador} y el del dealer es de: {totalDealer}";
      switchControl = "menu";
    }
    else if (totalJugador < totalDealer)
    {
      message = $"El Dealer te ha ganado porque su total es de {totalDealer} y el tuyo es de {totalJugador}";
      switchControl = "menu";
    }
    else if (totalJugador > 21)
    {
      message = $"Perdiste! Te pasaste de 21 tu valor fue de {totalJugador}";
      switchControl = "menu";
    }
    else
    {
      message =
        $"Perdiste! tanto el jugador como el dealer tienen un mismo valor y ese es: {totalJugador}, pero la casa gana ";
      switchControl = "menu";
    }
  }

  Console.WriteLine(message);
}