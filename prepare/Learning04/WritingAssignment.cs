using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        //In case we don't want to use protected to 
        //_studentName in Assignment Class use this line of code:
        
        // string studentName = GetStudentName();

        return $"{_title} by {_studentName}";
    }
}