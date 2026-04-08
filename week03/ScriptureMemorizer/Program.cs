using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.Clear();
        string t = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        //Console.WriteLine(text);
        Reference r = new Reference("John",3,16);
        r.ShowReference();
        Scripture s = new Scripture(r, t);
        s.ShowReference();
        
    }
}
class Scripture
{
    Reference _reference;
    //List<Word> _words;

    // constructors
    public Scripture(Reference r, String s)
    {
        _reference = r;
        //foreach(String w in s.Split(" "))
        //{
        //    Word h = new Word(w);
        //    _words.Add(h);
        //}
        //_words.Add();

    }
    public Scripture(Reference r)
    {
        _reference = r;
    }
    public void ShowReference()
    {
        _reference.ShowReference();
    }
}

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
        if(_ending != _starting)
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
