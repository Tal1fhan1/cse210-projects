using System;

class Program
{
    //My program exceeds the core requirements because I have added the a system that 
    //allows the user to level up after accumulating a certain number of points for Eternal Goals.

    static void Main(string[] args)
    {
        Goal goal1 = new Goal();
        goal1.GetListOfGoals();
        goal1.GetLoadedLines();
        goal1.GetFormattedList();
        goal1.GetTotalScore();

        EternalGoal goal2 = new EternalGoal();
        goal2.GetListOfLevels();
        goal2.GetListOfLevels().Add("Level 1: Child Of God");
        goal2.GetListOfLevels().Add("Level 2: Peculiar Person");
        goal2.GetListOfLevels().Add("Level 3: Saint");
        goal2.GetListOfLevels().Add("Level 4: Missionary");
        goal2.GetListOfLevels().Add("Level 5: Consecrated");
        goal2.GetListOfLevels().Add("Level 6: Meek And Lowly");
        goal2.GetListOfLevels().Add("Level 7: Good Samaritan");
        goal2.GetListOfLevels().Add("Level 8: Salt Of The Earth");
        goal2.GetListOfLevels().Add("Level 9: Peacemaker");
        goal2.GetListOfLevels().Add("Level 10: Disciple of Jesus Christ");

        SimpleGoal goal3 = new SimpleGoal();
        goal3.GetGoalAchieved();

        ChecklistGoal goal4 = new ChecklistGoal();
        goal4.GetChecklistComplete();

        List<string> loadedlines = new List<string>();

        int choice = 0;
        string checkbox = "[ ]";

        while (choice != 6)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {goal1.GetTotalScore()} points");
            Console.WriteLine();
            Console.Write("Menu Options:\n    1. Create New Goal\n    2. List Goals\n    3. Save Goals\n    4. Load Goals\n    5. Record Event\n    6. Quit\nSelect a choice from the menu: ");
            string answer = Console.ReadLine();
            Console.WriteLine();

            if (answer == "1")
            {
                goal1.CreateNewGoal();
                string type = Console.ReadLine();
                if(type == "1")
                {
                    SimpleGoal sGoal = new SimpleGoal(goal1.GetTotalScore(), "", "", 0, goal1.GetListOfGoals(), goal1.GetLoadedLines(), goal1.GetFormattedList(), false);
                    sGoal.CreateNewGoal();
                }
                if(type == "2")
                {
                    EternalGoal eGoal = new EternalGoal(goal1.GetTotalScore(), "", "", 0, goal1.GetListOfGoals(), goal1.GetLoadedLines(), goal1.GetFormattedList(), 0, "", goal2.GetListOfLevels());
                    eGoal.CreateNewGoal();
                }
                if (type == "3")
                {
                    ChecklistGoal cGoal = new ChecklistGoal(goal1.GetTotalScore(), "", "", 0, goal1.GetListOfGoals(), goal1.GetLoadedLines(), goal1.GetFormattedList(), false, 0, 0, 0);
                    cGoal.CreateNewGoal();
                }
            }
            if (answer == "2")
            {
                Console.WriteLine("The goals are:");
                int number = 1;
                foreach (string goal in goal1.GetListOfGoals())
                {
                    if(goal.Contains("True") == true)
                    {
                        checkbox = "[X]";
                    }
                    else if(goal.Contains("True") == false)
                    {
                        checkbox = "[ ]";
                    }
                    Console.WriteLine($"{number}. {checkbox} {goal1.GetFormattedList()[number - 1]}");
                    number++;
                }
                
            }
            if (answer == "3")
            {
                Console.WriteLine("What is the file name?");
                string filename = Console.ReadLine();
                Console.WriteLine("");

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach(string goal in goal1.GetListOfGoals())
                    {
                        outputFile.WriteLine($"{goal}");
                    }
                    outputFile.WriteLine("");
                    outputFile.WriteLine($"You have {goal1.GetTotalScore()} points in total.");
                } 
            }
            if (answer == "4")
            {
                Console.WriteLine("What is the file name?");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);
                Console.WriteLine("");
                    
                foreach(string line in lines)
                {
                    goal1.GetLoadedLines().Add(line);
                }
                string [] splitLine = goal1.GetLoadedLines().Last().Split(" ");
                goal1.SetTotalScore(int.Parse(splitLine[2]));
                int number = 1;
                goal1.GetFormattedList().Clear();
                goal1.GetListOfGoals().Clear();
                    foreach (string line in goal1.GetLoadedLines())
                    {
                        if(line == "")
                        {
                            break;
                        }
                        goal1.GetListOfGoals().Add(line);
                    }
                    
                    foreach (string goal in goal1.GetListOfGoals())
                    {   
                        
                        string[] words = goal1.GetListOfGoals()[number - 1].Split(", ");
                        string[] split = words[0].Split(": ");
                        string formatted;
                        if(goal1.GetListOfGoals()[number - 1].Contains("ChecklistGoal"))
                        {
                            formatted = $"{split[1]} ({words[1]}) -- Currently completed: {words[4]}/{words[5]}";
                        }
                        else
                        {
                            formatted = $"{split[1]} ({words[1]})";
                        }
                        goal1.GetFormattedList().Add(formatted);
                        number++;  
                    }            
            }
            if (answer == "5")
            {
                Console.WriteLine("The goals are:");
                Console.WriteLine();
                int number = 1;
                foreach (string goal in goal1.GetListOfGoals())
                {
                    if(goal.Contains("True") == true)
                    {
                        checkbox = "[X]";
                    }
                    else if(goal.Contains("True") == false)
                    {
                        checkbox = "[ ]";
                    }
                    Console.WriteLine($" {number}. {checkbox} {goal1.GetFormattedList()[number - 1]}");
                    number++;
                }
                Console.WriteLine();
                Console.Write("Which goal did you accomplish? ");
                string accomplishment = Console.ReadLine();
                int goalIndex = int.Parse(accomplishment) - 1;
                string[] words = goal1.GetListOfGoals()[goalIndex].Split(", ");
                string updatedGoal;
                if(goal1.GetListOfGoals()[goalIndex].Contains("SimpleGoal"))
                {
                    goal3.SetPointsAssociated(int.Parse(words[2]));
                    goal3.RecordEvent();
                    goal1.SetTotalScore(goal1.GetTotalScore() + goal3.GetPointsAssociated());
                    words[3] = "True";
                    updatedGoal = $"{words[0]}, {words[1]}, {words[2]}, {words[3]}";
                    goal1.GetListOfGoals().RemoveAt(goalIndex);
                    goal1.GetListOfGoals().Insert(goalIndex, updatedGoal);
                }
                else if(goal1.GetListOfGoals()[goalIndex].Contains("EternalGoal"))
                {
                    goal2.SetPointsAssociated(int.Parse(words[2]));
                    goal2.RecordEvent();
                    goal1.SetTotalScore(goal1.GetTotalScore() + goal2.GetPointsAssociated());
                } 
                else if(goal1.GetListOfGoals()[goalIndex].Contains("ChecklistGoal"))
                {
                    goal4.SetPointsAssociated(int.Parse(words[2]));
                    goal4.SetTotalScore(goal1.GetTotalScore());
                    goal4.SetBonusPoints(int.Parse(words[3]));
                    goal4.RecordEvent();
                    goal1.SetTotalScore(goal1.GetTotalScore() + goal4.GetPointsAssociated());
                    words[4] = $"{int.Parse(words[4]) + 1}";
                    updatedGoal = $"{words[0]}, {words[1]}, {words[2]}, {words[3]}, {words[4]}, {words[5]}, {words[6]}";
                    goal1.GetListOfGoals().RemoveAt(goalIndex);
                    goal1.GetListOfGoals().Insert(goalIndex, updatedGoal);
                    string[] split = words[0].Split(": ");
                    updatedGoal = $"{split[1]}, ({words[1]}) -- Currently completed {words[4]}/{words[5]}";
                    goal1.GetFormattedList().RemoveAt(goalIndex);
                    goal1.GetFormattedList().Insert(goalIndex, updatedGoal);
                    if(words[4] == words[5])
                    {
                        words[6] = "True";
                        goal1.SetTotalScore(goal1.GetTotalScore() + goal4.GetBonusPoints());
                        updatedGoal = $"{words[0]}, {words[1]}, {words[2]}, {words[3]}, {words[4]}, {words[5]}, {words[6]}";
                        goal1.GetListOfGoals().RemoveAt(goalIndex);
                        goal1.GetListOfGoals().Insert(goalIndex, updatedGoal);
                    }
                }                 
            }
            if (answer == "6")
            {
                choice = 6;
            }
        }
    }
}