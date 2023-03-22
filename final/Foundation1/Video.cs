public class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    public List<string> _comments = new List<string>();

    public Video()
    {
    }

    public string FullVideo()
    {
        int lengthInMinutes = _lengthInSeconds / 60;
        return $"{_title} by {_author} - {lengthInMinutes} min";
    }
    public int NumberOfComments()
    {
        return _comments.Count();
    }
}