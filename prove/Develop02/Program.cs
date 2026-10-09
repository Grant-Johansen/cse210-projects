using System;
using System.ComponentModel.Design;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        Journal myJournal = new Journal();

        int response = 0;
        // int response = myMenu.ProcessMenu();


        myJournal.ReadFile("allJournals.txt");
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
                    myJournal.ReadFile("allJournals.txt");
                    break;
                    //Call ReadFromFile()
                case 4:              
                    Console.WriteLine("Write");
                    myJournal.WriteToFile("allJournals.txt"); 
                    break;
                    //Call WriteToFile ()
            }  
        }
    }
}