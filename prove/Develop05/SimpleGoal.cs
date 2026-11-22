class SimpleGoal : BaseGoal
{
    public SimpleGoal (string name, string description, int points, bool complete, string goalType)
    :base(name, description, points, complete, goalType)
    {
    }
    public SimpleGoal():base ("SimpleGoal")
    {
    }

    public override int RecordEvent()
    {
        return MarkComplete();
// for the list goal it needs to see if you hit the bouns as well
// and it needs to incrament points. 
    }
}