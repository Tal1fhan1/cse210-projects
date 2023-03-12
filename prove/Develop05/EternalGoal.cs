public class EternalGoal: Goal
{
    private int _pointsAccumulated;
    private string _currentLevel;
    private List<string> _listOfLevels = new List<string>();

    public EternalGoal()
    {
    }
    public EternalGoal(int totalScore, string goalName, string goalDescription, int pointsAssociated, List<string> listOfGoals, List<string> loadedLines, List<string> formattedList, int pointsAccumulated, string currentLevel, List<string> listOfLevels): base(totalScore, goalName, goalDescription, pointsAssociated, listOfGoals, loadedLines, formattedList)
    {
        _pointsAccumulated = pointsAccumulated;
        _currentLevel = currentLevel;
        _listOfLevels = listOfLevels;
    }

    public int GetPointsAccumulated()
    {
        return _pointsAccumulated;
    }
    public void SetPointsAccumulated(int pointsAccumulated)
    {
        _pointsAccumulated = pointsAccumulated;
    }
    public string GetCurrentLevel()
    {
        return _currentLevel;
    }
    public void SetCurrentLevel(string currentLevel)
    {
        _currentLevel = currentLevel;
    }
    public List<string> GetListOfLevels()
    {
        return _listOfLevels;
    }
    public void SetListOfLevels(List<string> listOfLevels)
    {
        _listOfLevels = listOfLevels;
    }

    public override void CreateNewGoal()
    {
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        SetGoalName(goalName);
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        SetGoalDescription(goalDescription);
        Console.Write("What is the amount of points associated with this goal? ");
        string pointsAssociated = Console.ReadLine();
        SetPointsAssociated(int.Parse(pointsAssociated));
        string newGoal = $"EternalGoal: {GetGoalName()}, {GetGoalDescription()}, {GetPointsAssociated()}";
        string listFormat = $"{GetGoalName()} ({GetGoalDescription()})";
        GetListOfGoals().Add(newGoal);
        GetFormattedList().Add(listFormat);
    }
    public override void RecordEvent()
    {
        
        SetTotalScore(GetTotalScore() + GetPointsAssociated());
        SetPointsAccumulated(_pointsAccumulated + GetPointsAssociated());
        if(_pointsAccumulated <= 1000)
        {
            _currentLevel = _listOfLevels[0];
        }
        else if(_pointsAccumulated <= 2000)
        {
            _currentLevel = _listOfLevels[1];
        }
        else if(_pointsAccumulated <= 3000)
        {
            _currentLevel = _listOfLevels[2];
        }
        else if(_pointsAccumulated <= 4000)
        {
            _currentLevel = _listOfLevels[3];
        }
        else if(_pointsAccumulated <= 5000)
        {
            _currentLevel = _listOfLevels[4];
        }
        else if(_pointsAccumulated <= 6000)
        {
            _currentLevel = _listOfLevels[5];
        }
        else if(_pointsAccumulated <= 7000)
        {
            _currentLevel = _listOfLevels[6];
        }
        else if(_pointsAccumulated <= 8000)
        {
            _currentLevel = _listOfLevels[7];
        }
        else if(_pointsAccumulated <= 9000)
        {
            _currentLevel = _listOfLevels[8];
        }
        else if(_pointsAccumulated <= 10000)
        {
            _currentLevel = _listOfLevels[9];
        }
        Console.WriteLine($"Your current level is {_currentLevel}");
        Console.WriteLine($"Congratulations! You have earned {GetPointsAssociated()} points!\nYou now have {GetTotalScore()} points.");    
    }

}