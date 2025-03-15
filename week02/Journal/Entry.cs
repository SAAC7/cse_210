public class Entry{
    public DateTime _date;
    public string _prompt;
    public string _entryText;

    public Entry(DateTime _date,string _prompt, string _entryText){
        this._date = _date;
        this._prompt=_prompt;
        this._entryText = _entryText;
    }

    public void Display(){
        Console.WriteLine($"Date: {_date.ToShortDateString()} - Prompt: {_prompt}");
        Console.WriteLine(_entryText);
    }
}