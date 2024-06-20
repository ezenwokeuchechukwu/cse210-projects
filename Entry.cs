using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Entry
{
    public string Content { get; set; }

    public Entry(string content)
    {
        Content = content;
    }
}

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry.Content);
        }
    }

    public void SaveToFile(string file)
    {
        var entriesJson = JsonSerializer.Serialize(_entries);
        File.WriteAllText(file, entriesJson);
    }

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            var entriesJson = File.ReadAllText(file);
            _entries = JsonSerializer.Deserialize<List<Entry>>(entriesJson);
        }
    }
}

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        journal.AddEntry(new Entry("First entry"));
        journal.AddEntry(new Entry("Second entry"));
        journal.DisplayAll();

        journal.SaveToFile("journal.json");
        journal.LoadFromFile("journal.json");
        journal.DisplayAll();
    }
}
