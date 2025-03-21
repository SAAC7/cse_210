using System;

class Reference
{
    private string _book { get; set; }
    private int _chapter { get; set; }
    private int _startverse { get; set; }
    private int _endverse { get; set; }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startverse = verse;
        _endverse = verse;
    }
    public Reference(string book, int chapter, int startverse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _startverse = startverse;
        _endverse = endverse;
    }
    public string GetReference()
    {
        return _endverse != _startverse ?
               $"{_book} {_chapter}: {_startverse}-{_endverse}" :
               $"{_book} {_chapter}: {_startverse}";
    }
}
