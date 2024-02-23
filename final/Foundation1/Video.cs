public class Video
{
    private string _title;
    private string _author;
    private int _lengthSeconds;

    private List<Comment> _comments;

    public Video(string title, string author, int lengthSeconds, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
        _comments = comments;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine("______________________________________________________");
        Console.WriteLine("");
        Console.WriteLine($"\"{_title}\" - By: {_author}");
        Console.WriteLine($"Length: {SecondsToMinutes()} | {CountComments()} Comments");
        Console.WriteLine("");
        Console.WriteLine("");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine("______________________________________________________");
    }
    public int CountComments()
    {
        return _comments.Count;
    }

    public string SecondsToMinutes()
    {
        int minutes = _lengthSeconds / 60;
        int extraSeconds = _lengthSeconds - (minutes * 60);
        string VideoTime = $"{minutes}:{extraSeconds}";
        return VideoTime;
    }
}