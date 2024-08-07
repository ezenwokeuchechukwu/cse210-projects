public abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; protected set; }
    public bool IsComplete { get;  set; }

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        IsComplete = false;
    }

    public abstract string GetDetailsString();
    public abstract void RecordEvent();
    public abstract string GetStringRepresentation();
}

