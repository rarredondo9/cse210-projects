using System

public class ActivityClass
{
    protected string name;
    protected string description;
    protected int duration;

    public ActivityClass (string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void SetDuration (int duration)
    {
        this.duration = duration;
    }

    public void StarActivity()
    {
        DisplayStartingMessage();
        PerformActivity();
        DisplayEndingMessage();
    }
}