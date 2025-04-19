using System;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();

            Running running = new Running(new DateTime(2022, 11, 3), 30, 3.0);
            activities.Add(running);

            Cycling cycling = new Cycling(new DateTime(2022, 11, 4), 45, 15.0);
            activities.Add(cycling);

            Swimming swimming = new Swimming(new DateTime(2022, 11, 5), 40, 20);
            activities.Add(swimming);

            Console.WriteLine("Exercise Tracking Program");
            Console.WriteLine("------------------------");

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }

}