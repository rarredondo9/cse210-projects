using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Length { get; set; }
    private List<Comment> commentList;

    public Video(string title, string author, string length)
    {
        Title = title;
        Author = author;
        Length = length;
        commentList = new List<Comment>();
    }

    public int GetNumberOfComments()
    {
        return commentList.Count;
    }

    public void AddComment(Comment comment)
    {
        commentList.Add(comment);
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length}");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
        DisplayComments();
    }

    private void DisplayComments()
    {
        foreach (var comment in commentList)
        {
            comment.Display();
        }
    }
}
