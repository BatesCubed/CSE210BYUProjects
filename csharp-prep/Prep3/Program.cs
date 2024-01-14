using System;

class Program
{
    static void Main(string[] args)
    {
        string redoGame = "Y";
        while (redoGame == "Y")
        {
            Random randNumber = new Random();
            int magicNumber = randNumber.Next(1,1000);
            Console.Write("What is your guess? ");
            int userGuess = int.Parse(Console.ReadLine());
            int tryCount = 1;
            string guessTense;
            while (userGuess != magicNumber)
            {
                if (userGuess >= magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (userGuess <= magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());
                tryCount += 1;
            }
            if (tryCount == 1)
            {
                guessTense = "guess";
            }
            else
            {
                guessTense = "guesses";
            }
            Console.WriteLine($"Congratulations! The magic number was {magicNumber}!");
            Console.WriteLine($"It took you {tryCount} {guessTense} to get the correct answer!");
            Console.WriteLine();
            Console.Write("Would you like to play again? Y for Yes N for No ");
            string redo = Console.ReadLine();

            redoGame = redo.ToUpper();
        }

        Console.WriteLine("Alright! Good Bye! Thanks for playing!");
        
    }
}