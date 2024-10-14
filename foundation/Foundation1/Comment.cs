using System;

public class Comment
{
    private string _commenter;
    private string _text;

    public Comment(string commenter, string text)
    {
        _commenter = commenter;
        _text = text;
    }

    public void DisplayCommentInfo()
    {
        Console.WriteLine($"{_commenter} said: \"{_text}\"");
    }
}
    