using System;

class Program
{
    static void Main(string[] args)
    {
        // BaseGoal myGoal = new BaseGoal("BaseGoal");
        // Console.WriteLine(myGoal.GetConsoleString());

        // SimpleGoal mySimpleGoal = new SimpleGoal();
        // Console.WriteLine(mySimpleGoal.GetConsoleString());
        // mySimpleGoal.RecordEvent();
        // Console.WriteLine(mySimpleGoal.GetConsoleString());

        EternalGoal myEternalGoal = new EternalGoal();
        Console.WriteLine(myEternalGoal.GetConsoleString());
        myEternalGoal.RecordEvent();
        Console.WriteLine(myEternalGoal.GetConsoleString());

    }
}