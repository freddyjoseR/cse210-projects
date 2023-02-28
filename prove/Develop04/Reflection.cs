using System;

class Reflection : Activity
{
    private string[] _prompts = {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."}; 

    private string[] _reflectionQuestions = {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

    public void GetPrompt()
    {
        Random randomObject = new Random();

        int randomIndex = randomObject.Next(0, _prompts.Count());

        Console.WriteLine("Consider the following prompt:");
        
        Console.WriteLine();

        Console.WriteLine($"--- {_prompts[randomIndex]} ---");
    }

    public void GetContinuingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string userInput = Console.ReadLine();
        
        if(userInput != "quit")
        {
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");

            Console.Write("5");
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the last line

            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the last line

            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the last line
            
            Console.Write("2"); // Replace it with the new character
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the last line

            Console.Write("1"); // Replace it with the new character
            Thread.Sleep(1000);
            Console.WriteLine("\b \b"); // Erase the last line

        }
    }
    public void GetReflectionQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_activityDuration);

        DateTime currentTime = DateTime.Now;

        Random randomObject = new Random();

        int randomIndex = randomObject.Next(0, _reflectionQuestions.Count());

        while (currentTime < futureTime)
        {
            Console.Write($"> {_reflectionQuestions[randomIndex]} ");
            GetLoadingAnimation(6);
            Console.WriteLine("\b \b"); // Erase the past character

            randomIndex = randomObject.Next(0, _reflectionQuestions.Count());
            currentTime = DateTime.Now;
        }

        Console.WriteLine();
    }
}