using System;

public class Scripture
{
    //ATTRIBUTES
    private string _reference;
    public List<String> _words = new List<String>();

    
    //CONSTRUCTORS
    public Scripture() //_reference = "Proverbs 3:5-6";
    {
        string scripture = "Trust the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        _words = scripture.Split(' ').ToList();
    }


    public Scripture(string scripture)
    {
        _words = scripture.Split(' ').ToList();
    }


    

    // Methods
    public void GetScripture() // Display Scripture to the screen
    { 
        foreach(string word in _words)
        {
            Console.Write(word);
            Console.Write(" ");
        }
    
    }

}