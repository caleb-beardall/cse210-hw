using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "This is an example string to split.";

        string[] words = input.Split(' ');

        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}