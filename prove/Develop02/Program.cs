using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
/*
To exceed the assignment's requirements I added a "Rating" to the list of Entry variables.
As part of that Rating's code, I made a loop that forces the use to enter a number between 1 and 10.
I also read online about how to implement the DateTime object and added it to my Programs class.
*/
class Program

{
    static void Main(string[] args)
    {
        int userNumber;

        PromptGenerator prompt1 = new PromptGenerator();
        
        //Adding the prompt strings to _prompt in PromptGenerator
        prompt1.AddPrompt("What did you do with your family today?");
        prompt1.AddPrompt("What did you do at work today?");
        prompt1.AddPrompt("did you do anything you ENJOY today?");
        prompt1.AddPrompt("Did you do anything you REGRET today?");
        prompt1.AddPrompt("What was the BEST part of your day?");
        prompt1.AddPrompt("What was the WORST part of your day?");

        Journal journal1 = new Journal();

        //Terminal menu do while loop
        do
        {   
            //Writing the terminal menu options
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string userChoice = Console.ReadLine();
            userNumber = int.Parse(userChoice);

            //1. Write
            if (userNumber == 1)
            {
                Entry newEntry = new Entry();

                //Setting _date using DateTime
                DateTime now = DateTime.Now;
                string formattedDate = now.ToString("MM/dd/yyyy");
                newEntry._date = formattedDate;
                
                //Setting the user's response to _dayRating
                Console.WriteLine("How would you rate your today on scale of 1 to 10? ");
                
                int ratingNumber;

                ratingNumber = int.Parse(Console.ReadLine());

                //Forcing the user to pick an integer between 1 and 10
                while (ratingNumber > 10 || ratingNumber < 0 )
                {
                    Console.WriteLine("Please pick an integer between 1 and 10. ");
                    ratingNumber = int.Parse(Console.ReadLine());
                }

                //Setting ratingNumber to _dayRating
                newEntry._dayRating = ratingNumber;
                
                //Setting _promptText using GetRandomPrompt from PromptGenerator
                newEntry._promptText = prompt1.GetRandomPrompt();
                Console.WriteLine(newEntry._promptText);

                //Setting the user's response to _entryText
                Console.Write("> ");
                newEntry._entryText = Console.ReadLine();
                //Console.WriteLine(newEntry._entryText);

                //Adding newEntry to Entry using AddEntry from Journal
                journal1.AddEntry(newEntry);

                Console.WriteLine();
            }
            
            //2. Display
            else if (userNumber == 2)
            {
                //Run DisplayAll function from Journal
                journal1.DisplayAll();

                Console.WriteLine();
            }
            
            //3. Save
            else if (userNumber == 3)
            {
                string saveFile;

                //Ask user for file name
                Console.WriteLine("What is the filename?" );
                saveFile = Console.ReadLine();
                Console.WriteLine($"Journal saved as: {saveFile}");

                //Run SaveToFile function from Journal
                journal1.SaveToFile(saveFile);

                Console.WriteLine();
            }

            //4. Load
            else if (userNumber == 4)
            {
                Journal journal2 = new Journal();
                
                string loadFile;

                //Ask user for file name
                Console.WriteLine("What is the filename?" );
                loadFile = Console.ReadLine();
                Console.WriteLine($"Journal loaded from: {loadFile}");

                //Run LoadFromFile function from Journal
                List<Entry> newEntries = journal1.LoadFromFile(loadFile);

                //Iterate through the newEntries and add them to Journal
                //using AddEntry from Journal
                foreach (Entry i in newEntries)
                {
                    journal2.AddEntry(i);
                }

                //Display the updated Journal's results
                //using DisplayAll from Journal
                journal2.DisplayAll();

                Console.WriteLine();
            }

            else if (userNumber == 5)
            {
                Console.Write("");
            }

            //5. Quit
            else
            {
                Console.WriteLine("You entered and invalid entry. Please try again.");

                Console.WriteLine();
            }

        } while (!(userNumber == 5));

        Console.WriteLine("Thank you.");
        
    }
}