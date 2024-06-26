using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference Reference { get; private set; }
    public List<Word> Words { get; private set; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        var wordsToHide = Words.Where(w => !w.IsHidden).OrderBy(x => rand.Next()).Take(count);

        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    public bool IsFullyHidden()
    {
        return Words.All(w => w.IsHidden);
    }

    public override string ToString()
    {
        string text = string.Join(" ", Words.Select(w => w.ToString()));
        return $"{Reference}\n{text}";
    }
}
