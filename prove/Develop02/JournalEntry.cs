using System.Diagnostics.Contracts;

class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;
    public string _entryQuestion;
    public string _journalEntry;

    public JournalEntry ()
    {
        
    }
    public JournalEntry(string date, string prompt, string response)
{
    _date = date;
    _prompt = prompt;
    _response = response;
}
    public void DisplayJournalEntry ()
    {
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine($"{_response}");
    }

    public void CreateJournalEntry()
    {
        Random random = new Random ();
        int randomprompt = random.Next(1,6);
        string [] prompts =
        {
            "How was your day?",
            "Talk about someone you met.",
            "What was something different that happended today?",
            "Did anything hard happen today?",
            "How did you see the hand of the Lord today?",
            "What are you greatful for today?"
        };
        _date = DateTime.Now.ToString();
        _prompt = prompts [randomprompt]; //Note that later you must come back and switch this to be a list of prompts that generate randomly.
        Console.WriteLine($"{_prompt}");
        _response = Console.ReadLine();
    }

    public string CreateFileSystemString()
    {
        string outputString = "";
        outputString = $"{_date}#{_prompt}#{_response}";
        return outputString;
    }
}