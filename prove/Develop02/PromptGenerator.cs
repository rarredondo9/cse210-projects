using System;
using System.Collections.Generic;

class PromptGenerator
{
    private List<string> prompts;

    public PromptGenerator()
    {
        prompts = new List<string>();

        AddPrompt("Who was the most interesting person I interacted with today?");
        AddPrompt("What was the best part of my day?");
        AddPrompt("How did I see the hand of the Lord in my life today?");
        AddPrompt("What was the strongest emotion I felt today?");
        AddPrompt("If I had one thing I could do over today, what would it be?");
    }

    public void AddPrompt(string prompt)
    {
        prompts.Add(prompt);
    }

    public string GenerateRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }
}


