public class Notes{
    public DateTime _theCurrentTime;
    public string _question;
    public string _answer;

    public Notes(DateTime _theCurrentTime,string _question, string _answer){
        this._theCurrentTime = _theCurrentTime;
        this._question=_question;
        this._answer = _answer;
    }

    public void DisplayNote(){
        Console.WriteLine($"Date: {_theCurrentTime.ToShortDateString()} - Prompt: {_question}");
        Console.WriteLine(_answer);
    }
}