class EternalGoal : BaseGoal
{
    private int _numberOfCompletions;
    public EternalGoal (string name, string description, int points, bool complete, string goalType, int numberOfCompletions)
    :base(name, description, points, complete, goalType)
    {
        _numberOfCompletions = numberOfCompletions;
    }
    public EternalGoal():base ("EternalGoal")
    {
    }

    public override int RecordEvent()
    {
        _numberOfCompletions++;
        return GetPoints(); 
    }
     public override string GetConsoleString()
    {
        string completeString = " ";
        if (GetStatus() == true)
            completeString = "X";
    
        return $"[{completeString}] {GetGoalType()} Goal Name: {GetName()}, Description: {GetDescription()} Points: {GetPoints()}";
    }
    public override string GetFileSystemString()
    {
        string outputString = "";
        outputString = $"{GetName()}#{GetDescription()}#{GetStatus}#{GetGoalType()}#{_numberOfCompletions}#0#0";
        return outputString;
    }
}
