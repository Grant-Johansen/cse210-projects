class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;
    public string _entryQuestion;
    public string _journalEntry;
    public void DisplayJournalEntry ()
    {
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine($"{_response}");
    }

    public void CreateJournalEntry()
    {
        string [] prompts =
        {
            "How was your day?",
            "Talk about someone you met.",
            "What was something different that happended today?"
        };
        _date = DateTime.Now.ToString();
        _prompt = prompts [0]; //Note that later you must come back and switch this to be a list of prompts that generate randomly.
        Console.WriteLine($"{_prompt}:");
        _response = Console.ReadLine();
    }

    public string CreateFileSystemString()
    {
        string outputString = "";
        outputString = $"{_date}#{_prompt}#{_response}";
        return outputString;
    }
}