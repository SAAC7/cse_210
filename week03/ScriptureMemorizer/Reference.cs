using System;
class Reference
{
    private string _book;
    private int _chapter;
    private int _startverse;
    private int _endverse;
// 2 Nephi 2:25
    public Reference(string book, int chapter, int verse)
    {
       _book = book;
       _chapter = chapter;
       _startverse = verse;
       _endverse = null;
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
        return _endverse != null ? $"{_book} {_chapter}: {_startverse}-{_endverse}" : $"{_book} {_chapter}: {_startverse}";

        // if (_endverse != null){
        //return "${_book}" {_chapter}: {_startverse};
        //}
        
        // return  $"{_book} {_chapter}: {_startverse}$"{_book} {_chapter}: {_startverse}"
    }
}
