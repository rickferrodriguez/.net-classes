namespace SuperHeroesApp.Models;

public class AntiHero : SuperHero
{
  private string _nemesis;

  public int NemesisId;

  public string Nemesis
  {
    get { return _nemesis; }
    set
    {
      if (!string.IsNullOrWhiteSpace(value))
      {
        _nemesis = value.Trim();
      }
      else
      {
        Console.WriteLine("Type a available value for the name");
      }
    }
  }

  public AntiHero()
  {
    NemesisId = 1;
    Nemesis = "Default Nemesis";
  }

  public string StringNemesis(string myNemesis)
  {
    string message = $"{Name}'s nemesis is: {myNemesis}";
    return message;
  }
}