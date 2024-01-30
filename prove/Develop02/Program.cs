using System;
using System.Diagnostics;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Journal entryJournal = new Journal();
        int action;
        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to your Journal! Today is a great day!");
            Console.WriteLine("");
            Console.WriteLine("Choose an action you would like to run!");
            Console.WriteLine("");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display All Entries");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("");
            Console.Write("What would you like to do? ");
            string actionInput = Console.ReadLine();
            action = int.Parse(actionInput);
            
            if (action == 1)
            {
                Console.Clear();
                PromptGenerator randPrompt = new PromptGenerator();
                Entry entry = new Entry();
                entry._promptText = randPrompt.GetRandomPrompt();
                Console.WriteLine(entry._promptText);
                Console.Write("> ");
                entry._entryText = Console.ReadLine();
                Console.WriteLine(entry._date);
                Console.WriteLine(entry._promptText);
                Console.WriteLine(entry._entryText);
                entryJournal.AddEntry(entry);
            }

            else if (action == 2)
            {
                Console.Clear();
                entryJournal.DisplayAll();
                Console.Write("Press Enter to continue");
                Console.ReadLine();
            }

            else if (action == 3)
            {
                Console.WriteLine("What is the name of the file you would like to load? (Include the .txt part)");
                Console.Write("> ");
                string filename = Console.ReadLine();
                entryJournal.LoadFromFile(filename);
                Console.Clear();
                Console.WriteLine("File Loaded!");
                Console.Write("Press Enter to continue");
                Console.ReadLine();
            }

            else if (action == 4)
            {
                Console.Write("What do you want the name of the file to be? (Don't include the .txt part of the name) > ");
                string filename = Console.ReadLine();
                string filenameTrimmed = filename.Replace(" ","");
                string filePath = filenameTrimmed + ".txt";
                
                entryJournal.SaveToFile(filePath);
                Console.WriteLine("File Saved!");
                Console.Write("Press Enter to continue");
                Console.ReadLine();
            }

            else if (action == 5)
            {
                Console.Clear();
                Console.WriteLine("Goodbye! Have a great day!");
                continue;
            }
        }
        while (action != 5);
    }
}