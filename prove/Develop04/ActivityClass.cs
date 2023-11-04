using System;

public abstract class ActivityClass
{
    protected string name;
    protected string description;
    protected int duration;

    public ActivityClass (string name, string description)
    {
        this.name = name;
        this.description = description;
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
        Console.WriteLine($"Great Job! You have completed the {name} Activity.");
        Console.WriteLine($"Duration: {duration} seconds");
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("Activity Completed.");
        System.Threading.Thread.Sleep(2000);
    }

    protected abstract void PerformActivity();
}