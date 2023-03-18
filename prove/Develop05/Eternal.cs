using System;

public class Eternal : Goal
{
    private int _points;
    
    public Eternal(string name, string description, int points, string checkBox) : base (name, description, checkBox)
    {
       _points = points;
    }


    public int GetPoints()
    {
        return _points;
    }

    public override void GetGoalInformation(int index)
    {
        Console.WriteLine($"{index}. {_checkBox} {_name} ({_description})");
    }
}