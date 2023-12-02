using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>
        {
            new Video("Create a Santa with recycled materials", "CraftsForEveryone", "10:30"),
            new Video("How to keep your toddler busy", "BusyMama", "15:45"),
            new Video("Best restaurants in Lisbon", "LisbonGirl", "08:20")
        };

        foreach (var video in videos)
        {
            for (int i = 0; i < 3; i++)
            {
                video.CommentList.Add(new Comment($"Commenter {i + 1}", $"This is comment {i + 1} on {video.Title}"));
            }

            video.DisplayDetails();
            Console.WriteLine();
        }
    }
}
