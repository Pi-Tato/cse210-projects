using System;

public class Fraction
{
    private int _topNum, _bottomNum;

    public Fraction()
    {
        _topNum = 1;
        _bottomNum = 1;
    }
    public Fraction(int number)
    {
        _topNum = number;
        _bottomNum = 1;
    }
    public Fraction(int topNumber, int bottomNumber)
    {
        _topNum = topNumber;
        _bottomNum = bottomNumber;
    }

    public string GetFractionString()
    {
        return $"{_topNum}/{_bottomNum}";
    }
    public double GetDecimal()
    {
        return (double)_topNum / _bottomNum;
    }
}