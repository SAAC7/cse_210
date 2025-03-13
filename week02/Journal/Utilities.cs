public static class Utilities{
    static List<String> _questions  = new List<String>{
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    public static string RandomQuestion (){
        Random random= new Random();
        int rannumber = random.Next(0, _questions.Count-1);
        return _questions[rannumber];
    }
    
    

}