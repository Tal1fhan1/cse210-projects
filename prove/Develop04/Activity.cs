public class Activity
{
    private string _startMessage = "Welcome to the";
    private string _endMessage = "Well Done!";
    private string _activityDescription;
    private int _activityDuration;
    private List<string> _spinnerStrings = new List<string>();

    public Activity()
    {
    }

    public Activity(string startMessage, string endMessage, string activityDescription, int activityDuration, List<string> spinnerStrings)
    {
        _startMessage = startMessage;
        _endMessage = endMessage;
        _activityDescription = activityDescription;
        _activityDuration = activityDuration;
        _spinnerStrings = spinnerStrings;
    }

    public string GetStartMessage()
    {
        return _startMessage;
    }
    public void SetStartMessage(string startMessage)
    {
        _startMessage = startMessage;
    }
    public string GetEndMessage()
    {
        return _endMessage;
    }
    public void SetEndMessage(string endMessage)
    {
        _endMessage = endMessage;
    }
    public string GetActivityDescription()
    {
        return _activityDescription;
    }
    public void SetActivityDescription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }
    public int GetActivityDuration()
    {
        return _activityDuration;
    }
    public void SetActivityDuration(int activityDuration)
    {
        _activityDuration = activityDuration;
    }
    public List<string> GetSpinnerStrings()
    {
        return _spinnerStrings;
    }
    public void SetSpinnerStrings(List<string> spinnerStrings)
    {
        _spinnerStrings = spinnerStrings;
    }

    public void DisplayStartMessage(string activityName)
    {
        Console.Clear();
        Console.WriteLine($"{_startMessage} {activityName}."); 
        Console.WriteLine();
        DisplayActivityDescription();
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        string duration = Console.ReadLine();
        SetActivityDuration(int.Parse(duration));
    }
    public void DisplayActivityDescription()
    {
        Console.WriteLine(_activityDescription);
    }
    public void PauseDuringSpinner(int animationRunTime)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(animationRunTime);

        int i = 0;

        while(DateTime.Now < endTime)
        {
            string s = _spinnerStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if(i >= _spinnerStrings.Count)
            {
                i = 0;
            }
        }

    }
    public void PauseDuringCountdown()
    {
        for(int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
    public void DisplayEndMessage(string activityName)
    {
        Console.WriteLine(_endMessage);
        PauseDuringSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_activityDuration} seconds of the {activityName}.");
        PauseDuringSpinner(5);
        Console.Clear();
    }
}