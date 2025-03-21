using System.Text.RegularExpressions;

class Scripture
{
    private Reference _reference { get; set; }
    private List<Word> _words { get; set; }

    public Scripture(Reference reference, string words)
    {
        this._reference = reference;
        this._words = Convert_String(words);
    }

    private static List<Word> Convert_String(string phrase)
    {
        List<Word> interno = new List<Word>();
        string[] phrases = Regex.Replace(phrase, @"\s+", " ").Trim().Split(" ");
        foreach (string item in phrases)
        {
            interno.Add(new Word(item));
        }
        return interno;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word wd in _words)
        {
            if (!wd.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public string Display()
    {
        string text = "";
        foreach (Word w in _words)
        {
            text += w.GetWord() + " ";
        }
        return _reference.GetReference() + " " + text.Trim();
    }

    public void HideWords(int count = 1)
    {
        if (!IsCompletelyHidden())
        {
            Random random = new Random();
            List<Word> visibleWords = new List<Word>();
            foreach (Word w in _words)
            {
                if (!w.IsHidden())
                    visibleWords.Add(w);
            }
            int wordsToHide = Math.Min(random.Next(1, _words.Count / 6), visibleWords.Count);
            for (int i = 0; i < wordsToHide; i++)
            {
                int index = random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index);
            }
        }
    }
}