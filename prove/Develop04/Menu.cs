class Menu
{
    string _userChoice;

    public void MenuOptions()
    {
        Console.WriteLine("Type the number of the option you want to do:");
        Console.WriteLine("");
        Console.WriteLine("1. BaseActivity");
        Console.WriteLine("2. Listing");
        Console.WriteLine("3. Reflection");
        Console.WriteLine("4. Quit");

        _userChoice = Console.ReadLine();

        while (_userChoice != "4")
        {
            if (_userChoice == "1")
            {
                //Call Breathing Activity
            }
            else if (_userChoice =="2")
            {
                //Call Listening Activity
            }
            else if (_userChoice =="3")
            {
                //Call Reflection Activity 
            }
            else if (_userChoice =="4")
            {
                Console.WriteLine("Goodbye.");
            }
            else
            {
                Console.WriteLine("You entered an invalid response, try again.");
            }
        }

    }
}