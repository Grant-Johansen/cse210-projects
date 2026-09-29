using System;
using System.Security.Cryptography;

class Program
{
    static string WelcomeMessage ()
    {
        return "Welcome to the program";
    }

    static string PromptForName ()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static float PromptForFavNumber ()
    {
         Console.WriteLine("Please enter your favorite number: ");
         string UserInput = Console.ReadLine();
         float FavNumber = float.Parse(UserInput);
         return FavNumber;
    }

    static int PromptForYearOfBirth ()
    {
        Console.WriteLine("Please enter the year you were born: ");
        string year = Console.ReadLine();
        int BirthYear = int.Parse(year);
        return BirthYear;
    }

    static float SquaredNum ( float FavNumber)
    {
        float NewNum = FavNumber * FavNumber;
        return NewNum;
    }

    static void EndPrompt (string name, float NewNum, int BirthYear)
    {
        int CurrentAge = 2026 - BirthYear;
        Console.WriteLine($"{name}, the square of your number is {NewNum}");
        Console.WriteLine($"{name}, you will be {CurrentAge}"); 
    }
    static void Main(string[] args)
    {
        WelcomeMessage ();

        string UserName = PromptForName();
        float FavNumber = PromptForFavNumber();
        int BirthYear = PromptForYearOfBirth();

        float NumberSquared = SquaredNum(FavNumber);

        EndPrompt(UserName, NumberSquared, BirthYear);
    }
}