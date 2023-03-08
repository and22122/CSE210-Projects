using System;
using System.Collections.Generic;

public abstract class Goal
{
    protected int _points = 0;
    protected int _timesMet = 0;
    protected bool _completed = false;
    protected string _goalType = "Goal";
    protected string _description = "A normal goal";
    public Goal(int p, int tm, string gt, string desc)
    {
        _points = p;
        _timesMet = tm;
        _goalType = gt;
        _description = desc;
    }
    public string GetGoalType()
    {
        return _goalType;
    }
    public void SetCompleted(bool c)
    {
        _completed = c;
    }
    public bool GetState()
    {
        return _completed;
    }
    public int GetTimesMet()
    {
        return _timesMet;
    }
    public void SetPoints(int p)
    {
        _points = p;
    }
    public abstract void MeetsGoal();
    public abstract int GetPoints();
    public virtual string GetString()
    {
        return $"{_goalType}|{_points}|{_timesMet}|{_completed}|{_description}";
    }
}