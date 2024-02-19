using System;

public class Swimming : Activity
{
    DateTime dateTime;
    int _numOfLaps;
    float _speed, _pace;

    public Swimming(int numOfLaps, float distance, float speed, float pace)
    : base(distance, speed, pace)
    {
        _numOfLaps = numOfLaps;
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
        return _numOfLaps * 50 / 1000f;
    }
    public override float GetPace()
    {
        return 60 / _speed;
    }
    public override string GetSummary()
    {
        return $"{dateTime} - Swimming ({_numOfLaps} laps) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}