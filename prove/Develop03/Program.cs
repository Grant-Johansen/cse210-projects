using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Word myWord = new Word("Secret");

        myWord.Display();
        myWord.Hide();
        myWord.Display();

        ScriptureReference myReference = new ScriptureReference("Alma", 12, 12);
        myReference.DisplayScriptureReference();
    }
}