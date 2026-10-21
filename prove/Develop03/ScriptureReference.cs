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
        Console.WriteLine($"{_bookName} {_chapter}:{_verse[0]}");
        
        // if (_verse.Count >1)
        // {
        //     Console.WriteLine(ScriptureReference());
        // }
        // else
        // {
            
        // }

    }

    // public string GetScriptureReference()
    // {
        
    // }
    // public string GetScriptureReferenceString()
    // {
        
    // }

}
