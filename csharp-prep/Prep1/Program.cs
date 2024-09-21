using System;

class Program
{
    static void Main(string[] args)
    /*
    What is your first name? Brigham
    What is your last name? Young

    Your name is Young, Brigham Young.
    */
    {
        Console.Write("What is your first name? ");
        string fname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lname = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");
    }
}