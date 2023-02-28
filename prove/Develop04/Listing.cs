using System;

public class Listing : Activity
{
    private string[] _prompts = {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};   
    private List<string> _itemsList = new List<string>();
    
    public void GetPrompt()
    {
        Random randomObject = new Random();

        int randomIndex = randomObject.Next(0, _prompts.Count());

        Console.WriteLine("List as many responses as you can to the following prompt:");

        Console.WriteLine($"--- {_prompts[randomIndex]} ---");
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

    public void CreateList()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_activityDuration);

        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            Console.Write("> ");
            string userType = Console.ReadLine();
            _itemsList.Add(userType);

            currentTime = DateTime.Now;
        }
        
        Console.WriteLine($"You listed {_itemsList.Count()} items!");

        Console.WriteLine();
    } 
}