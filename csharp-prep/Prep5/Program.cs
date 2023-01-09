using System;

class Program
{
    static void Main(string[] args)
    {
      DisplayWelcome();
      string userName = PromptUserName();
      int userNumber = PromptUserNumber();
      int square = SquareNumber(userNumber);
      DisplayResult(square, userName);
    }
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int userNumber = int.Parse(input);
        return userNumber;
    }
    static int SquareNumber(int userNumber)
    {
        int square = userNumber * userNumber;
        return square;
    }
    static void DisplayResult(int square, string userName)
    {
        Console.WriteLine($"{userName}, the square of your favorite number is {square}");
    }
}