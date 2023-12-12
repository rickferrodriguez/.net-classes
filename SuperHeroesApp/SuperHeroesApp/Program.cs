var flyPower = new SuperPower();
flyPower.Name = "Fly Power";
flyPower.Description = "The hability to levitate in the air";
flyPower.Level = LevelOfPower.Level1;

var superStrong = new SuperPower();
superStrong.Name = "Super Strong";
superStrong.Description = "When a person has x10 strength than a Human";
superStrong.Level = LevelOfPower.Level2;

var bulletResistance = new SuperPower();
bulletResistance.Name = "Bullet Resistance";
bulletResistance.Description = "The skin is strong enough to don't get damage by a bullet";
bulletResistance.Level = LevelOfPower.Level3;

var superman = new SuperHero();
var hulk = new SuperHero();

// we create a variable to have a list of powers only for superman
List<SuperPower> superManSuperPowers = new List<SuperPower>();
superManSuperPowers.Add(flyPower);
superManSuperPowers.Add(superStrong);
superManSuperPowers.Add(bulletResistance);

superman.Id = 1;
superman.Name = "SuperMan";
superman.RealName = "Clark Kent";
superman.City = "Small Ville";
superman.Powers = superManSuperPowers;
superman.CanFly = true;
// we creat a variable to have a list of powers only for hulk
List<SuperPower> hulkSuperPowers = new List<SuperPower>();
hulkSuperPowers.Add(superStrong);
hulkSuperPowers.Add(bulletResistance);

hulk.Id = 2;
hulk.Name = "hulk";
hulk.RealName = "Bruce Banner";
hulk.City = "New York";
hulk.CanFly = false;
hulk.Powers = hulkSuperPowers;

Console.WriteLine(Convert.ToString(superman.UseSuperPowers()));


class SuperHero
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

// Creat a class only for the type SuperPowers
class SuperPower
{
  public string? Name;
  public string Description;
  public LevelOfPower Level;

  public SuperPower()
  {
    Level = LevelOfPower.Level1;
  }
}

// with 'enum' we can create a new value type only for the Level in the class SuperPower
enum LevelOfPower
{
  Level1,
  Level2,
  Level3
}
