using System;

public class Program
{
    public static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.RunActivity();
                    break;
                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.RunActivity();
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.RunActivity();
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
            if (!exit)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
/*
Comments on overcoming requirements:

- A system of inheritance and encapsulation has been implemented: the base Activity class defines common attributes and methods
 (such as StartActivity, EndActivity and pause animation) that are inherited and reused in derived classes.
- Each activity is in a separate file and the naming convention is followed (TitleCase for classes, 
 _underscoreCamelCase for member variables, camelCase for local variables).
- An animation (spinner) has been included that uses backtracking to create the visual effect of pausing.
- To exceed the requirements, additional functionality can be implemented such as: 
    - Recording in a log the number of times each activity has been performed.
    - Control that prompts and questions are not repeated until they have all been shown at least once.
    - Include more sophisticated text animations (e.g. color or size changes) for the breathing activity.
*/
