using System;

public class Program
{
    public static void Main()
    {
        ScriptureLibrary scriptureLibrary = new ScriptureLibrary();

        // Use the full path to the scriptures.txt file
        string filePath = @"C:\Users\USER\OneDrive\Desktop\Desktop\CSE210-PROJECT\cse210-projects\prove\Develop03\scriptures.txt";

        scriptureLibrary.LoadFromFile(filePath);

        if (scriptureLibrary.Scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures found in the library. Please check the scriptures.txt file.");
            return;
        }

        Scripture scripture = scriptureLibrary.GetRandomScripture();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.IsFullyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture);
                Console.WriteLine("\nAll words are hidden. Program will now exit.");
                break;
            }
        }
    }
}
