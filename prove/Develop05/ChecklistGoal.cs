using System;
using System.Collections.Generic;

public class ChecklistGoal:Goal
{
    private int _bonusPoints;

    public ChecklistGoal(int p, int tm, int bp, int numOfTimes, string d):base(p, tm, "ChecklistGoal", d)
    {
        _goalType = "ChecklistGoal";
        _bonusPoints = bp;
        _numberOfTimes = numOfTimes;
    }
    public override int GetTargetTimesMet()
    {
        return _numberOfTimes;
    }
    public override void MeetsGoal()
    {
        _timesMet = Math.Min(_timesMet + 1, _numberOfTimes);

        if (_timesMet == _numberOfTimes)
        {
            SetCompleted(true);
        }
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
        str += "|" + _completed + "|" + _description + "|";
        str += _bonusPoints + "|" + _numberOfTimes;

        return str;
    }
}