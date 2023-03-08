using System;
using System.Collections.Generic;

public class SimpleGoal : Goal
{
    public SimpleGoal(int p, int tm, string d):base(p, tm, "SimpleGoal", d)
    {
    }
    public override void MeetsGoal()
    {
        _timesMet = 1;
    }
    public override int GetPoints()
    {
        return _points;
    }
}