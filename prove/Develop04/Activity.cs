using System;

public class Activity
{

    private string _activityName;
    private string _activityDescription;

    protected int _activityDuration;

        public void GetActivityDuration(int time)
    {
        _activityDuration = time;
    }
    
    public string GetActivityName(string activityName)
    {
        return _activityName = activityName;
    }

    public string GetActivityDescription(string activityDescription)
    {
        Console.WriteLine(activityDescription);
        return _activityDescription = activityDescription;
    }

    public string GetWelcomeMessage()
    {
        return $"Welcome to the {_activityName} Activity.";
    }

    public void GetReadyMessage()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(6);
        DateTime currentTime = DateTime.Now;

    Console.WriteLine("Get ready...");
        while (currentTime < futureTime)
        {    
            GetLoadingAnimation(1);

            currentTime = DateTime.Now; // Update time for making the loop to stop
        }
        Console.WriteLine();
    }

        public void GetCompletionMessage(int activityDuration)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(6);
        DateTime currentTime = DateTime.Now;

        Console.WriteLine("Well done!!");
        while (currentTime < futureTime)
        {    
            GetLoadingAnimation(1);

            currentTime = DateTime.Now; // Update time for making the loop to stop
        }
        Console.WriteLine();

        DateTime startTime2 = DateTime.Now;
        DateTime futureTime2 = startTime2.AddSeconds(6);
        DateTime currentTime2 = DateTime.Now;        

        Console.WriteLine($"You have completed another {activityDuration} seconds of the {_activityName} Activity.");
        while (currentTime2 < futureTime2)
        {    
            GetLoadingAnimation(1);
            currentTime2 = DateTime.Now; // Update time for making the loop to stop
        }
    }

    protected void GetLoadingAnimation(int timesToRepeat)
    {
        List<int> times = new List<int>();
        int count = 0;

        while(count != timesToRepeat)
        {
            count += 1;
            times.Add(count);
        }

        foreach(int time in times)
        {
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the last character
            
            Console.Write("\\"); // Replace it with the new character
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the past character
            
            Console.Write("|"); // Replace it with the new character
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the past character
            
            Console.Write("/"); // Replace it with the new character
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the past character
        }
    }
}