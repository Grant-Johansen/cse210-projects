using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string usernumber;
        int listsum = 0;
        int listaverage;
        int largestnumber = 0;

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

        int smallestpositivenumber = numbers[1];
        foreach (int number in numbers)
        {
            listsum += number;
            if (number < smallestpositivenumber && number > 0)
            {
                smallestpositivenumber = number;
            }
            if (largestnumber < number)
            {
                largestnumber = number;
            }
        }


        Console.WriteLine($"Here is the sum: {listsum}");
        Console.WriteLine($"Here is the largest number: {largestnumber}");
        Console.WriteLine($"Here is the smallest positive number: {smallestpositivenumber}");



    }
}