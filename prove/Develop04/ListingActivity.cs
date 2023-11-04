using System;
using System.Threading;

public class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    protected override void PerformActivity()
    {
        Console.WriteLine($"Prompt: {prompts[new Random().Next(prompts.Length)]}");
        Thread.Sleep(2000);
        Console.WriteLine("Start listing items (type 'q' to finish):");
        int itemCount = 0;
        DateTime startTime = DateTime.Now;
        while (DateTime.Now - startTime < TimeSpan.FromSeconds(duration))
        {
            string item = Console.ReadLine();
            if (item.ToLower() == "q")
                break;
            itemCount++;
        }
        Console.WriteLine($"You listed {itemCount} items.");
    }
}
