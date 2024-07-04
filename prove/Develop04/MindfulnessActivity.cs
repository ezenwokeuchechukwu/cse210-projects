using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public abstract class MindfulnessActivity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }

    public void StartActivity()
    {
        Console.WriteLine($"Starting {Name} Activity");
        Console.WriteLine(Description);
        Console.Write("Enter the duration of the activity in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        PauseWithAnimation(3);
    }

    public void EndActivity()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
        PauseWithAnimation(3);
        ActivityLog.LogActivity(Name);
    }

    public void PauseWithAnimation(int seconds)
    {
        Console.Write("Pausing");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void PerformActivity();
}
