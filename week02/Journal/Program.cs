using System;

class Program
{
    static void Main(string[] args)
    {
        Utilities util = new Utilities();
        String quetion = util.randomQuestion();
        Console.WriteLine("" + quetion);
       
    }
}

public class Journal{

}
public class Notes{

}public class Utilities{
    List<String> questions  = new List<String>{
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    public string randomQuestion (){
        Random random= new Random();
        int rannumber = random.Next(0, questions.Count-1);
        return questions[rannumber];
    }

}
