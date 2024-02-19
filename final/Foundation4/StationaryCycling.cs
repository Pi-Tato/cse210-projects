using System;

public class StationaryCycling : Activity
{
    DateTime dateTime;
    float _speed, _pace;

    public StationaryCycling(float distance, float speed, float pace)
    : base(distance, speed, pace)
    {
        _speed = speed;
        _pace = pace;
        dateTime = DateTime.Now;
    }

    public override float GetSpeed()
    {
        return _speed;
    }
    public override float GetDistance()
    {
        return GetSpeed() * GetPace();
    }public override float GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{dateTime} - Cycling - {GetPace()} min per mile, {GetSpeed()} mph, {GetDistance()} miles";
    }
}