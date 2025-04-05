using System;

class ReflectionActivity : Activiy
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you were truly unselfish."
    };

private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you done anything similar before?",
        "How did you get started?",
        "How did you feel when you finished?",
        "What made this experience different from others in which you were not successful?",
        "What do you like most about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times when you have shown strength and resilience. " + "You will recognize the power you have and how you can apply it to other aspects of your life.")
    {
    }

    public void RunActivity()
    {
        StartActiviy();
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        SpinnerAnimation(3);

        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine(question);
            SpinnerAnimation(5);
        }
        EndActivity();
    }
}