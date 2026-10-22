using System.Diagnostics.Tracing;

class ScriptureReference
{
    private string _bookName;
    private int _chapter;
    // private int _verse;
    private List <int> _verse = new List<int>();

    public ScriptureReference (string name, int chapter, int verse)
    {
        _bookName = name;
        _chapter = chapter;
        _verse.Add(verse);
    }
    public ScriptureReference (string name, int chapter, int startVerse, int endVerse)
    {
        _bookName = name;
        _chapter = chapter;
        _verse.Add (startVerse);
        _verse.Add (endVerse);

    }
    public void DisplayScriptureReference()
    {
        if (_verse.Count >1)
        {
            Console.WriteLine($"{_bookName} {_chapter}:{_verse[0]}-{_verse[-1]}");
        }
        else
        {
            Console.WriteLine($"{_bookName} {_chapter}:{_verse[0]}");
        }

    }

    public string GetScriptureReference()
    {
        Console.WriteLine("What are the verses? Beginning:");
        String startVerseUser = Console.ReadLine();
        Console.WriteLine("What is the last verse?(if only one type NONE) Last:");
        String endVerseUser = Console.ReadLine();
        if (endVerseUser == "NONE")
        {
        string verseSelection = $"{startVerseUser}";
        return verseSelection; 

        } 
        else
        {
        string verseSelection = $"{startVerseUser}:{endVerseUser}"; 
        return verseSelection; 
        }
        // int startVerse = int.Parse(startVerseUser);
        // int endVerse = int.Parse(endVerseUser);
        
        
    }
    public string GetScriptureReferenceString()
    {
        Console.WriteLine("What is the name of the Book in your scripture reference?");
        String bookName = Console.ReadLine();
        return bookName;

    }

}
