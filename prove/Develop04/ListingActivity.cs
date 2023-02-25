public class ListingActivity: Activity
{
    private List<string> _goodThings = new List<string>();
    private List<string> _prompts = new List<string>();
    private List<int> _usedPromptIndexes = new List<int>();
    private string _randomPrompt;
    
    public ListingActivity()
    {
    }
    public ListingActivity(string startMessage, string endMessage, string activityDescription, int activityDuration, List<string> spinnerStrings, List<string> goodThings, string randomPrompt): base(startMessage, endMessage, activityDescription, activityDuration, spinnerStrings)
    {
        _goodThings = goodThings;
        _randomPrompt = randomPrompt;
    }

    public List<string> GetGoodThings()
    {
        return _goodThings;
    }
    public void SetGoodThings(List<string> goodThings)
    {
        _goodThings = goodThings;
    }
    public List<string> GetPrompts()
    {
        return _prompts;
    }
    public void SetPrompts(List<string> prompts)
    {
        _prompts = prompts;
    }
    public List<int> GetUsedPromptIndexes()
    {
        return _usedPromptIndexes;
    }
    public void SetUsedPromptIndexes(List<int> usedIndexes)
    {
        _usedPromptIndexes = usedIndexes;
    }
    public string GetRandomPrompt()
    {
        return _randomPrompt;
    }
    public void SetRandomPrompt(string randomPrompt)
    {
        _randomPrompt = randomPrompt;
    }

    public void RunListingActivity()
    {
        Console.WriteLine("Get ready...");
        PauseDuringSpinner(5);
        Console.WriteLine();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();

        Random randomNumbergenerator1 = new Random();
        int index = randomNumbergenerator1.Next(_prompts.Count);
        _randomPrompt = _prompts[index];
        if (_usedPromptIndexes.Contains(index) == false)
        {
            _usedPromptIndexes.Add(index);
        }
        else
        {
            while (_usedPromptIndexes.Contains(index) == true)
            {
                index = randomNumbergenerator1.Next(_prompts.Count());
                _randomPrompt = _prompts[index];
            }
            _usedPromptIndexes.Add(index);
        }
        if(_usedPromptIndexes.Count == _prompts.Count)
        {
            _usedPromptIndexes.Clear();
        }

        Console.WriteLine($"-- {_randomPrompt} --");
        Console.WriteLine();

        Console.Write("You may begin in: ");
        PauseDuringCountdown();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetActivityDuration());

        while(DateTime.Now < endTime)
        {
            Console.Write(">");
            string item = Console.ReadLine();
            _goodThings.Add(item);
        }
        Console.WriteLine($"You have listed {_goodThings.Count} items!");
        Console.WriteLine();
        DisplayEndMessage("Listing Activity");
    }
}