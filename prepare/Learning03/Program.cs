using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Fraction first = new Fraction();
        Fraction second = new Fraction(5);
        Fraction third = new Fraction(1,3);
        Fraction fractionPractice = new Fraction();

        Console.WriteLine(first.GetDecimalValue());
        Console.WriteLine(first.GetFractionString());

        Console.WriteLine(second.GetDecimalValue());
        Console.WriteLine(second.GetFractionString());

        Console.WriteLine(third.GetDecimalValue());
        Console.WriteLine(third.GetFractionString());

        for (int i =0; i <20; i++)
        {
            int topNum = random.Next(1,51);
            int bottomNum = random.Next(1,51);

            fractionPractice.SetTop(topNum);
            fractionPractice.SetBottom(bottomNum);

            Console.WriteLine($"Fraction 1: string: {fractionPractice.GetFractionString()} Number: {fractionPractice.GetDecimalValue()}");
            
        }


    }
}