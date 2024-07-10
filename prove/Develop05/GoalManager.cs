using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    public List<Goal> Goals { get; private set; }
    public int TotalScore { get; private set; }
    public int ExperiencePoints { get; private set; }
    public int Level { get; private set; }

    public GoalManager()
    {
        Goals = new List<Goal>();
        TotalScore = 0;
        ExperiencePoints = 0;
        Level = 1;
    }

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        foreach (var goal in Goals)
        {
            if (goal.Name == goalName)
            {
                goal.RecordEvent();
                TotalScore += goal.Points;
                ExperiencePoints += goal.Points;
                if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete)
                {
                    TotalScore += checklistGoal.BonusPoints;
                    ExperiencePoints += checklistGoal.BonusPoints;
                }
                CheckLevelUp();
                break;
            }
        }
    }

    private void CheckLevelUp()
    {
        int requiredXP = Level * 1000;
        if (ExperiencePoints >= requiredXP)
        {
            Level++;
            ExperiencePoints -= requiredXP;
            Console.WriteLine($"Congratulations! You've leveled up to Level {Level}!");
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in Goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var goal in Goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
            outputFile.WriteLine($"TotalScore:{TotalScore}");
            outputFile.WriteLine($"ExperiencePoints:{ExperiencePoints}");
            outputFile.WriteLine($"Level:{Level}");
        }
    }

    public void Load(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        Goals.Clear();
        TotalScore = 0;
        ExperiencePoints = 0;
        Level = 1;

        foreach (string line in lines)
        {
            if (line.StartsWith("TotalScore:"))
            {
                TotalScore = int.Parse(line.Split(':')[1]);
            }
            else if (line.StartsWith("ExperiencePoints:"))
            {
                ExperiencePoints = int.Parse(line.Split(':')[1]);
            }
            else if (line.StartsWith("Level:"))
            {
                Level = int.Parse(line.Split(':')[1]);
            }
            else
            {
                string[] parts = line.Split(':');
                string type = parts[0];
                string[] details = parts[1].Split(',');

                if (type == "SimpleGoal")
                {
                    var goal = new SimpleGoal(details[0], int.Parse(details[1]))
                    {
                        IsComplete = bool.Parse(details[2])
                    };
                    Goals.Add(goal);
                }
                else if (type == "EternalGoal")
                {
                    var goal = new EternalGoal(details[0], int.Parse(details[1]));
                    Goals.Add(goal);
                }
                else if (type == "ChecklistGoal")
                {
                    var goal = new ChecklistGoal(details[0], int.Parse(details[1]), int.Parse(details[2]))
                    {
                        CurrentCompletions = int.Parse(details[3]),
                        IsComplete = bool.Parse(details[4])
                    };
                    Goals.Add(goal);
                }
            }
        }
    }
}
