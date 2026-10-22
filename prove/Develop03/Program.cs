using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        // Word myWord = new Word("Secret");

        // myWord.Display();
        // myWord.Hide();
        // myWord.Display();

        // ScriptureReference myReference = new ScriptureReference("Alma", 12, 12);
        // myReference.DisplayScriptureReference();
        Scripture myScripture = new Scripture("Moses", 1, 39,
        "Behold, this is my work and my glory to bring to pass the immortality and eternal life of man");
        myScripture.ShowScripture();
    }
}