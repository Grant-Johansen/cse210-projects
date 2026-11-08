class Menu
{
    int input = 0;

    public int MenuOptions()
    {
        while (input < 1 || input > 5)
        {
            
        
        Console.WriteLine("Type the number of the option you want to do:");
        Console.WriteLine("");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listing");
        Console.WriteLine("4. Quit");
        input = int.Parse(Console.ReadLine());
        }
    return input;
    }
}