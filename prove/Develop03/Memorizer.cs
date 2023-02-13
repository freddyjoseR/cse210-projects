using System;

public class Memorizer
{
    private string _replace;

    public List<String> _replacedWords = new List<String>();

    // Behaviors 
    public void ReplaceWords(Scripture scripture)
    {
        Random randomObject = new Random();
        
        
        for (int i = 0; i < 3; i++)
        {
            int randomIndex = randomObject.Next(0, scripture._words.Count());
            if (scripture._words[randomIndex] != "____")
            {
                _replacedWords.Add(scripture._words[randomIndex]);
                scripture._words[randomIndex] = "____";
            }
        }

    }

    // This works to display the list of hidden words to verify the words are all hidden
    public void DisplayList()
    {
        Console.WriteLine("List of hidden words:");
        int numberList = 0;
        foreach(string replacedWord in _replacedWords)
        {
            numberList += 1;
            Console.WriteLine($"{numberList} - {replacedWord}");
        }
    }

}
