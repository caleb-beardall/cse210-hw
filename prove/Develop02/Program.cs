using System;

class Program

{
    static void Main(string[] args)
    {
        int userNumber;

        do
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string userChoice = Console.ReadLine();
            userNumber = int.Parse(userChoice);
            Console.WriteLine();

            if (userNumber == 1)
            {
                Console.WriteLine("You chose: 1. Write");
            }
            
            else if (userNumber == 2)
            {
                Console.WriteLine("You chose: 2. Display");
            }
            
            else if (userNumber == 3)
            {
                Console.WriteLine("You chose: 3. Load");
            }

            else if (userNumber == 4)
            {
                Console.WriteLine("You chose: 4. Save");
            }
            else
            {
                Console.WriteLine("You entered and invalid entry. Please try again.");
            }

 
        } while (!(userNumber == 5));

        Console.WriteLine("Thank you.");
        
    }
}