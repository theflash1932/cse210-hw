public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayEntries(Entry e)
    {
        Console.WriteLine(e._date);
        Console.WriteLine(e._promptText);
        Console.WriteLine(e._entryText);
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            for (int i = 0; i < _entries.Count; i++)
            {
                outputFile.WriteLine(_entries[i]._date);
                outputFile.WriteLine(_entries[i]._promptText);
                outputFile.WriteLine(_entries[i]._entryText);
            }
        }
    }
    public void LoadFromFile(string file)
    {
        string[] entryLines = System.IO.File.ReadAllLines(file);
        string a = "", b = "", c = "";
        for (int i = 0; i < entryLines.Count(); i++)
        {
            if (i % 3 == 0)
            {
                a = entryLines[i];
            }
            if (i % 3 == 1)
            {
                b = entryLines[i];
            }
            if (i % 3 == 2)
            {
                c = entryLines[i];
                AddEntry(new Entry(a, b, c));
            }
        }
    }
    public void SaveAsJSON(string file)
    {
        string[] entryLines = System.IO.File.ReadAllLines(file);
        string jsonFile = $"..\\..\\..\\journal.json";
        using (StreamWriter json = new StreamWriter(jsonFile, append: false))
        {
            json.WriteLine("{");
            json.WriteLine("\"entries\": [");
            for (int i = 0; i < entryLines.Count(); i++)
            {
                if (i % 3 == 0)
                {
                    json.WriteLine("{");
                    json.WriteLine($"\"date\": \"{entryLines[i]}\",");

                }
                if (i % 3 == 1)
                {
                    json.WriteLine($"\"prompt\": \"{entryLines[i]}\",");
                }
                if (i % 3 == 2)
                {
                    json.WriteLine($"\"response\": \"{entryLines[i]}\"");
                    if (i + 1 == entryLines.Count())
                    {
                        json.WriteLine("}");
                    }
                    else json.WriteLine("},");
                }
            }
            //json.WriteLine("}");
            json.WriteLine("]");
            json.WriteLine("}");
        }
    }
}