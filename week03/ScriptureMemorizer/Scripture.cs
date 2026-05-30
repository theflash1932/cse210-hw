using System;
class Scripture
{
    Reference _reference;
    List<Word> _words = [];
    int numbHidden = 0;

    // constructors
    public Scripture(Reference r, String s)
    {
        _reference = r;
        foreach (String w in s.Split(" "))
        {
            //Word h = new Word(w);
            _words.Add(new Word(w));
        }
    }
    public Scripture(Reference r)
    {
        _reference = r;
    }
    public void ShowReference()
    {
        List<int> notHidden = [];
        foreach (Word word in _words)
        {
            //Console.Write($"{word.ShowText()} ");
            Console.Write($"{word.ShowText()} ");
            //if (word.IsHidden()) { numbHidden++; }
            //else { notHidden.Add(_words.IndexOf(word)); }
            if (!word.IsHidden()) { notHidden.Add(_words.IndexOf(word)); }
        }
        for (int i = 0; i < 3; i++)
        {
            var r = new Random();
            int index = r.Next(notHidden.Count());
            int randomInt = notHidden[index];
            _words[randomInt].HideWord();
        }
    }
    public void Finish()
    {
        foreach (Word w in _words)
        {
            w.HideWord();
        }
    }
    public bool AllHidden()
    {
        numbHidden = 0;
        for (int i = 0; i < _words.Count(); i++)
        {
            if (_words[i].IsHidden()) { numbHidden++; }
        }
        if (numbHidden >= _words.Count())
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}