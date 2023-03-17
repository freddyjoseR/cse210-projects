public class Goal
{
    private string _name;
    private string _description;
    

    public Goal(string name, string descripcion)
    {
        _name = name;
        _description = descripcion;
    }

    public void MakeList()
    {

    }

    public string GetName()
    {
        return _name;
    }

    
    public string GetDescription()
    {
        return _description;
    }


    public void SetGoalInfo(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayGoal()
    {
        Console.WriteLine($" [ ] {_name} ({_description})");
    }

}