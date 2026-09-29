using System;
using System.IO.Compression;
using System.Runtime.CompilerServices;

class Program
{
    // static double AddNumbers(double x, int y)
    // {
    //     return x + y;
    // }

    // static string MyName ()
    // {
    //     return "Bob";
    // }

    // static void DisplayGreeting (string name)
    // {
    //     Console.WriteLine($"Welcome {name}, its nice to meet you");
    // }
    static void Main(string[] args)
    {

        Circle myCircle = new Circle ();

        myCircle._radius = 10;

        double area = myCircle.GetArea();

        Console.WriteLine(area);
        
        // int x =10;
        // int y =30;
        // int z =35;
        // if (x==10 && y == 30 || z == 35)
        // {
        //     Console.WriteLine("X is 10");
        //     Console.WriteLine("Y is fun");

        // }
        // else if (x==20)
        // {
        //     Console.WriteLine("X is 20");
        // }
        // else
        // {
        //     Console.WriteLine("Default output");
        // }

        // bool done = false;
        // while (! done)
        // {
        //     Console.Write("Are we done (y/n)? ");
        //     done = Console.ReadLine() == "y";
        // }
        // bool done;
        // do
        // {
        //     Console.Write("Are we done (y/n)");
        //     done = Console.ReadLine() == "y";
        // } while (! done);

        // for(int i =100; i > 0; i-=5)
        // {
        //     Console.WriteLine(i);
        // }

        // List<string> myFriends = new List<string>  {"Bob", "Betty", "Bubba"};

        // myFriends.Add("Doug");

        // foreach(string friend in myFriends)
        // {
        //     Console.WriteLine (friend);
        // }


    }
}