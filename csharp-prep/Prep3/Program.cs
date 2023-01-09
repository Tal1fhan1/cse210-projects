using System;

class Program
{
    static void Main(string[] args)
    {
        // Core Requirement 1:


        // Console.Write("What is the magic number? ");
        // string question = Console.ReadLine();
        // int magic = int.Parse(question);

        // Console.Write("What is your guess? ");
        // string guess = Console.ReadLine();
        // int number = int.Parse(guess);

        // if (magic > number)
        // {
        //     Console.WriteLine("Higher");
        // }
        // else if (magic < number)
        // {
        //     Console.WriteLine("Lower");
        // }
        // else
        // {
        //     Console.WriteLine("You guessed it!");
        // }


        // Core Requirement 2:


        //Random randomGeneator = new Random();
        // string answer = "";

        // Console.Write("What is the magic number? ");
        // string question = Console.ReadLine();
        // int magic = int.Parse(question);

        // while (answer != "You've guessed it!")
        // {
        //     Console.Write("What is your guess? ");
        //     string guess = Console.ReadLine();
        //     int number = int.Parse(guess);

        //     if (magic > number)
        //     {
        //         answer = "Higher";
        //         Console.WriteLine(answer);
        //     }
        //     else if (magic < number)
        //     {
        //         answer = "Lower";
        //         Console.WriteLine(answer);
        //     }
        //     else
        //     {
        //         answer = "You've guessed it!";
        //         Console.WriteLine(answer);
        //     }
        // }


        // Core Requirement 3:


        // Random randomGenerator = new Random();
        // string answer = "";

        // int magic = randomGenerator.Next(100);

        // while (answer != "You've guessed it!")
        // {
        //     Console.Write("What is your guess? ");
        //     string guess = Console.ReadLine();
        //     int number = int.Parse(guess);

        //     if (magic > number)
        //     {
        //         answer = "Higher";
        //         Console.WriteLine(answer);
        //     }
        //     else if (magic < number)
        //     {
        //         answer = "Lower";
        //         Console.WriteLine(answer);
        //     }
        //     else
        //     {
        //         answer = "You've guessed it!";
        //         Console.WriteLine(answer);
        //     }
        // }

        
        // Stretch Challenge 1:


        // Random randomGenerator = new Random();
        // string answer = "";
        // int attempt = 0;
        // int magic = randomGenerator.Next(100);

        // while (answer != "You've guessed it!")
        // {
        //     Console.Write("What is your guess? ");
        //     string guess = Console.ReadLine();
        //     int number = int.Parse(guess);

        //     if (magic > number)
        //     {
        //         answer = "Higher";
        //         Console.WriteLine(answer);
        //     }
        //     else if (magic < number)
        //     {
        //         answer = "Lower";
        //         Console.WriteLine(answer);
        //     }
        //     else
        //     {
        //         answer = "You've guessed it!";
        //         Console.WriteLine(answer);
        //     }
        //     attempt++;
        // }
        // Console.WriteLine($"It took you {attempt} attempts to guess the right number.");


        //Stretch Challenge 2:


        string playAgain = "yes";

        while (playAgain == "yes")
        {
            Random randomGenerator = new Random();
            string answer = "";
            int attempt = 0;
            int magic = randomGenerator.Next(100);


            while (answer != "You've guessed it!")
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                int number = int.Parse(guess);

                if (magic > number)
                {
                    answer = "Higher";
                    Console.WriteLine(answer);
                }
                else if (magic < number)
                {
                    answer = "Lower";
                    Console.WriteLine(answer);
                }
                else
                {
                    answer = "You've guessed it!";
                    Console.WriteLine(answer);
                }
                attempt++;
            }
            Console.WriteLine($"It took you {attempt} attempts to guess the right number.");
            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();
            if (playAgain == "yes")
            {
                answer = "";
            }
        }
    }
}