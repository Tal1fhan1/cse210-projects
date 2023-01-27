using System;

class Program
{
    //My program exceeds the core requirements because it allows the user to rate their day on a scale of 1-10 based on enjoyment. 
    //It then stores that into a list, calculates their average for each week.
    static void Main(string[] args)
    {
        int choice = 0;
        NewEntry entry = new NewEntry();
        entry._dates = new List<string>();
        entry._ratings = new List<int>();
        
        DisplayJournal display = new DisplayJournal();
        display._previousEntries = new List<string>();
        
        Load load = new Load();
        load._loadedLines = new List<string>();

        Console.WriteLine(""); 
            
        while (choice != 5)
        {

            Console.Write("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");
            string answer = Console.ReadLine();
            Console.WriteLine("");

            if (answer == "1")
            {
                choice = 1;
                entry.RandomPrompt();
                entry.Rating();
                entry.OrganizedEntry();
                display._previousEntries.Add(entry._organize);
            }
            if (answer == "2")
            {
                choice = 2;
                if (display._previousEntries.Contains("Date") == false)
                {
                    load.DisplayLoadedFile();
                }                
                display.Display();
            }
            if (answer == "3")
            {
                choice = 3;
                load.LoadFile();
            }
            if (answer == "4")
            {
                choice = 3;
                Save save = new Save();
                save.SaveToFile(load._loadedLines, display._previousEntries);
            }
            if (answer == "5")
            {
                choice = 5;
            }
        }
    }
}