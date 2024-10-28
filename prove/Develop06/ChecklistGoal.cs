using System;

public class ChecklistGoal : Goal
{
    private bool _isComplete;
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _isComplete = false;
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

        public ChecklistGoal(string name, string description, int points, bool completed, int target, int bonus) : base(name, description, points)
    {
        _isComplete = completed;
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int GetPoints()
    {
        if (_amountCompleted == _target)
        {
            return _points + _bonus;
        }

        else
        {
            return _points;
        }
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;

        IsComplete();

        int pointsAwarded = GetPoints();

        Console.WriteLine($"Congratulations! You have earned {pointsAwarded} points!");
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            _isComplete = true;
        }

        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string checkbox;
        
        if (_isComplete == true)
        {
            checkbox = "[X]";
        }

        else
        {
            checkbox = "[ ]";
        }
        
        return $"{checkbox} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentations()
    {
        return $"ChecklistGoal,{_shortName},{_description},{_points},{_isComplete},{_target},{_bonus}";
    }
}