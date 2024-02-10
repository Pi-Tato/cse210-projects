using System;
using System.Net.NetworkInformation;

public class SimpleGoal : Goal
{
    bool _isComplete;

    public SimpleGoal(string name, string description, int points)
    : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
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