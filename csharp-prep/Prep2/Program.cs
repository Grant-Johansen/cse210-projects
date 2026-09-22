using System;

class Program
{
    static void Main(string[] args)
    {
       String userGrade;
       String letterGrade;
       Console.WriteLine ("What is your number grade?");
       userGrade = Console.ReadLine();
       int numberGrade = int.Parse(userGrade);
       if (numberGrade >= 90)
        {
            letterGrade = "A";
        }
        else if (numberGrade < 90 && numberGrade >= 80)
        {
            letterGrade = "B";     
        }
        else if (numberGrade < 80 && numberGrade >= 70)
        {
            letterGrade = "C";
        }
        else if (numberGrade < 70 && numberGrade >= 60)
        {
            letterGrade = "D";
        }
        else 
            letterGrade = "F";

        Console.WriteLine($"You got a {letterGrade}");

        if (numberGrade >= 70)
            Console.WriteLine ("That means you passed this course!");
        else
            Console.WriteLine ("That means YOU FAILED THIS CITY! Oh uh, I mean course... Try better next time.");
    }   
}