using System;

class Program
{
    static void Main(string[] args)
    {
       String userGrade;
       Console.WriteLine ("What is your number grade?");
       userGrade = Console.ReadLine();
       int numberGrade = int.Parse(userGrade);
       if (numberGrade >= 90)
        {
            Console.WriteLine ("Your letter grade is an A!");
        }
        else if (numberGrade < 90 && numberGrade >= 80)
        {
            Console.WriteLine ("Your letter grade is an B!");
        }
        else if (numberGrade < 80 && numberGrade >= 70)
        {
            Console.WriteLine ("Your letter grade is an C.");
        }
        else if (numberGrade < 70 && numberGrade >= 60)
        {
            Console.WriteLine ("Your letter grade is an D.");
        }
        else 
            Console.WriteLine ("Your letter grade is F");

        if (numberGrade >= 70)
            Console.WriteLine ("You passed this course!");
        else
            Console.WriteLine ("You failed this City! Oh uh, I mean course... Try better next time.");
    }   
}