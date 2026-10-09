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
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(JournalEntry entry in _entries)
            {
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

            string _date = parts[0];
            string _prompt = parts[1];
            string _response = parts[2];
            
            ​
            JournalEntry entry = new JournalEntry();
            
            _entries.Add(entry);


        

        }
        
    }
}
