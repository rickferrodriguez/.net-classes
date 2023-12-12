namespace SuperHeroesApp.Models;
public class SuperPower
{
  public string Name;
  public string Description;
  public LevelOfPower Level;

  public SuperPower()
  {
    Level = LevelOfPower.Level1;
  }
}
public enum LevelOfPower
{
  Level1,
  Level2,
  Level3
}
