using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string usernumber;
        int listsum = 0;
        int listaverage;
        int smallestpositivenumber;

        List<int> numbers = new List<int>();
        List<int> sortednumnbers = new List<int>();
        Console.WriteLine("Enter a list of nubmers, type 0 when finished.");

        do
        {
            Console.WriteLine("Enter number (Enter 0 to stop):");
            usernumber = Console.ReadLine();
            int inputnumber = int.Parse(usernumber);
            numbers.Add(inputnumber);
        } while (usernumber != "0");

        foreach (int number in numbers)
        {
            listsum += number;
        }


        Console.WriteLine($"Here is the sum: {listsum}");

    }
}