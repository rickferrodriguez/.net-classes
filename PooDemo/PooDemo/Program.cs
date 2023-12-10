// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

// with this you can create a varible that has the type of the Class in this example
Pointer platziPointer = new Pointer();
Pointer platziPointer2 = new Pointer();

// you can use the properties from the Class and assign a value
platziPointer.Color = "Black";
platziPointer2.Color = "Black";

// a class is a mold that you can reuse
class Pointer
{
  // this down below are called properties
  public string Size;
  public string Color;
  public bool HasSticker;
  public short NumberOfButtons;
}

// the idea when you creat a class is that you have an object and try to guess what could have all of the same objects in common
class Keyboard
{
  public string Size;
  public string Color;
  public string Layout;
  public bool HasLeds;
  public bool HasCustomKeyCaps;
}

class Artist
{
  public string ArtisticName;
  public string RealName;
  public DateTime DateOfBirth;
  public List<string> Albums;
  public string Genre;
  public bool ItsABand;
}
 
 