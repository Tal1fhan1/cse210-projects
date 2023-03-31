using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> activities = new List<string>();

        Running activity1 = new Running(4.8, "30 Mar 2023", 30);
        string running = activity1.ToString();
        activities.Add(running);

        Cycling activity2 = new Cycling(25, "14 Feb 2023", 15);
        string cycling = activity2.ToString();
        activities.Add(cycling);

        Swimming activity3 = new Swimming(20, "03 Jan 2023", 7);
        string swimming = activity3.ToString();
        activities.Add(swimming);

        Console.WriteLine();
        
        foreach(string activity in activities)
        {
            if(activity == "Running")
            {
                Console.WriteLine(activity1.GetSummary(activity, activity1.GetDistance(), activity1.CalculateSpeed(), activity1.CalculatePace()));
                Console.WriteLine();
            }
            else if(activity == "Cycling")
            {
                Console.WriteLine(activity2.GetSummary(activity, activity2.CalculateDistance(), activity2.GetSpeed(), activity2.CalculatePace()));
                Console.WriteLine();
            }
            else if(activity == "Swimming")
            {
                Console.WriteLine(activity3.GetSummary(activity, activity3.CalculateDistance(), activity3.CalculateSpeed(), activity3.CalculatePace()));
                Console.WriteLine();
            }
        }
    }
}