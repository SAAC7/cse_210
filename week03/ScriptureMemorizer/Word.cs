using System;

class Word
{
    private string _word { get; set; }
    private bool _isHidden { get; set; }
    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetWord()
    {
        return _isHidden ? new string('_', _word.Length) : _word;
    }
}