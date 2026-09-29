using System;
using System.Globalization;

string usernumber;
double listsum = 0;
double listaverage;
int amountinlist = 0;

List<double> numbers = new List<double>();
Console.WriteLine("Enter a list of nubmers, type 0 when finished.");

do
{
    Console.WriteLine("Enter number (Enter 0 to stop):");
    usernumber = Console.ReadLine();
    double inputnumber = double.Parse(usernumber);
    numbers.Add(inputnumber);
    amountinlist ++;

} while (usernumber != "0");

double largestnumber = numbers[0];
double lastnumber = numbers.Count -1;
foreach (double number in numbers)
{
    listsum += number;
    if (number != lastnumber && largestnumber <= number)
    {
        largestnumber = number;
    }

}

double smallestpositivenumber = largestnumber;

foreach (double number in numbers)
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
Console.WriteLine($"Here is the average of the list: {listaverage}");



