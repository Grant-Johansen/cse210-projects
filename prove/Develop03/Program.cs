using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi! Welcome to the Scripture memorizer!");
        Console.WriteLine("We have some preset scriputres that you can choose from or you can enter in your own!");
        Menu myMenu = new Menu();
        myMenu.builtMenu();
        
        // Scripture myScripture = new Scripture("Moses", 1, 39,
        // "Behold, this is my work and my glory to bring to pass the immortality and eternal life of man");
        // myScripture.ShowScripture();
    }
}