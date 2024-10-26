using System;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    
    public void DisplayStartMessage()
    {    
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine($"\n{_description}");
        Console.Write($"\nHow long, in seconds, would you like for your session? ");
        string userDuration = Console.ReadLine();
        _duration = int.Parse(userDuration);

        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(5);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
        Console.WriteLine();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationString = new List<string> {"|", "/", "-", "\\", "|", "/", "-", "\\"};
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationString.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {   
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public abstract void Run();
}