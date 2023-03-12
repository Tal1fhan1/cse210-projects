using System.Timers;
public class ListingActivity: Activity
{
    private List<string> _goodThings = new List<string>();
    private List<string> _prompts = new List<string>();
    private List<int> _usedPromptIndexes = new List<int>();
    private string _randomPrompt;
    private string _item;
    private static DateTime _endTime;

    public static System.Timers.Timer _aTmr = new System.Timers.Timer(1000);
    
    public ListingActivity()
    {
    }
    public ListingActivity(string startMessage, string endMessage, string activityDescription, int activityDuration, List<string> spinnerStrings, List<string> goodThings, List<string> prompts, List<int> usedPromptIndexes, string randomPrompt, System.Timers.Timer aTmr): base(startMessage, endMessage, activityDescription, activityDuration, spinnerStrings)
    {
        _goodThings = goodThings;
        _randomPrompt = randomPrompt;
        _prompts = prompts;
        _usedPromptIndexes = usedPromptIndexes;

        _aTmr = aTmr;
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
    public DateTime GetEndTime()
    {
        return _endTime;
    }
    public void SetEndTime(DateTime endTime)
    {
        _endTime = endTime;
    }
    public System.Timers.Timer GetTimer()
    {
        return _aTmr;
    }
    public void SetTimer(System.Timers.Timer aTmr)
    {
        _aTmr = aTmr;
    }
    public void ATmr_Elapsed(object sender, ElapsedEventArgs e)
    { 
        
        if(_aTmr.AutoReset==false)
        {
            return;
        }
        DateTime currentTime = DateTime.Now;
        if (currentTime >= GetEndTime())
        {
            _item = "1";
            
            Console.WriteLine(_item);
            _aTmr.Stop();
            _aTmr.Enabled = false;
            _aTmr.AutoReset = false;
            Console.WriteLine();
            Console.WriteLine($"You have listed {_goodThings.Count} items!");
            Console.WriteLine();
            DisplayEndMessage("Listing Activity");
            Console.WriteLine();
            Console.Write("Please press enter to return to the menu ");   
        }     
    }
    
    public void RunListingActivity()
    {
        DisplayStartMessage("Listing Activity");
        Console.Clear();

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
        SetEndTime(endTime);
        _aTmr.Start();
        _aTmr.Enabled = true;
        _aTmr.AutoReset = true;
        _aTmr.Elapsed += ATmr_Elapsed; 

        while(DateTime.Now < _endTime)
        {   
            Console.Write(">");
            DateTime currentTime = DateTime.Now;
            _item = Console.ReadLine();
            if(_item != "")
            {
                _goodThings.Add(_item);
            }
                            
        }
        
    }
}