public class PromptGenerator
{
    public static string filename = "..\\..\\..\\prompts.txt";
    string[] _prompts = System.IO.File.ReadAllLines(filename);

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, _prompts.Count());
        return _prompts[magicNumber];
    }
}