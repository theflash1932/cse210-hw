using System;
public class Word
{
    String _word;
    bool _hidden;

    // constructors
    public Word(String s)
    {
        _word = s;
    }

    // methods
    public void HideWord()
    {
        _hidden = true;
    }
    public void ShowWord()
    {
        _hidden = false;
    }
    public bool IsHidden()
    {
        return _hidden;
    }
    public int ShowText()
    {
        return 1;
    }
}