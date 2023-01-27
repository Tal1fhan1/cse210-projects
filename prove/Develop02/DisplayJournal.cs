public class DisplayJournal
{
    public List<string> _previousEntries = new List<string>();

    public DisplayJournal()
    {
    }

    public void Display()
    {
        foreach(string entry in _previousEntries)
        {
            Console.WriteLine(entry);
            Console.WriteLine("");
        }
    }
}
