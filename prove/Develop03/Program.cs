using System;

class Program
{
    static void Main(string[] args)
    {
        string book = "Mark";
        int chapter = 13;
        int verse = 13;
        string scriptureText = "And ye shall be hated of all men for my name\'s sake: but he that shall endure unto the end, the same shall be saved.";
        Reference scriptRef = new Reference(book, chapter, verse);
        Scripture scripture = new Scripture(scriptRef, scriptureText);
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine($"{scriptRef.GetDisplayText()} \"{scripture.GetDisplayText()}\"");
        Console.WriteLine("");
        Console.WriteLine("Press ENTER to continue, or TYPE \"quit\" to stop the program!");
        bool stopProgram = false;
        do
        {
            bool allHiddenCheck = scripture.IsCompletelyHidden();
            if (allHiddenCheck != true)
            {
                string forceQuit = Console.ReadLine();
                if (forceQuit == "quit")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Stopping Memorizer... Thanks!");
                    Console.WriteLine("");
                    stopProgram = true;
                }
                else
                {
                    scripture.HideRandomWords(3);
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine($"{scriptRef.GetDisplayText()} \"{scripture.GetDisplayText()}\"");
                    Console.WriteLine("");
                    Console.WriteLine("Press ENTER to continue, or TYPE \"quit\" to stop the program!");
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("All words are hidden! Do you think you have it memorized?");
                Console.WriteLine("Press ENTER to reveal the scripture to see how you did. Or TYPE \"quit\" to end the program without displaying the answer");
                string displayAll = Console.ReadLine();
                if (displayAll == "quit")
                {
                    continue;
                }
                else if (displayAll == "")
                {
                    Console.Clear();
                    scripture.RevealAll();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine($"{scriptRef.GetDisplayText()} \"{scripture.GetDisplayText()}\"");
                    Console.WriteLine("");
                    Console.WriteLine("Did you get it? If you didn't, that's alright! you can try again!");
                }
                Console.WriteLine("");
                stopProgram = true;
            }
            
        }
        while (stopProgram == false);
    }
}