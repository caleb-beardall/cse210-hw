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
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}