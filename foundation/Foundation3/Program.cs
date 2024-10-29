using System;

class Program
{
    static void Main(string[] args)
    {
        Running rActivity = new Running("Running", "10/28/24", 30, 5);

        Cycling cActivity = new Cycling("Cycling", "10/25/2024", 45, 13.5);

        Swimming sActivity = new Swimming("Swimming", "10/23/2024", 60, 50);

        List<Activity> activities = new List<Activity>{rActivity, cActivity, sActivity};

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}