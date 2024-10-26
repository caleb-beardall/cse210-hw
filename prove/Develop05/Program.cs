using System;
using System.Reflection;
using System.Runtime.InteropServices;

/*
To exceed this program's expectations, I wrote the Reflecting Activity so that
the program would go through every question and then repeating itself. So,
if the user ran the activity for 221 second (waiting for 10 seconds at each question),
the program would go through the list of all 9 questions, and then it would go through
the 9 questions again, and then it would list another 5 unique questions.
*/

class Program
{
    static void Main(string[] args)
    {
        
        //Menu loop resources
        int userNumber;
        List<int> validNumbers = new List<int> {1, 2, 3, 4};
        bool validOption;
        
        BreathingActivity bActivity = new BreathingActivity();

        List<string> listReflectingPrompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        List<string> listQuestions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        ReflectingActivity rActivity = new ReflectingActivity(listReflectingPrompts, listQuestions);

        List<string> listListingPrompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };

        ListingActivity lActivity = new ListingActivity(listListingPrompts);

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            if (validNumbers.Contains(userNumber))
            {
                validOption = true;
            }
        
            else
            {
                validOption = false;
            }


            while (validOption == false)
            {
                Console.WriteLine();
                Console.WriteLine("Please select a valid menu option.");
                userInput = Console.ReadLine();
                userNumber = int.Parse(userInput);

                if (validNumbers.Contains(userNumber))
                {
                    validOption = true;
                }
            
                else
                {
                    validOption = false;
                }
            }

            if (userNumber == 1)
            {
                Console.Clear();
                bActivity.DisplayStartMessage();
                bActivity.Run();
                bActivity.DisplayEndMessage();
            }

            else if (userNumber == 2)
            {
                Console.Clear();
                rActivity.DisplayStartMessage();
                rActivity.Run();
                rActivity.DisplayEndMessage();
            }

            else if (userNumber == 3)
            {
                Console.Clear();
                lActivity.DisplayStartMessage();
                lActivity.Run();
                lActivity.DisplayEndMessage();
            }

        } while (!(userNumber == 4));

        Console.WriteLine("\nMindfulness Program completed. Thank you.");
    }
}