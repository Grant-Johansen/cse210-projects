class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();


    public void DisplayJournal()
    {
        foreach(JournalEntry entry in _entries)
        {
            entry.DisplayJournalEntry();
        }
    }

    public void CreateEntry()
    {
        JournalEntry newEntry = new JournalEntry();
        newEntry.CreateJournalEntry();
        _entries.Add(newEntry);
    }

    public void WriteToFile (string filename)
    {
        Console.WriteLine($"Number of entries: {_entries.Count}");
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            Console.WriteLine($"writing to {filename}");
            foreach(JournalEntry entry in _entries)
            {
                Console.WriteLine($"Writing this text: {entry.CreateFileSystemString()}");
                outputFile.WriteLine(entry.CreateFileSystemString());
            }
        }
    }

    public void ReadFile (string filename)
    {
        
        
        string [] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("#");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
            
            JournalEntry entry = new JournalEntry(date, prompt, response);
            entry.DisplayJournalEntry();
            _entries.Add(entry);


        }
        
    }
}
