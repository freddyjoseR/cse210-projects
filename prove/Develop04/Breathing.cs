using System;

public class Breathing : Activity
{
    private string _breatheIn = "Breathe in";
    private string _breatheOut = "Now breathe out";

    // private int _activityDuration;

    //     public void GetActivityDuration(int time)
    // {
    //     _activityDuration = time;
    // }
    public void GetBreathingInstruction()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_activityDuration);

        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            Console.Write($"{_breatheIn}...");
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

            Console.Write($"{_breatheOut}...");
            Console.Write("6");
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the last line

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

            Console.WriteLine();
            currentTime = DateTime.Now;
        }
    }
}