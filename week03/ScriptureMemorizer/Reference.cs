using System;
class Reference
{
    String _book;
    int _chapter;
    int _starting;
    int _ending;

    // constructors
    public Reference(String b, int c, int v)
    {
        _book = b;
        _chapter = c;
        _starting = v;
        _ending = v;
    }
    public Reference(String b, int c, int v, int e)
    {
        _book = b;
        _chapter = c;
        _starting = v;
        _ending = e;
    }
    public void ShowReference()
    {
        String verses;
        if (_ending != _starting)
        {
            verses = _starting.ToString() + "-" + _ending.ToString();
        }
        else
        {
            verses = _starting.ToString();
        }
        Console.WriteLine($"{_book} {_chapter}:{verses}");
    }
}
