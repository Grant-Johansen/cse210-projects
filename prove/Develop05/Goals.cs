class Goals
{
    private List<BaseGoal> _goals = new List<BaseGoal>();
    private string _filename;
    private int _totalScore;

    public Goals()
    {
    }
    public int GetTotalScore()
    {
        return _totalScore;
    }
    
    public void AddGoal(BaseGoal goal)
    {
        _goals.Add(goal);
    }
    public void DisplayGoals()
    {
        Console.WriteLine("Here are your goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetConsoleString()}");
        }
    }
    public void DisplayScore()
    {
        Console.WriteLine($"Here is your score {_totalScore}");
    }
    public void LoadGoals ()
    {
        
        _filename = ObtainFileName("What file would you like to load? ");

        if (!File.Exists(_filename))
        {
            Console.WriteLine("That file does not exist.");
            return;
        }

        string[] lines = File.ReadAllLines(_filename);

        _goals.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split('#');

            if (parts[0] == "Total Score")
            {
                _totalScore = int.Parse(parts[1]);
                continue;
            }

            string name = parts[0];
            string description = parts[1];
            int points = int.Parse(parts[2]);
            bool complete = bool.Parse(parts[3]);
            string goalType = parts[4];
            int numberOfCompletions = int.Parse(parts[5]);
            int maxGoals = int.Parse(parts[6]);
            int bounsPoints = int.Parse(parts[7]);



            BaseGoal goal = CreateGoal(name, description, points, complete, goalType, numberOfCompletions, maxGoals, bounsPoints);

            _goals.Add(goal);
        }

        Console.WriteLine("Goals loaded successfully.");
        
    }

    private BaseGoal CreateGoal(string name, string description, int points, bool complete, string goalType, int numberOfCompletions, int maxGoals, int bounsPoints)
    {
        switch (goalType)
        {
            case "Simple":
                return new SimpleGoal(
                    name,
                    description,
                    points,
                    complete,
                    goalType
                );

            case "Eternal":
                return new EternalGoal(
                    name,
                    description,
                    points,
                    complete,
                    goalType,
                    numberOfCompletions
                );

            case "Checklist":
                return new ListGoal(
                    name,
                    description,
                    points,
                    complete,
                    goalType,
                    numberOfCompletions,
                    maxGoals,
                    bounsPoints
                );

            default:
                throw new Exception($"Unknown goal type: {goalType}");
        }
    }
    public void RecordEvent()
    {
        DisplayGoals();
        Console.WriteLine("Whice goals did you acomplish?");
        int userChoice = int.Parse(Console.ReadLine());

        int index = userChoice -1;

        if (index >= 0 && index < _goals.Count)
        {
            
        int pointsEarned = _goals[index].RecordEvent();
        _totalScore += pointsEarned;

        Console.WriteLine($"Congrats, you earned {pointsEarned} points!");
        Console.WriteLine($"Your total score is now {_totalScore}");
        }
        else
        {
            Console.WriteLine("That Goal doesn't currently exist.");
        }

    }
    private string ObtainFileName(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }
    public void SaveGoals()
    {
        _filename = ObtainFileName("What file would you like to save to?");
    
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            outputFile.WriteLine($"Total Score#{_totalScore}");

            foreach (BaseGoal goal in _goals)
            {
                outputFile.WriteLine(goal.GetFileSystemString());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }
    

}


    