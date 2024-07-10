public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override string GetDetailsString()
    {
        return $"{Name} - {Points} points - {(IsComplete ? "[X]" : "[ ]")}";
    }

    public override void RecordEvent()
    {
        if (!IsComplete)
        {
            IsComplete = true;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{Name},{Points},{IsComplete}";
    }
}
