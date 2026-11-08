class ListingActivity : BaseActivity
{
    private List<FlaggedString> _prompts = new List<FlaggedString>();

    public ListingActivity(string name, string description):base(name, description)
    {
        
    }
    public void RunActivity()
    {
        Random random = new Random ();
        int randomprompt = random.Next(_prompts.Count);
        FlaggedString CurrentPrompt = _prompts [randomprompt];
        string printablePrompt = CurrentPrompt.SetHasBeenUsed();
        
        StartActivity();
        RunSpinnerMessage("Get Ready to write about a propmt!", 7);
        Console.WriteLine(printablePrompt);
        Thread.Sleep(10000);
        StartTimer();
        int entries = 0;
        while (! HasTimerExpiered())
        {
            Console.ReadLine();
            entries =+ 1;
        }
        Console.WriteLine(entries);
        EndActivity();
    }
    public void ResetPromptsUsage()
    {
        foreach (FlaggedString prompt in _prompts)
        {
            prompt.ResetHasBeenUsed();
        }
    }

     public void SetPrompts()
    {
        _prompts.Add(new FlaggedString("Who are people that you appreciate?", false));
        _prompts.Add(new FlaggedString("What are personal strengths of yours?", false));
        _prompts.Add(new FlaggedString("Who are people that you have helped this week?", false));
        _prompts.Add(new FlaggedString("When have you felt the Holy Ghost this month?", false));
        _prompts.Add(new FlaggedString("Who are some of your personal heroes?", false));

    
    }
 

}