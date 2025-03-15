using System.Runtime.CompilerServices;

public static class Utilities
{
    private static List<String> _questions = new List<String>{
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    private static Random _random = new Random();
    public static string RandomQuestion()
    {

        int rannumber = _random.Next(_questions.Count);
        return _questions[rannumber];
    }
    public static int Count(){
        return _questions.Count;
    }
    public static string Prompt(int index){
        return _questions[index];
    }
    // I create this method and the errase method to add a personal prompts 
    public static void AddPrompt(String promp)
    {
        if (!string.IsNullOrEmpty(promp))
        {
            _questions.Add(promp);
            Console.WriteLine($"Your promp {promp}\nhas been added");
        }
        else
        {
            Console.WriteLine($"Your promp {promp}\n It isn't valid");
        }
    }
    // As I know that everyone can make mistakes, I apply this method to eliminate errors in personal prompts.
    public static void RemovePrompt(int prompindex)
    {
        string prompt = _questions[prompindex]; 
        if (!string.IsNullOrEmpty(prompt)){
            _questions.Remove(prompt);
            Console.WriteLine($"The promp {prompt}\nhas been deleted");
        }
        else{
            Console.WriteLine("The prompt is invalid");
        }
    }
    public static void EmptyData(){
        _questions.Clear();
    }
    





}