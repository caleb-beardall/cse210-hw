using System;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments;

    public Video(string title, string author, double length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public int GetCommentCount()
    {
        int count = _comments.Count();
        return count;
    }

    public void DisplayComments()
    {
        foreach (Comment i in _comments)
        {
            i.DisplayCommentInfo();
        }
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Video Title: {_title}");
        Console.WriteLine($"Video Author: {_author}");
        Console.WriteLine($"Video Length: {_length} sec");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        DisplayComments();
        Console.WriteLine();
    }
}