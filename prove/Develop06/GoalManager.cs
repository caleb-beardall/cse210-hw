using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.IO;
/*
To exceed the project's requirements, I wrote the program so that the user can't try to
complete a Simple or Checklist goal if they have (if they do, they're confronted with a message).
I also made it so that the program keeps track of how many goals the user has completed.
*/

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _numberCompleted;

    public GoalManager()
    {
        _goals = new List<Goal>{};
        _score = 0;
        _numberCompleted = 0;
    }

    public void Start()
    {
        int userNumber; 

        do
        {
            DisplayPlayerInfo();
            Console.WriteLine();

            Console.WriteLine("Menu Options");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Goals");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            if (userNumber == 1)
            {
                CreateGoal();
            }

            else if (userNumber == 2)
            {
                ListGoalDetails();
            }

            else if (userNumber == 3)
            {
                SaveGoals();
            }

            else if (userNumber == 4)
            {
                LoadGoals();
            }

            else if (userNumber == 5)
            {
                RecordEvent();
            }

        } while (!(userNumber == 6));

        Console.WriteLine("Thank you.");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} point(s) and have completed {_numberCompleted} goal(s).");
    }

    public void ListGoalNames()
    {
        int i = 1;

        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{i}. {g.GetGoalName()}");

            i++;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine();
        Console.WriteLine("Your goals are: ");

        int i = 1;

        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{i}. {g.GetDetailsString()}");

            i++;
        }

        Console.WriteLine();
    }

    public void CreateGoal()
    {
        int goalType;
        
        do
        {
            Console.WriteLine("\nThe goal types are: ");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");
            Console.Write("Which goal type would you like to create? ");
            string userInput = Console.ReadLine();
            goalType = int.Parse(userInput);

            Console.WriteLine();

        } while (!(goalType == 1 || goalType == 2 || goalType == 3));

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();

        Console.Write("How many points is this goal worth? ");
        string userPoints = Console.ReadLine();
        int goalPoints = int.Parse(userPoints);

        if (goalType == 1)
        {
            SimpleGoal sGoal = new SimpleGoal(goalName, goalDescription, goalPoints);

            _goals.Add(sGoal);
        }

        else if (goalType == 2)
        {          
            EternalGoal eGoal = new EternalGoal(goalName, goalDescription, goalPoints);

            _goals.Add(eGoal);
        }

        else
        {     
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string userTarget = Console.ReadLine();
            int goalTarget = int.Parse(userTarget);

            Console.Write("What is the bonus for accomplishing it that many times? ");
            string userBonus = Console.ReadLine();
            int goalBonus = int.Parse(userBonus);

            ChecklistGoal cGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus);

            _goals.Add(cGoal);
        }

        Console.WriteLine();
    }

    public void RecordEvent()
    {
        Console.WriteLine();
        Console.WriteLine("You goals are: ");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        string userAccomplished = Console.ReadLine();
        int goalAccomplished = int.Parse(userAccomplished);

        if (_goals[goalAccomplished - 1].IsComplete() != true)
        {
            _goals[goalAccomplished - 1].RecordEvent();
            _score += _goals[goalAccomplished - 1].GetPoints();
            _numberCompleted += 1;
            Console.WriteLine($"You now have {_score} points.");
        }

        else
        {
            Console.WriteLine($"It looks like you already completed that non-Eternal goal.");
            Console.WriteLine($"Plase pick a goal that hasn't been completed.");
        }

        Console.WriteLine();
    }

    public void SaveGoals()
    {
        Console.Write("\nWhat is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_score},{_numberCompleted}");

            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentations());
            }
        }

        Console.WriteLine();
    }

    public void LoadGoals()
    {
        _goals = new List<Goal>{};
        _score = 0;
        _numberCompleted = 0;
        
        Console.Write("\nWhat is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            if (parts[0] == "SimpleGoal")
            {
                string goalName = parts[1];
                string goalDescription = parts[2];
                int goalPoints = int.Parse(parts[3]);
                bool goalCompleted = bool.Parse(parts[4]);
                
                SimpleGoal sGoal = new SimpleGoal(goalName, goalDescription, goalPoints, goalCompleted);

                _goals.Add(sGoal);
            }

            else if (parts[0] == "EternalGoal")
            {          
                string goalName = parts[1];
                string goalDescription = parts[2];
                int goalPoints = int.Parse(parts[3]);EternalGoal eGoal = new EternalGoal(goalName, goalDescription, goalPoints);

                _goals.Add(eGoal);
            }

            else if (parts[0] == "ChecklistGoal")
            {     
                string goalName = parts[1];
                string goalDescription = parts[2];
                int goalPoints = int.Parse(parts[3]);
                bool goalCompleted = bool.Parse(parts[4]);
                int goalTarget = int.Parse(parts[5]);
                int goalBonus = int.Parse(parts[6]);

                ChecklistGoal cGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalCompleted, goalTarget, goalBonus);

                _goals.Add(cGoal);
            }

            else
            {
                _score = int.Parse(parts[0]);
                _numberCompleted = int.Parse(parts[1]);
            }

            Console.WriteLine();
        }
    }
}