public class Load
{
    public string _filename = "";

    public List<string> _loadedLines = new List<string>();

    public Load()
    {
    }

    public void LoadFile()
    {
       Console.WriteLine("What is the file name?");
       _filename = Console.ReadLine();
       string[] lines = System.IO.File.ReadAllLines(_filename);
       Console.WriteLine("");
        
        foreach(string line in lines)
        {
            _loadedLines.Add(line);
        }
    }
    public void DisplayLoadedFile()
    {
        foreach(string line in _loadedLines)
        {
            Console.WriteLine(line);
        }
    }
}