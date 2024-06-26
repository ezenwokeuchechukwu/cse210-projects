using System;
using System.Collections.Generic;
using System.IO;

public class ScriptureLibrary
{
    public List<Scripture> Scriptures { get; private set; }

    public ScriptureLibrary()
    {
        Scriptures = new List<Scripture>();
    }

    public void LoadFromFile(string filePath)
    {
        try
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                // Assume the format is "Reference|Text"
                var parts = line.Split('|');
                if (parts.Length != 2)
                {
                    Console.WriteLine($"Invalid line format: {line}");
                    continue;
                }

                var referenceParts = parts[0].Split(new[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);

                if (referenceParts.Length < 3)
                {
                    Console.WriteLine($"Invalid reference format: {parts[0]}");
                    continue;
                }

                string book = referenceParts[0];
                int chapter;
                int startVerse;
                int endVerse;

                if (!int.TryParse(referenceParts[1], out chapter) || !int.TryParse(referenceParts[2], out startVerse))
                {
                    Console.WriteLine($"Invalid chapter or verse format: {parts[0]}");
                    continue;
                }

                endVerse = referenceParts.Length > 3 ? int.Parse(referenceParts[3]) : startVerse;

                Reference reference = new Reference(book, chapter, startVerse, endVerse);
                Scripture scripture = new Scripture(reference, parts[1]);

                Scriptures.Add(scripture);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }
    }

    public Scripture GetRandomScripture()
    {
        Random rand = new Random();
        int index = rand.Next(Scriptures.Count);
        return Scriptures[index];
    }
}
