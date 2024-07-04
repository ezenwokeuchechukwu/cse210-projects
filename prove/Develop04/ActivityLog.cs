using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public static class ActivityLog
{
    private static Dictionary<string, int> activityCounts = new Dictionary<string, int>();

    public static void LogActivity(string activityName)
    {
        if (activityCounts.ContainsKey(activityName))
        {
            activityCounts[activityName]++;
        }
        else
        {
            activityCounts[activityName] = 1;
        }
    }

    public static void DisplayLog()
    {
        Console.WriteLine("\nActivity Log:");
        foreach (var entry in activityCounts)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} time(s)");
        }
    }
}
