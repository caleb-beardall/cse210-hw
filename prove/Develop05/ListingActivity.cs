using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(List<string> prompts)
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = prompts;
    }
    
    public override void Run()
    {
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---");
        Console.Write("\nYou may begin in: ");
        ShowCountDown(5);

        Console.WriteLine();

        _count = GetListFromUser().Count();

        Console.WriteLine($"You listed {_count} items!");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];

        return randomPrompt;
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>{};
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string userString = Console.ReadLine();

            userList.Add(userString);
        }

        return userList;
    }
}