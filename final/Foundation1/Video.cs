public class Video
{
    // List<string> videos = new List<string>();
    public string _title;
    public string _author;
    public int _length;
    public List<string> _comments = new List<string>();
    

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void GetVideoInfo()
    {
        Console.WriteLine(_title);
        Console.WriteLine($"By {_author} ({_length} seconds).");
    }
    
    public void AddComment( string name, string comment)
    {
        string commentFormat = $"- {name}: {comment}";
        _comments.Add(commentFormat);
    }

    public void GetCommentsNumber()
    {
        int commentsNumber = _comments.Count();
        Console.WriteLine($"There are {commentsNumber} Comments:");
    }

    public void GetCommentsList()
    {
        foreach (string comment in _comments)
        {
            Console.WriteLine(comment);        }
    }
}