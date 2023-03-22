public class Comment
{
    public string _name;
    public string _text;

    public Comment()
    {
    }

    public string FullComment()
    {
        return "    " + _name + ": " + _text;
    }
}