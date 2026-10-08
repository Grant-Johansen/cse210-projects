using System;
using System.ComponentModel.Design;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        JournalEntry myEntry = new JournalEntry();

        myMenu.ProcessMenu();
        int response = 0;
        while (response !=5)
        {

            response = myMenu.ProcessMenu();
            switch (response)
            {
                case 1:
                    Console.WriteLine("Create");
                    myEntry.CreateJournalEntry();
                    break;
                    //Call Create JournalEntry()
                case 2: 
                    Console.WriteLine("Display");
                    break;
                    //Call DisplayJournal()
                case 3:
                    Console.WriteLine("Save");
                    break;
                    //Call ReadFromFile()
                case 4:              
                    Console.WriteLine("Write");
                    break;
                    //Call WriteToFile ()
            }  
        }
    }
}