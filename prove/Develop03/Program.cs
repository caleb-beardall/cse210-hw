using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Ether", 12, 27);

        Scripture scripture1 = new Scripture(reference1, "Testing the program.");

        string userInput;

        int numberToHide = 0;

        do
        {            
            Console.WriteLine($"{reference1.GetDisplayText()} {scripture1.GetDisplayText()}");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();
            
            Random random = new Random();

            numberToHide += random.Next(0, 3);

            scripture1.HideRandomWords(numberToHide);
            
        } while (!(userInput == "quit" || scripture1.IsCompletelyHidden() == true));

        Console.WriteLine();
        Console.WriteLine("Thank you.");
    }
}