using System;
using System.Threading;

public class MeditationActivity : Activity
{
    private string[] meditationTopics = {
        "Peace and tranquility",
        "Mindfulness and awareness",
        "Visualization and relaxation"
    };

    public MeditationActivity() : base("Meditation", "Meditation activity for inner peace.")
    {
    }

    protected override void PerformActivity()
    {
        Console.WriteLine($"Topic: {meditationTopics[new Random().Next(meditationTopics.Length)]}");
        Console.WriteLine("Begin your meditation session.");
        Meditate();
    }

    private void Meditate()
    {
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Breathe deeply and relax...");
            Thread.Sleep(2000); 
            Console.WriteLine("Clear your mind and focus...");
            Thread.Sleep(2000); 
            Console.WriteLine("Find your inner peace...");
            Thread.Sleep(2000); 
        }
    }
}
