public class ReflectingActivity: Activity
{
    private string _randomPrompt;
    private string _randomQuestion;
    private List<string> _prompts = new List<string>();
    private List<int> _usedPromptIndexes = new List<int>();
    private List<string> _questions = new List<string>();
    private List<int> _usedQuestionIndexes = new List<int>();
    
    public ReflectingActivity()
    {
    }
    public ReflectingActivity(string startMessage, string endMessage, string activityDescription, int activityDuration, List<string> spinnerStrings, string randomPrompt, string randomQuestion): base(startMessage, endMessage, activityDescription, activityDuration, spinnerStrings)
    {
        _randomPrompt = randomPrompt;
        _randomQuestion = randomQuestion;
    }

    public string GetRandomPrompt()
    {
        return _randomPrompt;
    }
    public void SetRandomPrompt(string randomPrompt)
    {
        _randomPrompt = randomPrompt;
    }
    public string GetRandomQuestion()
    {
        return _randomQuestion;
    }
    public void SetPromptToBreatheOut(string randomQuestion)
    {
        _randomQuestion = randomQuestion;
    }
    public List<string> GetPrompts()
    {
        return _prompts;
    }
    public void SetPrompts(List<string> prompts)
    {
        _prompts = prompts;
    }
    public List<string> GetQuestions()
    {
        return _questions;
    }
    public void SetQuestions(List<string> questions)
    {
        _questions = questions;
    }
    public List<int> GetUsedQuestionIndexes()
    {
        return _usedQuestionIndexes;
    }
    public void SetUsedQuestionIndexes(List<int> usedIndexes)
    {
        _usedQuestionIndexes = usedIndexes;
    }
    public List<int> GetUsedPromptIndexes()
    {
        return _usedPromptIndexes;
    }
    public void SetUsedPromptIndexes(List<int> usedIndexes)
    {
        _usedPromptIndexes = usedIndexes;
    }

    public void RunReflectingActivity()
    {
        Console.WriteLine("Get ready...");
        PauseDuringSpinner(5);
        Console.WriteLine();

        Console.WriteLine("Consider the following prompt:");
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
        if(_usedPromptIndexes.Count == _prompts.Count)
        {
            _usedPromptIndexes.Clear();
        }
        }

        Console.WriteLine($"-- {_randomPrompt} --");
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now Ponder on each of the following questions as they relate to this experience");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        PauseDuringCountdown();
        Console.Clear();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetActivityDuration());

        while(DateTime.Now < endTime)
        {
            Random randomNumbergenerator2 = new Random();
            int index2 = randomNumbergenerator2.Next(_questions.Count);
            _randomQuestion = _questions[index2];
            if (_usedQuestionIndexes.Contains(index2) == false)
            {
                _usedQuestionIndexes.Add(index2);
            }
            else
            {
                while (_usedQuestionIndexes.Contains(index2) == true)
                {
                    index2 = randomNumbergenerator1.Next(_questions.Count());
                    _randomQuestion = _questions[index2];
                }
                _usedQuestionIndexes.Add(index2);
            if(_usedQuestionIndexes.Count == _questions.Count)
            {
                _usedQuestionIndexes.Clear();
            }
            }
            Console.Write($"> {_randomQuestion} ");           
            PauseDuringSpinner(10);
            Console.WriteLine();
        }
        Console.WriteLine();
        DisplayEndMessage("Reflecting Activity");
    }
}