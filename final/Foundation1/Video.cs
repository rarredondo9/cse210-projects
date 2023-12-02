using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Length { get; set; }
    public List<Comment> CommentList { get; set; }

    public Video(string title, string author, string length)
    {
        Title = title;
        Author = author;
        Length = length;
        CommentList = new List<Comment>();
    }

    public int ComputeNumberOfComments()
    {
        return CommentList.Count;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length}");
        Console.WriteLine($"Number of comments: {ComputeNumberOfComments()}");
        DisplayComments();
    }

    public void DisplayComments()
    {
        foreach (var comment in CommentList)
        {
            comment.DisplayComment();
        }
    }
}
