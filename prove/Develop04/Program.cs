using System;

class Program
{
    //My program exceeds the core requirements because I have made sure that no random prompts/questions 
    //are selected until they have all been used at least once in that session.

    static void Main(string[] args)
    {
        Activity activity = new Activity();
        activity.GetSpinnerStrings().Add("|");
        activity.GetSpinnerStrings().Add("\\");
        activity.GetSpinnerStrings().Add("—");
        activity.GetSpinnerStrings().Add("/");
        activity.GetSpinnerStrings().Add("|");
        activity.GetSpinnerStrings().Add("\\");
        activity.GetSpinnerStrings().Add("-");
        activity.GetSpinnerStrings().Add("/");

        ReflectingActivity reflection = new ReflectingActivity();
        reflection.GetPrompts().Add("Think of a time when you stood up for someone else.");
        reflection.GetPrompts().Add("Think of a time when you did something really difficult.");
        reflection.GetPrompts().Add("Think of a time when you helped someone in need.");
        reflection.GetPrompts().Add("Think of a time when you did something truly selfless.");
        reflection.GetQuestions().Add("Why was this experience meaningful to you?");
        reflection.GetQuestions().Add("Have you ever done anything like this before?");
        reflection.GetQuestions().Add("How did you get started?");
        reflection.GetQuestions().Add("How did you feel when it was complete?");
        reflection.GetQuestions().Add("What made this time different than other times when you were not as successful?");
        reflection.GetQuestions().Add("What is your favorite thing about this experience?");
        reflection.GetQuestions().Add("What could you learn from this experience that applies to other situations?");
        reflection.GetQuestions().Add("What did you learn about yourself through this experience?");
        reflection.GetQuestions().Add("How can you keep this experience in mind in the future?");
        reflection.GetUsedPromptIndexes();
        reflection.GetUsedQuestionIndexes();

        ListingActivity listing = new ListingActivity();
        listing.GetPrompts().Add("Who are people that you appreciate?");
        listing.GetPrompts().Add("What are personal strengths of yours?");
        listing.GetPrompts().Add("Who are people that you have helped this week?");
        listing.GetPrompts().Add("When have you felt the Holy Ghost this month?");
        listing.GetPrompts().Add("Who are some of your personal heroes?");
        listing.GetUsedPromptIndexes();


        string choice = "";

        while(choice != "4")
        {
            Console.Write("Menu Options:\n    1. Start breathing activity\n    2. Start reflecting activity\n    3. Start listing activity\n    4. Quit\nSelect a choice from the menu: ");
            choice = Console.ReadLine();
            if(choice == "1")
            {
                Console.Clear();
                BreathingActivity activity1 = new BreathingActivity();
                activity1.SetSpinnerStrings(activity.GetSpinnerStrings());
                activity1.SetActivityDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                activity1.DisplayStartMessage("Breathing Activity");
                Console.Clear();
                activity1.RunBreathingActivity();
            }
            if(choice == "2")
            {
                Console.Clear();
                ReflectingActivity reflection1 = new ReflectingActivity();
                reflection1.SetSpinnerStrings(activity.GetSpinnerStrings());
                reflection1.SetPrompts(reflection.GetPrompts());
                reflection1.SetQuestions(reflection.GetQuestions());
                reflection1.SetUsedPromptIndexes(reflection.GetUsedPromptIndexes());
                reflection1.SetUsedQuestionIndexes(reflection.GetUsedQuestionIndexes());
                reflection1.SetActivityDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflection1.DisplayStartMessage("Reflecting Activity");
                Console.Clear();
                reflection1.RunReflectingActivity();
            }
            if(choice == "3")
            {
                Console.Clear();
                ListingActivity listing1 = new ListingActivity();
                listing1.SetSpinnerStrings(activity.GetSpinnerStrings());
                listing1.SetPrompts(listing.GetPrompts());
                listing1.SetUsedPromptIndexes(listing.GetUsedPromptIndexes());
                listing1.SetActivityDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listing1.DisplayStartMessage("Listing Activity");
                Console.Clear();
                listing1.RunListingActivity();
            }
        }
        Console.Clear();
    }
}