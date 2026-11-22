using System;
class Program
{
    static void Main(string[] args)
    {
        Goals goals = new Goals();
        Menu myMenu = new Menu(goals);

        int response;

        do
        {
            response = myMenu.MenuOptions();

            switch (response)
            {
                case 1:
                    myMenu.CreateNewGoal();
                    break;

                case 2:
                    goals.DisplayGoals();
                    break;

                case 3:
                    goals.SaveGoals();
                    break;

                case 4:
                    goals.LoadGoals();
                    break;

                case 5:
                    goals.RecordEvent();
                    break;

                case 6:
                    Console.WriteLine("Goodbye!");
                    break;
            }

        } while (response != 6);
    }
}