public class Entry
{
    static DateTime dateTime = DateTime.Now;
    static string date = dateTime.ToShortDateString();
    public string _date = date;
    
    static PromptGenerator prompt = new PromptGenerator();
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine(_date);
        Console.WriteLine(_promptText);
        Console.WriteLine(_entryText);
    }
}