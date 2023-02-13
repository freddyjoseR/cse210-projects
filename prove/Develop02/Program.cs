using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int menu =0;



        Journal journal = new Journal();
        JournalFile fileManager = new JournalFile();

        DateTime theCurrentTime = DateTime.Now; // Date Object 


        string dateText = theCurrentTime.ToShortDateString(); // 1/27/2023


        Random randomObject = new Random();
        


        while( menu !=5)
        {
            Console.WriteLine("1 - Write in Journal");
            Console.WriteLine("2 - Display entries");
            Console.WriteLine("3 - Save to file");
            Console.WriteLine("4 - Load from file");
            Console.WriteLine("5 - Exit");


            Console.WriteLine();
            Console.Write("Select one  of these: ");
            menu = int.Parse(Console.ReadLine());


            int randomNumber = randomObject.Next(0, 4); 


            if (menu == 1)
            {

                
                journal.ShowPrompt(randomNumber);

                Console.WriteLine("INGRESA RESPUESTA: ");
                string answer = Console.ReadLine();
                journal.addEntry(dateText , journal._prompts[randomNumber] , answer);

            }


            else if(menu == 2)
            {   
                journal.DisplayEntries();
            }


            else if(menu == 3)
            
            {
                
                fileManager.saveFile(journal._entriesFromUser);
        
                
            }

            
            else if(menu == 4)
            
            {
                
                fileManager.LoadFile(journal._entriesFromUser);

            }
        }

   }
}