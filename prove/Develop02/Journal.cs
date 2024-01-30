using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry completeEntry in _entries)
        {
            Console.WriteLine("");
            Console.WriteLine($"Date: {completeEntry._date}");
            Console.WriteLine($"Prompt: {completeEntry._promptText}");
            Console.WriteLine($"Response: {completeEntry._entryText}");
            Console.WriteLine("");
        }
    }

    public void SaveToFile(string file)
    {
        string filename = file;

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry completeEntry in _entries)
            {
                outputFile.WriteLine($"\"{completeEntry._date}\",\"{completeEntry._promptText}\",\"{completeEntry._entryText}\"");
            }
            
        }
    }

    public void LoadFromFile(string file)
    {
        string filename = file;
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            char quotes = '"';
            string date = parts[0];
            date = date.TrimStart(quotes);
            date = date.TrimEnd(quotes);
            string prompt = parts[1];
            prompt = prompt.TrimStart(quotes);
            prompt = prompt.TrimEnd(quotes);
            string entry = parts[2];
            entry = entry.TrimStart(quotes);
            entry = entry.TrimEnd(quotes);

            Entry existingEntry = new Entry();
            existingEntry._date = date;
            existingEntry._promptText = prompt;
            existingEntry._entryText = entry;

            AddEntry(existingEntry);
        }
    }
}