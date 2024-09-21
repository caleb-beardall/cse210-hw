using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string play = "yes";
        
        do
        {
            int guessCount = 0;

            int guess;

            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);

            Console.WriteLine($"Hint: The number is {number}.");

            do
            {
                    Console.Write("What is your guess? ");
                    string userInput = Console.ReadLine();

                    guess = int.Parse(userInput);

                    guessCount = guessCount + 1;

                    if (number > guess)
                        {
                            Console.WriteLine("Higher");
                        }
                    else if (number < guess)
                        {
                            Console.WriteLine("Lower");
                        }
                    else
                        {
                            Console.WriteLine("You guessed it!");
                            Console.WriteLine($"Number of tries: {guessCount}");
                        }

            }   while (!(number == guess));

            Console.Write("Play again?(yes/no) ");
            play = Console.ReadLine();

        } while (play == "yes");

        Console.WriteLine("Thank you for playing!");
    
    }
}