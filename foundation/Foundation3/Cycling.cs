using System;
using System.Diagnostics;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string name, string date, int time, double speed) : base(name, date, time)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
}