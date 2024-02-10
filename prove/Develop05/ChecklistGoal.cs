using System;

public class ChecklistGoal : Goal
{
    int _amountCompleted, _target, _bonus;

    public ChecklistGoal(string name, string description, int points)
    :base(name, description, points)
    {

    }
    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        return true;
    }
    public override string GetDetailsString()
    {
        throw new NotImplementedException();
    }
    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}