using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "";

        while(userChoice != "4")
        {
            // This will clear the console
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Selec a choice from the menu: ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                // This will clear the console
                Console.Clear();
                Breathing breathing = new Breathing();

                breathing.GetActivityName("Breathing");
                Console.WriteLine(breathing.GetWelcomeMessage());

                Console.WriteLine();
                breathing.GetActivityDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

                Console.WriteLine();
                Console.Write("How long, in seconds, would you like for your session? ");
                string activityTime = Console.ReadLine();
                int time = int.Parse(activityTime);
                Console.WriteLine(time);
                breathing.GetActivityDuration(time);

                // This will clear the console
                Console.Clear();
                
                // This will display a brief waiting time to begin activity
                breathing.GetReadyMessage();
                
                breathing.GetBreathingInstruction();

                breathing.GetCompletionMessage(time);
            }

            if (userChoice == "2")
            {
                // This will clear the console
                Console.Clear();
                Reflection reflection = new Reflection();

                reflection.GetActivityName("Reflection");
                Console.WriteLine(reflection.GetWelcomeMessage());

                Console.WriteLine();
                reflection.GetActivityDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

                Console.WriteLine();
                Console.Write("How long, in seconds, would you like for your session? ");
                string activityTime = Console.ReadLine();
                int time = int.Parse(activityTime);
                Console.WriteLine(time);
                reflection.GetActivityDuration(time);

                // This will clear the console
                Console.Clear();
                
                // This will display a brief waiting time to begin activity
                reflection.GetReadyMessage();

                reflection.GetPrompt();

                reflection.GetContinuingMessage();

                // This will clear the console
                Console.Clear();
                reflection.GetReflectionQuestions();

                reflection.GetCompletionMessage(time);
            }

            if (userChoice == "3")
            {
                // This will clear the console
                Console.Clear();
                Listing listing = new Listing();

                listing.GetActivityName("Listing");
                Console.WriteLine(listing.GetWelcomeMessage());

                Console.WriteLine();
                listing.GetActivityDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

                Console.WriteLine();
                Console.Write("How long, in seconds, would you like for your session? ");
                string activityTime = Console.ReadLine();
                int time = int.Parse(activityTime);
                Console.WriteLine(time);
                listing.GetActivityDuration(time);

                // This will clear the console
                Console.Clear();
                
                // This will display a brief waiting time to begin activity
                listing.GetReadyMessage();

                listing.GetPrompt();

                listing.CreateList();

                listing.GetCompletionMessage(time);
            }
        }
        
    }
}
