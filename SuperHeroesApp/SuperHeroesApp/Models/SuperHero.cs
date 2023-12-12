namespace SuperHeroesApp.Models
{
  public class SuperHero
  {
    public int Id;
    public string Name;
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
      string message = $"{Name} have this list of super powers: ";
      foreach (var power in Powers)
      {
        message = message + $"{power.Name}, ";
      }

      return message;
    }
  }
}