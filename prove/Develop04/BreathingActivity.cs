public class BreathingActivity: Activity
{
    private string _promptToBreatheIn;
    private string _promptToBreatheOut;
    
    public BreathingActivity()
    {
    }
    public BreathingActivity(string startMessage, string endMessage, string activityDescription, int activityDuration, List<string> spinnerStrings, string promptToBreatheIn, string promptToBreatheOut): base(startMessage, endMessage, activityDescription, activityDuration, spinnerStrings)
    {
        _promptToBreatheIn = promptToBreatheIn;
        _promptToBreatheOut = promptToBreatheOut;
    }

    public string GetPromptToBreatheIn()
    {
        return _promptToBreatheIn;
    }
    public void SetPromptToBreatheIn(string promptToBreatheIn)
    {
        _promptToBreatheIn = promptToBreatheIn;
    }
    public string GetPromptToBreatheOut()
    {
        return _promptToBreatheOut;
    }
    public void SetPromptToBreatheOut(string promptToBreatheOut)
    {
        _promptToBreatheOut = promptToBreatheOut;
    }

    public void RunBreathingActivity()
    {
        Console.WriteLine("Get ready...");
        PauseDuringSpinner(5);
        Console.WriteLine();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetActivityDuration());

        while(DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            PauseDuringCountdown();
            Console.Write("Now breathe out...");
            PauseDuringCountdown();
            Console.WriteLine();
        }
        DisplayEndMessage("Breathing Activity");
    }
}