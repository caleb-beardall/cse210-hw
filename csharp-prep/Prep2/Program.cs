using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the grade percentage? ");
        string valueInText = Console.ReadLine();

        float gradePercentage = float.Parse(valueInText);

        string letter = "";

        if (gradePercentage < 60)
        {
            letter = "F";
        }
        else if (gradePercentage >= 60 && gradePercentage < 70)
        {
            letter = "D";
        }
        else if (gradePercentage >= 70 && gradePercentage < 80)
        {
            letter = "C";
        }
        else if (gradePercentage >= 80 && gradePercentage < 90)
        {
            letter = "B";
        }
        else
        {
            letter = "A";
        }

        if (gradePercentage >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("You didn't pass the class. Better luck next time!");
        }

        string letterSign = "";

        if (gradePercentage >= 93 || gradePercentage < 60)
        {
            letterSign = "";
        }
        else if (gradePercentage < 93 && gradePercentage >= 60)
        {
            float modulus = gradePercentage % 10;

            if (modulus >= 7)
            {
                letterSign = "+";
            }
            else if (modulus < 7 && modulus >= 3)
            {
                letterSign = "";
            }
            else
            {
                letterSign = "-";
            }
        }

        Console.WriteLine($"Your grade is: {letter}{letterSign}");
    }
}