using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();

        int grade = int.Parse(percentage);

        if (grade >= 90)
        {
            string symbol = "A";
            Console.WriteLine($"Your letter grade is {symbol}");
        }
        else if (grade >= 80)
        {
            string symbol = "B";
            Console.WriteLine($"Your letter grade is {symbol}");
        }
        else if (grade >= 70)
        {
            string symbol = "C";
            Console.WriteLine($"Your letter grade is {symbol}");
        }
        else if (grade > 60)
        {
            string symbol = "D";
            Console.WriteLine($"Your letter grade is {symbol}");
        }
        else
        {
            string symbol = "F";
            Console.WriteLine($"Your letter grade is {symbol}");
        }

        if (grade > 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Unfortunately you failed the class. Don't give up though! Remember that the road to success is paved with failure. You will succeed next time around.");
        }
    }
}