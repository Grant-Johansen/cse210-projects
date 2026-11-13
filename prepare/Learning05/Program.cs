using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square ("Red", 6);

        Console.WriteLine(s1.GetColor());
        Console.WriteLine(s1.GetArea());

        Circle s2 = new Circle ("Blue", 5);

        Console.WriteLine(s2.GetColor());
        Console.WriteLine(s2.GetArea());

        Rectangle s3 = new Rectangle ("Green", 9, 4);

        Console.WriteLine(s3.GetColor());
        Console.WriteLine(s3.GetArea());
    }   
}