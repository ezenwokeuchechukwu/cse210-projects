public class ChecklistGoal : Goal
{
    public int RequiredCompletions { get; }
    public int CurrentCompletions { get;  set; }
    public int BonusPoints { get; }

    public ChecklistGoal(string name, int points, int requiredCompletions, int bonusPoints)
        : base(name, points)
    {
        RequiredCompletions = requiredCompletions;
        BonusPoints = bonusPoints;
        CurrentCompletions = 0;
    }

    public ChecklistGoal(string name, int points, int v) : base(name, points)
    {
    }

    public override string GetDetailsString()
    {
        return $"{Name} - {Points} points each time - {CurrentCompletions}/{RequiredCompletions} completions - {(IsComplete ? "[X]" : "[ ]")}";
    }

    public override void RecordEvent()
    {
        if (!IsComplete)
        {
            CurrentCompletions++;
            if (CurrentCompletions >= RequiredCompletions)
            {
                IsComplete = true;
            }
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{Name},{Points},{RequiredCompletions},{CurrentCompletions},{BonusPoints},{IsComplete}";
    }
}

