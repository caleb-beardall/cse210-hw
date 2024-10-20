using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Ether", 12, 27);

        Scripture scripture1 = new Scripture(reference1, "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");

        string userInput;

        int numberToHide = 0;

        bool isCompletelyHidden;

        do
        {            
            isCompletelyHidden = scripture1.IsCompletelyHidden();

            Console.WriteLine($"{reference1.GetDisplayText()} {scripture1.GetDisplayText()}");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();

            Console.Clear();
            
            Random random = new Random();

            numberToHide += random.Next(5, 10);

            scripture1.HideRandomWords(numberToHide);
            
        } while (!(userInput == "quit" || isCompletelyHidden == true));

        Console.WriteLine();
        Console.WriteLine("Scripture memorized. Nice work!");
    }
}