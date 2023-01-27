public class NewEntry
{
    public List<string> _prompts = new List<string>();
    public string _randomPrompt = "";
    public string _entry = "";
    public string _date = "";
    public List<string> _dates = new List<string>();
    public string _dateTime = "";
    public List<int> _ratings = new List<int>();
    public int _dailyRating = 0;
    public float _weeklyAverage = 0;
    public string _organize = "";

    public NewEntry()
    {
    }

    public void RandomPrompt()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What goals did I set and/or achieve today?");
        _prompts.Add("What is the funniest thing that happened to me today?");
        _prompts.Add("How did improve myself today compared to how I was yesterday?");
        
        Random randomNumbergenerator = new Random();
        int index = randomNumbergenerator.Next(8);
        _randomPrompt = _prompts[index];
        Console.WriteLine($"{_randomPrompt} ");
        Console.Write("> ");
        _entry = Console.ReadLine();
        Console.WriteLine("");
    }
    public void Rating()
    {
        DateTime dateTime = DateTime.Now;
        _dateTime = $"{dateTime}";
        DateOnly dateOnly = DateOnly.FromDateTime(dateTime);
        _date = $"{dateOnly}";
        if (_dates.Contains(_date) == false)
        {
            _dates.Add(_date);

            Console.Write("On a scale of 1-10, how much did you enjoy your day? ");
            _dailyRating = int.Parse(Console.ReadLine());
            _ratings.Add(_dailyRating);
            Console.WriteLine("");
        }
        DateOnly oneWeek = dateOnly.AddDays(-7);
        string weekBefore = $"{oneWeek}";
        if (_dates[0] == weekBefore)
        {
            double avg = _ratings.Average();
            _weeklyAverage = float.Parse($"{avg}");
            Console.WriteLine($"Your average daily rating for this week was {_weeklyAverage}/10");
            Console.WriteLine("");
            _ratings.Clear();
            _dates.Clear();
        }
    }
    public void OrganizedEntry()
    {
        _organize = $"Date: {_date} - Prompt: {_randomPrompt}\n{_entry} ";
        if (_dailyRating != 0)
        {
            _organize = $"Date: {_date} - Prompt: {_randomPrompt}\n{_entry} \nDaily Rating: {_dailyRating}/10";
        }
    }
}