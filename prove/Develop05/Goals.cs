using System;
using System.Collections.Generic;
using System.IO;

public class Goals
{
    List<Goal> _goals = new List<Goal>();

    public int GetScore()
    {
        int totalPoints = 0;

        foreach (Goal g in _goals)
        {
            totalPoints += g.GetPoints();
        }

        return totalPoints;
    }
    public Goal GoalFromString(string str)
    {
        string gt = str.Split("|")[0];
        int pts = int.Parse(str.Split("|")[1]);
        int tm = int.Parse(str.Split("|")[2]);
        bool c = bool.Parse(str.Split("|")[3]);
        string d = str.Split("|")[4];

        if (gt == "SimpleGoal")
        {
            SimpleGoal g = new SimpleGoal(pts, tm, d);

            g.SetCompleted(c);

            return g;
        }
        else if (gt == "EternalGoal")
        {
            EternalGoal g = new EternalGoal(pts, tm, d);

            g.SetCompleted(c);

            return g;
        }
        else
        {
            int bonPoi = int.Parse(str.Split("|")[5]);
            int numOfTim = int.Parse(str.Split("|")[6]);

            ChecklistGoal g = new ChecklistGoal(pts, tm, bonPoi, numOfTim, d);

            g.SetCompleted(c);

            return g;
        }
    }

    public void MakeGoalFromInput()
    {
        string gt = "";

        do
        {
            Console.WriteLine("What kind of goal would you like to set? ('Simple', 'Eternal', or 'Checklist')");
            gt = Console.ReadLine().ToLower();
        }
        while (gt != "simple" && gt != "eternal" && gt != "checklist");

        string d = "";

        do
        {
            Console.WriteLine("What is the goal?");
            d = Console.ReadLine();
        }
        while (d == "");

        Console.WriteLine("How many will you earn whenever you meet the goal?");
        int pts = int.Parse(Console.ReadLine());

        if (gt == "simple")
        {
            _goals.Add(new SimpleGoal(pts, 0, d));
        }
        else if (gt == "eternal")
        {
            _goals.Add(new EternalGoal(pts, 0, d));
        }
        else
        {
            Console.WriteLine("How many bonus points will you earn when you finish this goal?");
            int bp = int.Parse(Console.ReadLine());
            
            Console.WriteLine("How many times must the goal be met to be finished?");
            int numOfTim = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(pts, 0, bp, numOfTim, d));
        }
    }
    public void LoadGoals()
    {
        string filename = "";

        do
        {
            Console.WriteLine("What file do you want to load from?");
            filename = Console.ReadLine();
        }
        while (filename == "");

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            _goals.Add(GoalFromString(line));
        }
    }
    public void SaveGoals()
    {
        string filename = "";

        do
        {
            Console.WriteLine("What file do you want to save to?");
            filename = Console.ReadLine();
        }
        while (filename == "");

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetString());
            }
        }
    }
    public void PrintGoals()
    {
        //implement Functional Requirements #7!
        foreach (Goal g in _goals)
        {
            if (g.GetState())
            {
                Console.Write("[X] ");
            }
            else
            {
                Console.Write("[ ] ");
            }

            if (g.GetGoalType() == "Checklist")
            {
                Console.Write($"Completed {g.GetTimesMet()}/{g.GetTargetTimesMet()}");
            }
        }
    }
}