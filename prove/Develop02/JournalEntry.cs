class CreateJournalEntry
{
    public string _date;
    public string _prompt;
    public string _repsonse;

    public void DisplayJournalEntry ()
    {
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine($"{_repsonse}");
    }

    public void CreateEntry()
    {
        _date = DateTime.Now.ToString();
        _prompt = "How was your day?"; //Note that later you must come back and switch this to be a list of prompts that generate randomly.
        Console.WriteLine($"{_prompt}:");
        _repsonse = Console.ReadLine();
    }
}