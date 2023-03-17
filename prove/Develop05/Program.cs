using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> _goalList = new List<Goal>(); 

        string userChoice = "";
        int points = 0;

        while(userChoice != "6")
        {
            Console.WriteLine();

            Console.WriteLine($"You have {points} points.");

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
                    string name = Console.ReadLine();

                    Console.Write("What is a short desciption of it? ");
                    string description = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    string goalScore = Console.ReadLine();
                    int point = int.Parse(goalScore);

                    Simple sGoal = new Simple(name, description, point);
                    _goalList.Add(sGoal);
                    Thread.Sleep(2000);
                }

                if(goalType == "2")
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();

                    Console.Write("What is a short desciption of it? ");
                    string description = Console.ReadLine();

                    Eternal eGoal = new Eternal(name, description);
                    _goalList.Add(eGoal);
                }

                if(goalType == "3")
                {
                    
                }

            }
            else if(userChoice == "2")
            {
                int index = 0;
                foreach(Goal goal in _goalList)
                {
                    index += 1;
                    Console.WriteLine($"{index}. [ ] {goal}");
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

    public static void DisplayGoalInformation(Goal goal)
    {
        // string 
    }
}