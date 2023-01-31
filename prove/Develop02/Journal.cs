using System;

class Journal
{

    // ATRIBUTES
    public string[] _prompts= {"What is the most meaningful even of this day?\n","How could you help or influence someone else?\n",
        "What did you learn today that could be important to record?\n","What way did you see God's hand during the day?\n",
        "What are you grateful for?\n"};


    public List <string> _entriesFromUser =  new List<string>();// DATE + PROMPT + ENTRY 


    //METODOS
    public void ShowPrompt(int randomNumber)
    {
        
        

        string randomPrompt = _prompts[randomNumber];


        Console.WriteLine(randomPrompt);
    }

    public void addEntry(string date, string prompt, string answer) {


        string entryFromUser = ($"Date: {date}. Prompt: {prompt}, {answer}");

        _entriesFromUser.Add(entryFromUser);
    }

    public void DisplayEntries()
    {
        foreach(string line in _entriesFromUser)
        {
            Console.WriteLine(line);
            Console.WriteLine();
        }
    }

}