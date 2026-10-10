using System;
using System.ComponentModel.Design;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        new StreamWriter ("allJournals.txt");

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
                    Console.WriteLine(Path.GetFullPath("allJournals.txt"));
                    Console.WriteLine("Case 3 reached");
                    myJournal.WriteToFile("allJournals.txt");
                    Console.WriteLine("Case 3 finished");
                    break;
                    //Call WriteToFile()
                case 4:              
                    Console.WriteLine("Write");
                    myJournal.ReadFile("allJournals.txt");
                    break;
                    //Call ReadFile ()
            }  
        }
    }
}