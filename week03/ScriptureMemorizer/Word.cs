using System;
class Word
{
    private string _word;
    private bool _isHidden;
    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public void Hide(){
        _isHidden = true;
    }
    public void Show(){
        _isHidden = false;
    }
    public bool IsHidden(){
        return _isHidden;
    }
    
    public string GetWord(){
        string word="";
        if (_isHidden)
        {
            foreach (char c in _word)
        {
            word += "_";
        }
            return word;
        }
        
        return _word;
    }
}