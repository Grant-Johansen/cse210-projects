class ListGoal : BaseGoal
{
    private int _numberOfCompletions;
    private int _maxGoals;
    private int _bounsPoints;

    public ListGoal (string name, string description, int points, bool complete, string goalType, int numberOfCompletions, int maxGoals, int bounsPoints)
    :base(name, description, points, complete, goalType)
    {
        _bounsPoints = bounsPoints;
        _maxGoals = maxGoals;
        _numberOfCompletions = numberOfCompletions;
    }
    public ListGoal():base ("ListGoal")
    {
    }
    public override int RecordEvent()
    {
    if (GetStatus())
    {
        return 0;
    }

    _numberOfCompletions++;

    if (_numberOfCompletions >= _maxGoals)
    {
        return MarkComplete() + _bounsPoints;
    }

    return GetPoints();
    }
    public override string GetConsoleString()
    {
        string completeString = " ";
        if (GetStatus() == true)
            completeString = "X";
    
        return $"[{completeString}] {GetGoalType()} Goal Name: {GetName()}, Description: {GetDescription()} Points: {GetPoints()} Bouns Points: {_bounsPoints} Number of completions {_numberOfCompletions}";
    }
    public override string GetFileSystemString()
    {
        string outputString = "";
        outputString = $"{GetName()}#{GetDescription()}#{GetPoints()}#{GetStatus()}#{GetGoalType()}#{_numberOfCompletions}#{_maxGoals}#{_bounsPoints}";
        return outputString;
    }
}