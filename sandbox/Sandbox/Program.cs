using System;
using System.IO.Compression;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        int x =10;
        int y =30;
        int z =35;
        if (x==10 && y == 30 || z == 35)
        {
            Console.WriteLine("X is 10");
            Console.WriteLine("Y is fun");

        }
        else if (x==20)
        {
            Console.WriteLine("X is 20");
        }
        else
        {
            Console.WriteLine("Default output");
        }
    }
}