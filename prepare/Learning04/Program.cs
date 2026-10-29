using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment ("Ash", "Math");

        Console.WriteLine(myAssignment.GetSummary());

    }
}