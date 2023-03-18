using System;

public class Simple : Goal
{
    private int _completionPoints;


    public Simple(string name, string description, int points, string checkBox) : base (name, description, checkBox)
    {
       _completionPoints = points;
    }

    public int GetPoints()
    {
        return _completionPoints;
    }

    public override void GetGoalInformation(int index)
    {
        Console.WriteLine($"{index}. {_checkBox} {_name} ({_description})");
    }
}