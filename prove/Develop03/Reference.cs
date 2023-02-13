using System;

public class Reference
{
    private string _reference;

    
    public Reference()
    {
        _reference = "Proverbs 3:15-16";
    }

    public Reference(string reference) 
    {
        _reference = reference;
    }


    public void DisplayReference()
    {
        Console.Write(_reference);
    }
}
