using System;

class Program
{
    static void Main(string[] args)
    {
       
        Menu myMenu = new Menu();
        int response = 0;
        response = myMenu.MenuOptions();
        myMenu.MenuCases(response);

    }
}