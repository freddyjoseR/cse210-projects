using System;

public class Simple : Goal
{
    private int _points;

    public Simple(string name, string description, int points) : base (name, description)
    {
        _points = points;
    }
}