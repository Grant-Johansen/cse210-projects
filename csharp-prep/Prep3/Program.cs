using System;

class Program
{
    static void Main(string[] args)
    {
        String usernumber;
        String userguess;
        Console.WriteLine("What is the magic number?");
        usernumber = Console.ReadLine();
        int magicnumber = int.Parse(usernumber);
        bool done = false;
        do
        {
    
        Console.WriteLine("What is your guess?");
        userguess = Console.ReadLine();
        int guessnumber = int.Parse(userguess);
        
        if (guessnumber > magicnumber)
        {
            Console.WriteLine("Lower");
        }
        else if (guessnumber < magicnumber)
        {
            Console.WriteLine("Higher");
        }
            else
            {
                Console.WriteLine("You got it!");
                done = true;
            }
        } while (! done);
    }
}