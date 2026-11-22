class ListGoal : BaseGoal
{
    private int _iterations;

    public ListGoal (string name, string description, int points, bool complete, string goalType)
    :base(name, description, points, complete, goalType)
    {
    }
    public ListGoal():base ("ListGoal")
    {
    }

    public override int RecordEvent()
    {
        
        return GetPoints();
    }
}