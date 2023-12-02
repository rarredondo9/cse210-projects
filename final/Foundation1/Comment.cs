using System;

public class Comment
{
    public string Name { get; set; }
    public string CommentText { get; set; }

    public Comment(string name, string commentText)
    {
        Name = name;
        CommentText = commentText;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"Comment by {Name}: {CommentText}");
    }
}
