using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var videos = new List<Video>
        {
            new Video("Video 1 Title", "Author 1", "10:30"),
            new Video("Video 2 Title", "Author 2", "15:45"),
            new Video("Video 3 Title", "Author 3", "08:20")
        };

        foreach (var video in videos)
        {
            for (int i = 0; i < 3; i++)
            {
                video.AddComment(new Comment($"Commenter {i + 1}", $"This is comment {i + 1} on {video.Title}"));
            }

            video.DisplayDetails();
            Console.WriteLine();
        }
    }
}
