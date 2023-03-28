public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected string _checkBox;


    public Goal(string name, string description, string checkBox)
    {
        _name = name;
        _description = description;
        _checkBox = checkBox;
    }

    public string GetGoalName()
    {
        return _name;
    }

    public string GetGoalDescription()
    {
        return _description;
    }

    
    
    public abstract void GetGoalInformation(int index);
}