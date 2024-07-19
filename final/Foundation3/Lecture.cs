using System;

public class Lecture : Event
{
    private string Speaker { get; }
    private int Capacity { get; }

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}
