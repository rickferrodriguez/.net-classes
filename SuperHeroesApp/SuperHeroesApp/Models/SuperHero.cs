namespace SuperHeroesApp.Models
{
  public class SuperHero
  {
    private string _name;
    public int Id;

    public string Name
    {
      get => _name;
      set
      {
        if (!string.IsNullOrWhiteSpace(value))
        {
          _name = value.Trim();
        }
        else
        {
          Console.WriteLine("Please, type a valid name");
        }
      }
    }

    private string NameAndRealName => $"{Name} ({RealName})";

    public string RealName;
    public string City;
    public List<SuperPower> Powers;
    public bool CanFly;

    public SuperHero()
    {
      Id = 1;
      // we initialize a new list of SuperPowers with zero values
      Powers = new List<SuperPower>();
      CanFly = false;
    }

    public string UseSuperPowers()
    {
      string message = $"{NameAndRealName} have this list of super powers: ";
      foreach (var power in Powers)
      {
        message = message + $"{power.Name}, ";
      }

      return message;
    }
  }
}