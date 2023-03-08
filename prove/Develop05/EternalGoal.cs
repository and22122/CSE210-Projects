using System;
using System.Collections.Generic;

public class EternalGoal:Goal
{
    public EternalGoal(int p, int tm, string d):base(p, tm, "EternalGoal", d)
    {
    }
    public override void MeetsGoal()
    {
        _timesMet ++;
    }
    public override int GetPoints()
    {
        return _points * _timesMet;
    }
}