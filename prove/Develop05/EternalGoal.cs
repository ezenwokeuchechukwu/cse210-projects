public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override string GetDetailsString()
    {
        return $"{Name} - {Points} points each time - [ ]";
    }

    public override void RecordEvent()
    {
        // Eternal goals can be recorded multiple times, points are always awarded.
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{Name},{Points}";
    }
}
