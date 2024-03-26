// See https://aka.ms/new-console-template for more information
using System.Drawing;
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");
Console.WriteLine("The current time is " + DateTime.Now);

string myString = "Hello";
int myInt = 8;
bool myBool = false;

if(myBool) { 
    Console.WriteLine("myBool is true");
} else if (!myBool && myInt == 8) {
    Console.WriteLine("myBool is false and myInt is 8");
} else {
    Console.WriteLine("myBool is false");
}



switch(myString) {
    case "Hello":
        Console.WriteLine("Hello how are you");
        break;
    case "Hello, World!":
        Console.WriteLine("Hello how is the world today");
        break;
    default:
        break;
}

string[] myArrayOfStrings = {"Hello", "world", "C#"};

for (int i = 0; i < myArrayOfStrings.Length; i++) 
{
  Console.WriteLine(myArrayOfStrings[i]);
}

foreach (string s in myArrayOfStrings) 
{
      Console.WriteLine(s);
}
List<string> myList = new List<string>(myArrayOfStrings);

Myself myself = new Myself("red", 26, "Josh");
myself.TellMeAboutYourself();
Console.WriteLine(myself.GetFavColor());

Myself[] arrOfPeople = {new Myself("green", 100, "Jane Doe"), new Myself("purple", 100, "John Doe")};
foreach (Myself person in arrOfPeople) 
{
      person.TellMeAboutYourself();
}
class Myself {
    public string favColor;
    public int age;
    public string name;
    public Myself(string color, int ageInYrs, string firstName) 
    {
        favColor = color;
        age = ageInYrs;
        name = firstName;
    }
    public void TellMeAboutYourself()
    {
      Console.WriteLine($"My name is {name}, my favorite color is {favColor} and I am {age}yo.");
    }
    public string GetFavColor()
    {
        return favColor;
    }
}
