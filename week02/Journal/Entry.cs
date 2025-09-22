public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string a, string b, string c)
    {
        _date = a;
        _promptText = b;
        _entryText = c;
    }
    public void Display()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}