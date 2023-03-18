using System;

public class Checklist : Goal
{ 
    private int _points;
    private int _times;
    private int _bonusPoints = 0;

    private int _completedTimes;

    public Checklist(string name, string description,int points, int timesToBonus, int bonusPoints, string checkBox) : base (name, description, checkBox)
    {
        _points = points;
        _times = timesToBonus;
        _bonusPoints = bonusPoints;
    }

    public int GetPoints()
    {
        return _points;
    }

    public override void GetGoalInformation(int index)
    {
        Console.WriteLine($"{index}. {_checkBox} {_name} ({_description}) -- Currently completed: {_completedTimes}/{_times}");
    }
}