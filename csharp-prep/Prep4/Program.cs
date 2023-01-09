using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        string input;
        int number = 1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            input = Console.ReadLine();
            number = int.Parse(input);
            numbers.Add(number);
            numbers.Remove(0);
        }
        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

    }
}