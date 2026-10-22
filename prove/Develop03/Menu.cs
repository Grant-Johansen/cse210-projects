class Menu
{
    public void builtMenu()
    {
       Console.WriteLine(@"
       Which would you like to choose? 
       1. Jeremiah 7:23
       2. Ecclesiastes 3:1
       3. 1 Corinthians 3:6
       4. Ether 12:37
       5. Isaiah 54:7-8
       6. Make your own entry
       "); 
       string userChoice = Console.ReadLine();
       if (userChoice == "1")
        {
            Scripture myScripture = new Scripture("Jeremiah", 7, 23,
            "But this thing commanded I them, saying, Obey my voice, and I will be your God, and ye shall be my people: and walk ye in all the ways that I have commanded you, that it may be well unto you.");
            while (myScripture.NumberOfHiddenWords() != 0)
            {
                myScripture.ShowScripture();
                Console.WriteLine("Click Enter to hide some words!");
                string enterUserEntry = Console.ReadLine();
                myScripture.HideSomeWords();
            }
            
            
        }
        else if (userChoice == "2")
        {
            Scripture myScripture = new Scripture("Ecclesiastes", 3,1, "To every thing there is a season, and a time to every purpose under the heaven.");
            myScripture.ShowScripture();
        }
        else if (userChoice == "3")
        {
            Scripture myScripture = new Scripture("1 Corinthians", 3, 6,"I have planted, Apollos watered; but God gave the increase.");
            myScripture.ShowScripture();
        }
        else if (userChoice == "4")
        {
            Scripture myScripture = new Scripture("Ether", 12, 37,"And it came to pass that the Lord said unto me: If they have not charity it mattereth not unto thee, thou hast been faithful; wherefore, thy garments shall be made clean. And because thou hast seen thy weakness thou shalt be made strong, even unto the sitting down in the place which I have prepared in the mansions of my Father.");
            myScripture.ShowScripture();
        }
        else if (userChoice == "5")
        {
            Scripture myScripture = new Scripture("Isaiah", 54, 7, 8, "For a small moment have I forsaken thee; but with great mercies will I gather thee. In a little wrath I hid my face from thee for a moment; but with everlasting kindness will I have mercy on thee, saith the Lord thy Redeemer.");
            myScripture.ShowScripture();
        }
        else
        { //user makes their own entry
            Console.WriteLine("What is the name of the book?");
            string bookName = Console.ReadLine();
            Console.WriteLine("What is the chapter Number?");
            string chptNum = Console.ReadLine();
            int finChptNum = int.Parse(chptNum);
            Console.WriteLine("What is the first verse number?");
            string startingVer = Console.ReadLine();
            int finStartingVer = int.Parse(startingVer);
            Console.WriteLine("What is the last verse number (if only one verse then enter 0)");
            string endingVer = Console.ReadLine();
            int finEndingVer = int.Parse(endingVer);
            Console.WriteLine("Enter in the verse text");
            string verText = Console.ReadLine();

            Scripture myScripture = new Scripture(bookName, finChptNum, finStartingVer, finEndingVer, verText);
            myScripture.ShowScripture();
            
        }
    }
}

/************************************************
* Jeremiah 7:23 "But this thing commanded I them, saying, Obey my voice, and I will be your God, 
and ye shall be my people: and walk ye in all the ways that I have commanded you, that it may be 
well unto you."
* Ecclesiastes 3:1 "To every thing there is a season, and a time to every purpose under the 
heaven."
* 1 Corinthians 3:6 "I have planted, Apollos watered; but God gave the increase."
* Ether 12:37 "And it came to pass that the Lord said unto me: If they have not charity it 
mattereth not unto thee, thou hast been faithful; wherefore, thy garments shall be made clean. And
because thou hast seen thy weakness thou shalt be made strong, even unto the sitting down in the 
place which I have prepared in the mansions of my Father."
*************************/