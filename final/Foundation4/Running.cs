using System;

public class Running : Activity
{
    DateTime dateTime;
    float _runningDistance, _runningSpeed, _runningPace;

    public Running(float distance, float speed, float pace)
    : base(distance, speed, pace)
    {
        _runningDistance = distance;
        _runningPace = pace;
        _runningSpeed = speed;
        dateTime = DateTime.Now;
    }

    public override float GetSpeed()
    {
        return _runningSpeed;
    }
    public override float GetDistance()
    {
        return _runningDistance;
    }
    public override float GetPace()
    {
        return 60 / _runningPace;
    }
    public override string GetSummary()
    {
        return $"{dateTime} - Running ({GetDistance()} miles) - Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}