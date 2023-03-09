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

        Console.WriteLine("How many points will you earn whenever you meet the goal?");
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
            string gt = line.Split("|")[0];
            int pts = int.Parse(line.Split("|")[1]);
            int tm = int.Parse(line.Split("|")[2]);
            bool c = bool.Parse(line.Split("|")[3]);
            string d = line.Split("|")[4];

            if (gt == "SimpleGoal")
            {
                SimpleGoal g = new SimpleGoal(pts, tm, d);

                g.SetCompleted(c);

                _goals.Add(g);
            }
            else if (gt == "EternalGoal")
            {
                EternalGoal g = new EternalGoal(pts, tm, d);

                g.SetCompleted(c);

                _goals.Add(g);
            }
            else
            {
                int bonPoi = int.Parse(line.Split("|")[5]);
                int numOfTim = int.Parse(line.Split("|")[6]);

                ChecklistGoal g = new ChecklistGoal(pts, tm, bonPoi, numOfTim, d);

                g.SetCompleted(c);

                _goals.Add(g);
            }
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

            if (g.GetGoalType() == "ChecklistGoal")
            {

                Console.Write($"Completed {g.GetTimesMet()}/{g.GetTargetTimesMet()}: ");
            }
            Console.WriteLine(g.GetDescription());
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("Which goal would you like to record an event for?");
        for (int i = 0; i < _goals.Count(); i ++)
        {
            Goal g = _goals[i];

            Console.WriteLine($"{i} - {g.GetDescription()}");
        }

        Console.WriteLine("Please enter a number to select a goal.");

        int input = -1;

        do
        {
            input = int.Parse(Console.ReadLine());
            if (input < 0)
            {
                Console.WriteLine("Please try again.");
            }
        }
        while (input < 0);

        _goals[input].MeetsGoal();

        Console.WriteLine("Congratulations! The event has been recorded.");
    }
}