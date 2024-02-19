using System;

public abstract class Activity
{
    float _distance, _speed, _pace;

    public Activity(float distance, float speed, float pace)
    {
        _distance = distance;
        _speed = speed;
        _pace = pace;
    }

    public abstract float GetSpeed();
    public abstract float GetDistance();
    public abstract float GetPace();
    public abstract string GetSummary();
}