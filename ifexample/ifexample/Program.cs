// See https://aka.ms/new-console-template for more information

Console.WriteLine("Bienvenido al juego de 21 BlackJack");

int totalJugador = 0;
int totalDealer = 0;
string message = "";
string? switchControl = "";
var random = new Random();


Console.WriteLine("Bienvenido al CASINO \n Escriba menú para ingresar");
switchControl = Console.ReadLine();

while (true)
{
  if (switchControl == "menu")
  {
    Console.WriteLine("Escriba 21 para jugar");
    switchControl = Console.ReadLine();
    message = "";
  }
  else if (Convert.ToInt32(switchControl) == 21 && totalJugador < 22 && totalDealer < 22 )
  {
    Console.WriteLine("Toma tu carta");
    int barajaJugador = random.Next(1, 11);
    int barajaDealer = random.Next(1, 11);
    totalJugador = totalJugador + barajaJugador;
    totalDealer = totalDealer + barajaDealer;
    Console.WriteLine($"Tu carta es {barajaJugador} y el total que tienes es de {totalJugador}");
  }
  else if (message == "")
  {
    if (totalJugador > totalDealer && totalJugador <= 21)
    {
      message =
        $"Felicidades! Le ganaste al dealer porque tu total es de {totalJugador} y el del dealer es de: {totalDealer}";
    }
    else if (totalJugador < totalDealer && totalDealer <= 21)
    {
      message = $"El Dealer te ha ganado porque su total es de {totalDealer} y el tuyo es de {totalJugador}";
    }
    else if (totalJugador > 21)
    {
      message = $"Perdiste! Te pasaste de 21 tu valor fue de {totalJugador}";
    }
    else if (totalDealer > 21)
    {
      message = $"Ganaste! El dealer se pasó, su total es de: {totalDealer}";
    }
    else
    {
      message =
        $"Perdiste! tanto el jugador como el dealer tienen un mismo valor y ese es: {totalJugador}, pero la casa gana ";
    }

    Console.WriteLine(message);
  }
  else
  {
    totalJugador = 0;
    totalDealer = 0;
    switchControl = "menu";
  }
}