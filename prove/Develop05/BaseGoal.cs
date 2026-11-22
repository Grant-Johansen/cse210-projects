abstract class BaseGoal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _complete;
    private string _goalType;

public BaseGoal(string name, string description, int points, bool complete, string goalType)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = complete;
        _goalType = goalType;
    }
    public BaseGoal(string goalType)
    {
        SetName();
        SetDescription();
        SetPoints();
        _complete = false;
        _goalType = goalType;
    }
    public string GetName()
    {
        return _name;
    }
    private void SetName()
    {
        Console.Write("What is the name of the goal?");
        _name = Console.ReadLine();
    }
    public string GetDescription()
    {
        return _description;
    }
    private void SetDescription()
    {
        Console.WriteLine($"What is the descrpition for {_name} goal?");
        _description = Console.ReadLine();
    }
    public int GetPoints()
        {
            return _points; 
        }
    private void SetPoints()
    {
        Console.WriteLine($"What are the points for {_name} goal? ");
        _points = int.Parse(Console.ReadLine());
    }
    public bool GetStatus()
    {
        return _complete;
    }
    public string GetGoalType()
    {
        return _goalType;
    }
    public int MarkComplete()
    {
        if (_complete)
    {
        return 0;
    }
        _complete = true;
        return _points;
    }
    public virtual string GetConsoleString()
    {
        string completeString = " ";
        if (_complete)
            completeString = "X";
    
        return $"[{completeString}] {_goalType} Goal Name: {_name}, Description: {_description} Points: {_points}";
    }
    public virtual string GetFileSystemString()
    {
        string outputString = "";
        outputString = $"{_name}#{_description}#{_complete}#{_goalType}#0#0#0";
        return outputString;
    }
    public abstract int RecordEvent();

}