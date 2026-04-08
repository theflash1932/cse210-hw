using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.Clear();
        String text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        Reference r = new Reference("John",3,16);
        Scripture s = new Scripture(r, text);
    }
}
class Scripture
{
    Reference _reference;
    List<Word> _words;

    // constructors
    public Scripture(Reference r, String s)
    {
        _reference = r;
        foreach(String w in s.Split(" "))
        {
            Word h = new Word(w);
            _words.Add(h);
        }
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
}

class Word
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