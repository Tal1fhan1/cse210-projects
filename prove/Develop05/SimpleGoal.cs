public class SimpleGoal: Goal
{
    private bool _goalAchieved;

    public SimpleGoal() 
    {
    }
    public SimpleGoal(int totalScore, string goalName, string goalDescription, int pointsAssociated, List<string> listOfGoals, List<string> loadedLines, List<string> formattedList, bool goalAchieved): base(totalScore, goalName, goalDescription, pointsAssociated, listOfGoals, loadedLines, formattedList)
    {
        _goalAchieved = goalAchieved;
    }

    public bool GetGoalAchieved()
    {
        return _goalAchieved;
    }
    public void SetGoalAchieved(bool goalAchieved)
    {
        _goalAchieved = goalAchieved;
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
        string newGoal = $"SimpleGoal: {GetGoalName()}, {GetGoalDescription()}, {GetPointsAssociated()}, {GetGoalAchieved()}";
        string listFormat = $"{GetGoalName()} ({GetGoalDescription()})";
        GetListOfGoals().Add(newGoal);
        GetFormattedList().Add(listFormat);
    }
    public override void RecordEvent()
    {
        
        _goalAchieved = true;
        SetTotalScore(GetTotalScore() + GetPointsAssociated()); 
        Console.WriteLine($"Congratulations! You have earned {GetPointsAssociated()} points!\nYou now have {GetTotalScore()} points.");    
    }

}

