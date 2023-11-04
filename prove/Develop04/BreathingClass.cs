using System;
using System.Reflection.Metadata;
using System.Threading;

public class BreathingClass : ActivityClass
{
    public BreathingClass() : base("Breathing","This activity will help you relac by walking you through breathing in and out slowly. Clear your mind and focus onyour breathing. " )
    {}

    protected override void PerformActivity()
    {
        BreathingRoutine();
    }

    private void BreathingRoutine()
    {
        string[] messages = {"Breathe in...", "Breathe out..."};
        for (int i = 0; i < duration; i++)
        {
            foreach (string message in messages)
            {
                Console.WriteLine(message);
                Thread.Sleep(2000);
            }
        }
    }
}