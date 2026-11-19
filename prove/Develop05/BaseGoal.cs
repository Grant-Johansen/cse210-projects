class BaseGoal
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

    private void SetName()
    {
        Console.Write("");
    }
    private void SetDescription()
    {
        
    }
    private void SetPoints()
    {
        Console.Write($"What are the points for {_name} goal? ");
        _points = int.Parse(Console.ReadLine());
    }
    public virtual string GetConsoleString()
    {
        return $"Goal Name: {_name}, Description: {_description}, Points {_points}";
    }
    public int MarkComplete()
    {
        _complete = true;
        return _points;
    }
}