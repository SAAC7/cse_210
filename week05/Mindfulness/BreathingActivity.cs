using System;

class BreathingActivity : Activiy
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through deep breathing. " + "Clear your mind and focus on your breath.")
    {
    }

    public void RunActivity()
    {
        StartActiviy();
        int totaltime =0;
        while (totaltime<_duration)
        {
            Console.Write("Inhale... ");
            CountDownAnimation(4);
            totaltime += 4;
            if (totaltime >=_duration)
                break;
            Console.Write("Exhale... ");
            CountDownAnimation(6);
            totaltime+=6;

        }    
        EndActivity();
    }
}