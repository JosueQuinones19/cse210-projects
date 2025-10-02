using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // length in seconds

    // A list to store comments
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    // Method to add a comment
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    // Method to display video info
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of Comments: {comments.Count}");

        foreach (var comment in comments)
        {
            Console.WriteLine($"   {comment.UserName}: {comment.Text}");
        }

        Console.WriteLine();
    }
}
