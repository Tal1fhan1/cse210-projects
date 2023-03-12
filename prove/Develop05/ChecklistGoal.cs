public class ChecklistGoal: Goal
{
    private bool _checklistComplete;
    private int _timesToAccomplish;
    private int _bonusPoints;
    private int _progress;

    public ChecklistGoal()
    {
    }
    public ChecklistGoal(int totalScore, string goalName, string goalDescription, int pointsAssociated, List<string> listOfGoals, List<string> loadedLines, List<string> formattedList, bool checklistComplete, int timesToAccomplish, int bonusPoints, int progress): base(totalScore, goalName, goalDescription, pointsAssociated, listOfGoals, loadedLines, formattedList)
    {
        _checklistComplete = checklistComplete;
        _timesToAccomplish = timesToAccomplish;
        _bonusPoints = bonusPoints;
        _progress = progress;
    }

    public bool GetChecklistComplete()
    {
        return _checklistComplete;
    }
    public void SetChecklistComplete(bool checklistComplete)
    {
        _checklistComplete = checklistComplete;
    }
    public int GetTimesToAccomplish()
    {
        return _timesToAccomplish;
    }
    public void SetTimesToAccomplish(int timesToAccomplish)
    {
        _timesToAccomplish = timesToAccomplish;
    }
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public void SetBonusPoints(int bonusPoints)
    {
        _bonusPoints = bonusPoints;
    }
    public int GetProgress()
    {
        return _progress;
    }
    public void SetProgress(int progress)
    {
        _progress = progress;
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
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string timesToAccomplish = Console.ReadLine();
        SetTimesToAccomplish(int.Parse(timesToAccomplish));
        Console.Write("What is the bonus for accomplishing it that many times? ");
        string bonusPoints = Console.ReadLine();
        SetBonusPoints(int.Parse(bonusPoints));
        string newGoal = $"ChecklistGoal: {GetGoalName()}, {GetGoalDescription()}, {GetPointsAssociated()}, {GetBonusPoints()}, {GetProgress()}, {GetTimesToAccomplish()}, {_checklistComplete}";
        string listFormat = $"{GetGoalName()} ({GetGoalDescription()}) -- Currently completed: {GetProgress()}/{GetTimesToAccomplish()}";
        GetListOfGoals().Add(newGoal);
        GetFormattedList().Add(listFormat);
    }
    public override void RecordEvent()
    {
        _progress ++;
        if(_progress == _timesToAccomplish)
        {
            _checklistComplete = true;
        }
        SetTotalScore(GetTotalScore() + GetPointsAssociated() + GetBonusPoints()); 
        Console.WriteLine($"Congratulations! You have earned {GetPointsAssociated()} points!\nYou now have {GetTotalScore()} points.");    
    }

}