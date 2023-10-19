using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private List<Word> words;
    public Reference Reference { get; }
    public string Text { get; }
    public string HiddenText => string.Join(" ", words.Select(word => word.GetRenderedText()));

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Text = text;
        words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWord()
    {
        Random rand = new Random();
        List<Word> visibleWords = words.Where(word => !word.IsHidden).ToList();

        if (visibleWords.Count > 0)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }

    public bool IsAllWordsHidden()
    {
        return words.All(word => word.IsHidden);
    }
}
