class Goals : BaseGoal
{
    private List<BaseGoal> _goals = new List<BaseGoal>();
    private string _filename;
    private int _totalScore;

    public Goals() :base("Goals")
    {
    }
    // public void WriteToFile (string filename)
    //     {
            
    //         using (StreamWriter outputFile = new StreamWriter(filename))
    //         {
    //             foreach(JournalEntry entry in _entries)
    //             {
    //                 outputFile.WriteLine(entry.CreateFileSystemString());
    //             }
    //         }
    //     }

    //     public void ReadFile (string filename)
    //     {
            
            
    //         string [] lines = System.IO.File.ReadAllLines(filename);

    //         foreach (string line in lines)
    //         {
    //             string[] parts = line.Split("#");

    //             string date = parts[0];
    //             string prompt = parts[1];
    //             string response = parts[2];
                
    //             JournalEntry entry = new JournalEntry(date, prompt, response);
    //             entry.DisplayJournalEntry();
    //             _entries.Add(entry);


    //         }
            
    //     }
    public override int RecordEvent()
    {
        return 0;
    }
}


    