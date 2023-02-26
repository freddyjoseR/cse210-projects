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
            Console.WriteLine("  2. Start reflecting activity");
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

            }

            if (userChoice == "3")
            {

            }
        }
        
    }
}
