using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string NumberFromUser = Console.ReadLine();
        int percantage = int.Parse(NumberFromUser);

        string letter = "";

        if (percantage >= 90)
        {
            letter = "A";
        }
        else if (percantage >= 80)
        {
            letter = "B";
        } 
        else if (percantage >= 70)
        {
            letter = "C";
        }
        else if (percantage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        } 
        
        Console.WriteLine ($"Your grade is: {letter}.");

        if (percantage >= 70)
        {
            Console.WriteLine("Congratulations, you have approved this course!");
        }
        else
        {
            Console.WriteLine("You couldn't pass this course. Better luck next time.");
        }

    }
}