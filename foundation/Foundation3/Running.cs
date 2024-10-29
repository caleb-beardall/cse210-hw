using System;
using System.Diagnostics;

public class Running : Activity
{
    private double _distance;

    public Running(string name, string date, int time, double distance) : base(name, date, time)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
}