using System;

class ListingActivity : Activiy
{
    private List<string> _prompts = new List<string>
    {
        "Who are some people you appreciate?",
 "What are your personal strengths?",
 "Who have you helped this week?",
 "When have you felt the Holy Spirit this month?",
 "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity",
 "This activity will help you reflect on the good things in your life, " +
 "inviting you to list as many positive items as you can on a given topic.")
    {
    }

    public void RunActivity()
    {
        StartActiviy();
        Random rand = new Random();
   
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        Console.WriteLine("Get ready to start listing on...");
        CountDownAnimation(5);

        DateTime startTime = DateTime.Now;
        List<string> responses = new List<string>();
        Console.WriteLine("Start typing your answers. Press ENTER after each one:");
   
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
          
            if (Console.KeyAvailable)
            {
                string response = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(response))
                {
                    responses.Add(response);
                }
            }
        }
        Console.WriteLine($"You have entered {responses.Count} items.");
        EndActivity();
    }
}