using System;

public class Event
{
    private string Title { get; }
    private string Description { get; }
    private string Date { get; }
    private string Time { get; }
    private Address Address { get; }

    public Event(string title, string description, string date, string time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nAddress: {Address}";
    }

    public virtual string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: {GetType().Name}";
    }

    public string GetShortDescription()
    {
        return $"{GetType().Name} - Title: {Title}, Date: {Date}";
    }
}
