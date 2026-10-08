using System;
using System.ComponentModel.Design;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        Journal myJournal = new Journal();

        


        
        int response = myMenu.ProcessMenu();


        while (response !=5)
        {
            response = myMenu.ProcessMenu();
            
            switch (response)
            {
                case 1:
                    Console.WriteLine("Create");
                    myJournal.CreateEntry();
                    break;
                    //Call Create JournalEntry()
                case 2: 
                    myJournal.DisplayJournal();
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