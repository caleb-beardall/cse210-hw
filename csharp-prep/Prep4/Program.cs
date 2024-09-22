using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Mail;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finishd.");

        int number;

        do
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (!(number == 0))
            {
                numbers.Add(number);
            }

        } while (!(number == 0));

        //Finding the sum of the list.
        int sum = 0;
        foreach (int i in numbers)
        {
            sum += i;
        }
        Console.WriteLine($"The sum is: {sum}");

        //Finding the list's average.
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Finding the largest number.
        int largestNumber = numbers[0];
        foreach (int i in numbers)
        {
            if (i > largestNumber)
            {
                largestNumber = i;
            }
        }
        Console.WriteLine($"The largest number is: {largestNumber}");

        //Finding the smallest positive number.
        int smallestNumber = numbers[0];
        foreach (int i in numbers)
        {
            if (i < smallestNumber && i > 0)
            {
                smallestNumber = i;
            }
        }

        if (smallestNumber < 0)
        {
            Console.WriteLine("No positive number was entered.");
        }
        else
        {
            Console.WriteLine($"The smallest positive number is: {smallestNumber}");
        }
        
        //Sorting the list from smallest to largest.
        Console.WriteLine("The sorted list is: ");
        numbers.Sort();

        //Printing the list.
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

    }
}