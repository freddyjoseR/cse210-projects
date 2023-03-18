using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goalList = new List<Goal>(); 

        string userChoice = "";
        int startingPoints = 0;

        while(userChoice != "6")
        {
            Console.WriteLine();

            Console.WriteLine($"You have {startingPoints} points.");

            Console.WriteLine();

            Console.WriteLine("Menu Options:");

            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");

            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();
            int option = int.Parse(userChoice);

            if(userChoice == "1")
            {
                Console.WriteLine("The types of goals are:");
                Console.WriteLine(" 1. Simple Goal");
                Console.WriteLine(" 2. Eternal Goal");
                Console.WriteLine(" 3. Checklist Goal");

                Console.Write("Which type of goal would you like to create? ");
                string goalType = Console.ReadLine();

                if(goalType == "1")
                {
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();

                    Console.Write("What is a short description of it? ");
                    string goalDescription = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    string goalScore = Console.ReadLine();
                    int points = int.Parse(goalScore);

                    Simple simpleGoal = new Simple(goalName, goalDescription, points, "[ ]");

                    goalList.Add(simpleGoal);
                }

                else if(goalType == "2")
                {
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();

                    Console.Write("What is a short description of it? ");
                    string goalDescription = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    string goalScore = Console.ReadLine();
                    int points = int.Parse(goalScore);

                    Eternal eternalGoal = new Eternal(goalName, goalDescription, points, "[ ]");

                    goalList.Add(eternalGoal);
                }

                else if(goalType == "3")
                {
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();

                    Console.Write("What is a short description of it? ");
                    string goalDescription = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    string goalScore = Console.ReadLine();
                    int points = int.Parse(goalScore);

                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    string timesToAccomplished = Console.ReadLine();
                    int times = int.Parse(timesToAccomplished);

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    string bonusScore = Console.ReadLine();
                    int bonus = int.Parse(timesToAccomplished);

                    Checklist checklistGoal = new Checklist(goalName, goalDescription, points, times, bonus, "[ ]");

                    goalList.Add(checklistGoal);
                }

            }

            if(userChoice == "2")
            {
                int index = 0;

                Console.WriteLine("The Goals are:");

                foreach (Goal goal in goalList)
                {
                    index += 1;
                    goal.GetGoalInformation(index);
                }
            }   

            else if(userChoice == "3")
            {
                Console.WriteLine("Save goals");
            }

            else if(userChoice == "4")
            {
                Console.WriteLine("Load goals");
            }

            else if(userChoice == "5")
            {
                Console.WriteLine("Record event");
            }
            
        }
    }

}