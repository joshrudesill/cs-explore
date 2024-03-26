// See https://aka.ms/new-console-template for more information
using System.Drawing;
using System.IO.Compression;
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



// Opposites Attract
// bool test1 = LoveDetector.lovefunc(1,2);
// bool test2 = LoveDetector.lovefunc(10,20);
// Console.WriteLine(test1);
// Console.WriteLine(test2);

// // You only need one
// Console.WriteLine(Kata.Check([80, 117, 115, 104, 45, 85, 112, 115], 45));
// Kata.Check(["what", "a", "great", "kata"], "kat");

// //Sum of positives
// Console.WriteLine(Sum.PositiveSum([1, 2, 3, 4, 5]));
// Console.WriteLine(Sum.PositiveSum([1, 2, 3, 4, -5]));

// https://www.codewars.com/kata/546e2562b03326a88e000020 - Square every digit
Console.WriteLine(Square.squareDigits(123));
Console.WriteLine(Square.squareDigits(9119));

// https://www.codewars.com/kata/56747fd5cb988479af000028 - Get middle char

Console.WriteLine(Middle.middleChar("testing"));
Console.WriteLine(Middle.middleChar("test"));
public class Middle
{
    public static string middleChar(string v)
    { 
        if(v.Length % 2 == 0) {
            return $"{v.ElementAt(v.Length / 2 -1)}{v.ElementAt(v.Length / 2)}";
        } else {
            return $"{v.ElementAt(v.Length / 2)}";
        }
    }
}
public class LoveDetector
{
    public static bool lovefunc(int flower1, int flower2)
    { 
        if(flower1 % 2 != flower2 % 2) {
            return true;
        }
        return false;
    }
}

public class Kata
{
  public static bool Check(object[] a, object x)
  {
    return a.Contains(x);
  }
}
public class Sum
{
  public static int PositiveSum(int[] arr)
  {
    int solution = 0;
    foreach(int n in arr) {
        if(n >= 0) {
            solution += n;
        };
    }
    return solution;
  }
}
public class Square
{
  public static int squareDigits(int n)
  {
    string answer = "";
    string pre = n.ToString();
    foreach(char number in pre) {
        int p = int.Parse(number.ToString());  
        int x = p * p;
        answer += x.ToString();
    }
    return int.Parse(answer);
  }
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