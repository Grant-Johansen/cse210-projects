class Menu
{
    private Goals _goals;

    public Menu(Goals goals)
    {
        _goals = goals;
    }

    public int MenuOptions()
    {
        int input = 0;

        while (input < 1 || input > 6)
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            int.TryParse(Console.ReadLine(), out input);

            if (input < 1 || input > 6)
            {
                Console.WriteLine("Please enter a number from 1 to 6.");
            }
        }

        return input;
    }

    public int GoalOptions()
    {
        int input = 0;

        while (input < 1 || input > 3)
        {
            Console.WriteLine();
            Console.WriteLine("Goal Options:");
            Console.WriteLine("1. Create New Simple Goal");
            Console.WriteLine("2. Create New Eternal Goal");
            Console.WriteLine("3. Create New Checklist Goal");
            Console.Write("Select a choice: ");

            int.TryParse(Console.ReadLine(), out input);
        }

        return input;
    }

    public void CreateNewGoal()
    {
        int choice = GoalOptions();

        BaseGoal goal;

        switch (choice)
        {
            case 1:
                goal = new SimpleGoal();
                break;

            case 2:
                goal = new EternalGoal();
                break;

            case 3:
                goal = new ListGoal();
                break;

            default:
                return;
        }

        _goals.AddGoal(goal);
        Console.WriteLine("Goal created successfully.");
    }
}