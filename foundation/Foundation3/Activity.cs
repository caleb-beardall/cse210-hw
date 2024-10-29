using System;
using System.Diagnostics;

public class Activity
{
    protected string _name;
    protected string _date;
    protected int _time;

    public Activity(string name, string date, int time)
    {
        _name = name;
        _date = date;
        _time = time;
    }
    
    public virtual double GetDistance()
    {
        return GetSpeed() * _time / 60;
    }

    public virtual double GetSpeed()
    {
        return GetDistance() / _time * 60;
    }

    public virtual double GetPace()
    {
        return 60 / GetSpeed();
    }

    public string GetSummary()
    {
        return $"{_date} {_name} {_time} — Distance {Math.Round(GetDistance(), 2)} miles, Speed {Math.Round(GetSpeed(), 2)} mph, Pace {Math.Round(GetPace(), 2)} min per mile";
    }
}