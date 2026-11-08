class ReflectionActivity: BaseActivity
 {
     private List<FlaggedString> _prompts = new List<FlaggedString>();
     private List<FlaggedString> _questions = new List<FlaggedString>();
    private bool _noQuestions;

     public ReflectionActivity(string name, string description): base(name, description)
    {
        description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void SetPromptsAndQuestions()
    {
        _prompts.Add(new FlaggedString("Think of a time when you stood up for someone else.", false));
        _prompts.Add(new FlaggedString("Think of a time when you did something really difficult.",false));
        _prompts.Add(new FlaggedString("Think of a time when you helped someone in need.",false));
        _prompts.Add(new FlaggedString("Think of a time when you did something truly selfless.",false));

        _questions.Add(new FlaggedString("Why was this experience meaningful to you?",false));
        _questions.Add(new FlaggedString("Have you ever done anything like this before?",false));
        _questions.Add(new FlaggedString("How did you get started?",false));
        _questions.Add(new FlaggedString("How did you feel when it was complete?",false));
        _questions.Add(new FlaggedString("What made this time different than other times when you were not as successful?",false));
        _questions.Add(new FlaggedString("What is your favorite thing about this experience?",false));
        _questions.Add(new FlaggedString("What could you learn from this experience that applies to other situations?",false));
        _questions.Add(new FlaggedString("What did you learn about yourself through this experience?",false));
        _questions.Add(new FlaggedString("How can you keep this experience in mind in the future?",false));

    
    }

 public void RunActivity()
    {
        Random random = new Random ();
        int randomprompt = random.Next(_prompts.Count);
        FlaggedString CurrentPrompt = _prompts [randomprompt];
        string printablePrompt = CurrentPrompt.SetHasBeenUsed();

        int randomQuestion;
        StartActivity();
        Console.WriteLine(printablePrompt);
        Thread.Sleep(10000);
        DateTime endTime = DateTime.Now.AddSeconds(20);
        
        
        RunSpinnerMessage("Get Ready", 6);
        StartTimer();
        while (! HasTimerExpiered())
        {
            _noQuestions = true;
            do
            {   
                randomQuestion = random.Next(_questions.Count);

                foreach (FlaggedString question in _questions)
                {
                    if (!question.GetHasBeenUsed())
                    {
                        _noQuestions = false;
                        break;
                    }
                }
                if (_noQuestions)
                {
                    Console.WriteLine("All questions have been given.");
                }

            }
            while (_questions[randomQuestion].GetHasBeenUsed());
            
            
            FlaggedString CurrentQuestion = _questions [randomQuestion];
            string printableQuestion = CurrentQuestion.SetHasBeenUsed();
            RunSpinnerMessage(printableQuestion, 5);
            
        }
        ResetPromptsUsage();
        EndActivity();
    }

    public void ResetPromptsUsage()
    {
        foreach (FlaggedString prompt in _prompts)
        {
            prompt.ResetHasBeenUsed();
        }
    }
}