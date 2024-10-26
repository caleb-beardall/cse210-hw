using System;

public class BreathingActivity : Activity
{
    //No variables needed

    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    
    public override void Run()
    {
        int numberOfBreaths = (int)(Math.Floor((double)_duration / 10));

        for (int d = numberOfBreaths; d > 0; d--)
        {
            Console.Write("\nBreathe in...");
            for (int i = 4; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.Write("\nNow breathe out...");
            for (int i = 6; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine();
        }

        double remainder = _duration % 10;

        int split = (int)(Math.Ceiling(remainder / 2));

        Console.Write("\nBreathe in...");
        for (int i = split; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.Write("\nNow breathe out...");
        for (int i = split; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine();
    }
}
