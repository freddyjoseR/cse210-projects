using System;

class Program
{
    static void Main(string[] args)
    {
        Random ramdomGenerator = new Random();
        int magicNumber = ramdomGenerator.Next(1, 101);

        int GuessNumber = -1;

        while (GuessNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            string number2 = Console.ReadLine();
            GuessNumber = int.Parse(number2);
            
            if (GuessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (GuessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}