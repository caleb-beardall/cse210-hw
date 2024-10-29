using System;
using System.Diagnostics;

public class Swimming : Activity
{
    private double _laps;

    public Swimming(string name, string date, int time, double laps) : base(name, date, time)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
}