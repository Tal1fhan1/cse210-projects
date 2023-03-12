public class Goal
{
    private int _totalScore;
    private string _goalName;
    private string _goalDescription;
    private int _pointsAssociated;
    private List<string> _listOfGoals = new List<string>();
    private List<string> _loadedLines = new List<string>();
    private List<string> _formattedList = new List<string>();

    public Goal()
    {
    }
    public Goal(int totalScore, string goalName, string goalDescription, int pointsAssociated, List<string> listOfGoals, List<string> loadedLines, List<string> formattedList)
    {
        _totalScore = totalScore;
        _goalName = goalName;
        _goalDescription = goalDescription;
        _pointsAssociated = pointsAssociated;
        _listOfGoals = listOfGoals;
        _loadedLines = loadedLines;
        _formattedList = formattedList;
    }

    public int GetTotalScore()
    {
        return _totalScore;
    }
    public void SetTotalScore(int totalScore)
    {
        _totalScore = totalScore;
    }
    public string GetGoalName()
    {
        return _goalName;
    }
    public void SetGoalName(string goalName)
    {
        _goalName = goalName;
    }
    public string GetGoalDescription()
    {
        return _goalDescription;
    }
    public void SetGoalDescription(string goalDescription)
    {
        _goalDescription = goalDescription;
    }
    public int GetPointsAssociated()
    {
        return _pointsAssociated;
    }
    public void SetPointsAssociated(int pointsAssociated)
    {
        _pointsAssociated = pointsAssociated;
    }
    public List<string> GetListOfGoals()
    {
        return _listOfGoals;
    }
    public void SetListOfGoals(List<string> listOfGoals)
    {
        _listOfGoals = listOfGoals;
    }
    public List<string> GetLoadedLines()
    {
        return _loadedLines;
    }
    public void SetLoadedLines(List<string> loadedLines)
    {
        _loadedLines = loadedLines;
    }
    public List<string> GetFormattedList()
    {
        return _formattedList;
    }
    public void SetFormattedList(List<string> formattedList)
    {
        _formattedList = formattedList;
    }
    public virtual void CreateNewGoal()
    {
        Console.Write("The types of Goals are:\n    1. Simple Goal\n    2. Eternal Goal\n    3. Checklist Goal\nWhich type of goal would you like to create? ");
    }
    public virtual void RecordEvent()
    {
        SetTotalScore(_totalScore + _pointsAssociated); 
        Console.WriteLine($"Congratulations! You have earned {_pointsAssociated} points!\nYou now have {_totalScore} points.");    
    }
}