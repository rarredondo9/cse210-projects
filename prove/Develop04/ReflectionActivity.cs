using System;
using System.Threading;

public class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
        
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What did you learn about yourself through this experience? ",
        "What could you learn from this experience that applies to other situations?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    protected override void PerformActivity()
    {
        Console.WriteLine($"Prompt: {prompts[new Random().Next(prompts.Length)]}");
        Thread.Sleep(2000);

        for (int i = 0; i < duration;)
        {
            string question = questions[new Random().Next(questions.Length)];
            Console.WriteLine(question);
            Thread.Sleep(4000);
            Console.WriteLine("Reflecting...");
            i += 6;
            ShowSpinner();
        }
    }

    private void ShowSpinner()
    {
        string[] spinnerFrames = { "|", "/", "-", "\\" };
        int frameIndex = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"\r{spinnerFrames[frameIndex]}");
            Thread.Sleep(500);
            frameIndex = (frameIndex + 1) % spinnerFrames.Length;
        }

        Console.WriteLine();
    }
}
