using System;
using System.Collections.Generic;

public class ChecklistGoal:Goal
{
    private int _bonusPoints;
    private int _numberOfTimes;

    public ChecklistGoal(int p, int tm, int bp, int numOfTimes, string d):base(p, tm, "ChecklistGoal", d)
    {
        _goalType = "ChecklistGoal";
        _bonusPoints = bp;
        _numberOfTimes = numOfTimes;
    }
    public int GetTargetTimesMet()
    {
        return _numberOfTimes;
    }
    public override void MeetsGoal()
    {
        _timesMet = Math.Min(_timesMet + 1, _numberOfTimes);
    }
    public override int GetPoints()
    {
        if (_timesMet < _numberOfTimes)
        {
            return _timesMet * _points;
        }
        else
        {
            return _timesMet * _points + _bonusPoints;
        }
    }
    public override string GetString()
    {
        string str = _goalType + "|" + _points + "|" + _timesMet;
        str += "|" + _description + "|" + _completed + "|";
        str += _bonusPoints + "|" + _numberOfTimes;

        return str;
    }
}