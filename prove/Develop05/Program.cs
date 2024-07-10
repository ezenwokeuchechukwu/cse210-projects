using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. create Simple Goal");
            Console.WriteLine("2. create Eternal Goal");
            Console.WriteLine("3. create Checklist Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Display Goals");
            Console.WriteLine("6. Display Score");
            Console.WriteLine("7. Save Goals");
            Console.WriteLine("8. Load Goals");
            Console.WriteLine("9. Exit");
            Console.Write("Select an option: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    AddSimpleGoal(goalManager);
                    break;
                case 2:
                    AddEternalGoal(goalManager);
                    break;
                case 3:
                    AddChecklistGoal(goalManager);
                    break;
                case 4:
                    RecordEvent(goalManager);
                    break;
                case 5:
                    goalManager.DisplayGoals();
                    break;
                case 6:
                    DisplayScore(goalManager);
                    break;
                case 7:
                    SaveGoals(goalManager);
                    break;
                case 8:
                    LoadGoals(goalManager);
                    break;
                case 9:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    static void AddSimpleGoal(GoalManager goalManager)
    {
        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the points for this goal: ");
        int points = int.Parse(Console.ReadLine());
        goalManager.AddGoal(new SimpleGoal(name, points));
    }

    static void AddEternalGoal(GoalManager goalManager)
    {
        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the points for this goal: ");
        int points = int.Parse(Console.ReadLine());
        goalManager.AddGoal(new EternalGoal(name, points));
    }

    static void AddChecklistGoal(GoalManager goalManager)
    {
        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the points for each completion: ");
        int points = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of times to complete this goal: ");
        int requiredCompletions = int.Parse(Console.ReadLine());
        Console.Write("Enter the bonus points for completing the goal: ");
        int bonusPoints = int.Parse(Console.ReadLine());
        goalManager.AddGoal(new ChecklistGoal(name, points, requiredCompletions, bonusPoints));
    }

    static void RecordEvent(GoalManager goalManager)
    {
        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        goalManager.RecordEvent(name);
    }

    static void DisplayScore(GoalManager goalManager)
    {
        Console.WriteLine($"Total Score: {goalManager.TotalScore}");
        Console.WriteLine($"Experience Points: {goalManager.ExperiencePoints}");
        Console.WriteLine($"Level: {goalManager.Level}");
    }

    static void SaveGoals(GoalManager goalManager)
    {
        Console.Write("Enter the filename to save the goals: ");
        string filename = Console.ReadLine();
        goalManager.Save(filename);
    }

    static void LoadGoals(GoalManager goalManager)
    {
        Console.Write("Enter the filename to load the goals: ");
        string filename = Console.ReadLine();
        goalManager.Load(filename);
    }
}
