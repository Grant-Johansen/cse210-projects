class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _repsonse;

    public void DisplayJournalEntry ()
    {
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine($"{_repsonse}");
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
        _repsonse = Console.ReadLine();
    }
}