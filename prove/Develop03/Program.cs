using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference();
        Scripture scripture = new Scripture();
        Memorizer memorizer = new Memorizer();
        

        string userAction = "yes"; 
        
        // // This will clear the console
        Console.Clear();


        while (userAction != "quit") 
        {
            // This will clear the console
            Console.Clear();
            reference.DisplayReference(); //Displays the reference on screen
            Console.Write(" "); // This is for separating the reference from the scripture text
            scripture.GetScripture(); // Displays the scripture text
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            userAction = Console.ReadLine();  

            // Replace words with underscores
            memorizer.ReplaceWords(scripture);
        

            // Verify if all words are hidden

            // if metodo = true. The program continues
            if (memorizer._replacedWords.Count() != scripture._words.Count())
            {
                continue;
            }
            else // If not it will stop
            {
                break;
            }
        }
        memorizer.DisplayList();
    }
}