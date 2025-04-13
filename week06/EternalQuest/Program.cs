using System;
namespace EternalQuest
{
    class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        GoalManager goalManager = new GoalManager();
        bool quit = false;

        Console.WriteLine("Welcome to the Eternal Quest Program!");
        Console.WriteLine("Track your goals and level up on your journey to becoming your best self.");

        while (!quit)
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Display Score");
            Console.WriteLine("7. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            Console.Clear();
            switch (choice)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;
                case "2":
                    goalManager.DisplayGoals();
                    break;
                case "3":
                    goalManager.SaveGoals();
                    break;
                case "4":
                    goalManager.LoadGoals();
                    break;
                case "5":
                    goalManager.RecordEvent();
                    break;
                case "6":
                    goalManager.DisplayScore();
                    break;
                case "7":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        Console.WriteLine("Thank you for using the Eternal Quest Program!");
    }
}

/* 
A level system has been added: users gain levels as they accumulate points, with each level requiring more and more points. This adds depth to the game.
Each time the user levels up, they receive bonus points based on their new level.
We created a new type of goal “ProgressGoal” that:
 - Records progress towards a numerical goal (such as saving money or reading pages)
 - Allows users to record varying amounts of progress each time
 - Awards milestone points at specific intervals before goal completion
 - Awards a completion bonus when the entire goal is finished
Improved display information showing level progress and points needed for the next level.
*/ 

}