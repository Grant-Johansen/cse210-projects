using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment ("Ash", "Math");
        MathAssignment myMathAssignment = new MathAssignment("John", "Calculas", "7.8", "1-10");;
        WritingAssignment myWritingAssignment = new WritingAssignment("David", "German", "The Great War");

        Console.WriteLine(myAssignment.GetSummary());
        Console.WriteLine(myMathAssignment.GetSummary());
        Console.WriteLine(myMathAssignment.GetHomeworkList());
        Console.WriteLine(myWritingAssignment.GetSummary());
        Console.WriteLine(myWritingAssignment.GetWritingInformation());

    }
}