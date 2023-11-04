using System;

public abstract class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void SetDuration(int duration)
    {
        this.duration = duration;
    }

    public void Start()
    {
        DisplayStartingMessage();
        PerformActivity();
        DisplayEndingMessage();
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {name} Activity:");
        Console.WriteLine(description);
        Console.WriteLine($"Duration: {duration} seconds");
        Console.WriteLine("Prepare to begin...");
        System.Threading.Thread.Sleep(2000);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine($"Great job! You have completed the {name} Activity.");
        Console.WriteLine($"Duration: {duration} seconds");
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("Activity completed.");
        System.Threading.Thread.Sleep(2000);
    }
    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Countdown: {i} seconds");
            Thread.Sleep(1000); // Pause for 1 second
        }
    }

    protected abstract void PerformActivity();
}
