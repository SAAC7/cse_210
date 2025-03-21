using System;
class Reference
{
    private string _book {get;set;}
    private int _chapter {get; set;}
    private int _startverse {get; set;}
    private int _endverse {get; set;}
// 2 Nephi 2:25
    public Reference(string book, int chapter, int verse)
    {
       _book = book;
       _chapter = chapter;
       _startverse = verse;
       _endverse = verse;
    }


// 2 Nephi 2:25-30
    public Reference(string book, int chapter, int startverse, int endverse)
    {     
       _book = book;
       _chapter = chapter;
       _startverse = startverse;
       _endverse = endverse;
    }

    public string GetReference()
    {
        // 2 Nephi 2:25-30
        return _endverse != _startverse ? $"{_book} {_chapter}: {_startverse}-{_endverse}" : $"{_book} {_chapter}: {_startverse}";

        // if (_endverse != null){
        //return "${_book}" {_chapter}: {_startverse};
        //}
        
        // return  $"{_book} {_chapter}: {_startverse}$"{_book} {_chapter}: {_startverse}"
    }
}
