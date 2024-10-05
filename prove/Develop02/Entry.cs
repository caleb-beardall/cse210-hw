public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public int _dayRating;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} — Rating: {_dayRating}/10 — Prompt: {_promptText}");
        Console.WriteLine(_entryText);

    }
} 