using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;

    // Constructor to initialize with a list of prompts
    public PromptGenerator()
    {
        _prompts = new List<string>();
    }

    // Method to add a prompt to the list
    public void AddPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }

    // Method to get a random prompt from the list
    public string GetRandomPrompt()
    {
        if (_prompts.Count == 0)
        {
            throw new InvalidOperationException("No prompts available.");
        }

        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
