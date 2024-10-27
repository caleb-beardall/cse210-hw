using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    
    public ReflectingActivity(List<string> prompts, List<string> questions)
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = prompts;
        _questions = questions;
    }
    
    public override void Run()
    {
        Console.WriteLine("\nConsider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();

        double numberQuestionsAsked = (Math.Ceiling((double)_duration / 10));

        int numberPotentialQuestions = _questions.Count;

        double numberTimesThroughList = numberQuestionsAsked / numberPotentialQuestions;

        List<string> questionsToAsk = new List<string>{};

        for (double i = numberTimesThroughList; i > 0; i--)
        {
            if (i > 1)
            {
                List<string> miniQuestionsToAsk = new List<string>{};

                for (int ii = _questions.Count; ii > 0; ii--)
                {
                    string question = GetRandomQuestion();
                    
                    while (miniQuestionsToAsk.Contains(question))
                    {
                        question = GetRandomQuestion();
                    }

                    miniQuestionsToAsk.Add(question);
                }

                foreach (string question in miniQuestionsToAsk)
                {
                    questionsToAsk.Add(question);
                }
            }

            else
            {
                int numberQuestionsLeft = (int)(Math.Ceiling(numberQuestionsAsked % numberPotentialQuestions));
                
                List<string> miniQuestionsToAsk = new List<string>{};

                for (int ii = numberQuestionsLeft; ii > 0; ii--)
                {
                    string question = GetRandomQuestion();
                    
                    while (miniQuestionsToAsk.Contains(question))
                    {
                        question = GetRandomQuestion();
                    }

                    miniQuestionsToAsk.Add(question);
                }

                foreach (string question in miniQuestionsToAsk)
                {
                    questionsToAsk.Add(question);
                }
            }
        }

        foreach (string question in questionsToAsk)
        {
            Console.Write($"\n> {question} ");
            ShowSpinner(10);
        }

        Console.WriteLine();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];

        return randomPrompt;
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        string randomQuestion = _questions[index];

        return randomQuestion;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---");
    }
}