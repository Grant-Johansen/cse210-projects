using System;
using System.Globalization;

string usernumber;
int listsum = 0;
float listaverage;
int amountinlist = 0;

List<int> numbers = new List<int>();
Console.WriteLine("Enter a list of nubmers, type 0 when finished.");

do
{
    Console.WriteLine("Enter number (Enter 0 to stop):");
    usernumber = Console.ReadLine();
    int inputnumber = int.Parse(usernumber);
    numbers.Add(inputnumber);
    amountinlist ++;

} while (usernumber != "0");

int largestnumber = numbers[0];
int lastnumber = numbers.Count -1;
foreach (int number in numbers)
{
    listsum += number;
    if (number != lastnumber && largestnumber <= number)
    {
        largestnumber = number;
    }

}

int smallestpositivenumber = largestnumber;

foreach (int number in numbers)
{
        if (number > 0 && number <= smallestpositivenumber)
    {
        smallestpositivenumber = number;
    }
    
}
listaverage = listsum/(amountinlist);



Console.WriteLine($"Here is the sum: {listsum}");
Console.WriteLine($"Here is the largest number: {largestnumber}");
Console.WriteLine($"Here is the smallest positive number: {smallestpositivenumber}");
Console.WriteLine(amountinlist);
Console.WriteLine($"Here is the average of the list: {listaverage}");



