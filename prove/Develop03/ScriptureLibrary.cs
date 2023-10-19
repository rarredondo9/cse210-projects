using System;
using System.Collections.Generic;

public class ScriptureLibrary
{
    private List<Scripture> scriptures = new List<Scripture>();
    private Random random = new Random();

    public void AddScripture(Scripture scripture)
    {
        scriptures.Add(scripture);
    }

    public Scripture GetRandomScripture()
    {
        return scriptures[random.Next(scriptures.Count)];
    }

    public void RemoveScripture(Scripture scripture)
    {
        scriptures.Remove(scripture);
    }

    public bool IsEmpty()
    {
        return scriptures.Count == 0;
    }
}
