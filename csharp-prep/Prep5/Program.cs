using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()

        /* NOTE:
        At first, I had my function that squares the number as a double, so that I could use the Math.Pow(numToSquare, 2), to get the squared value. Though, after I saw that
        the example used int squaredNum = num * num, I decided to change it to that because it would store less information. Because we won't be working with decimals in this
        program, it would be a waste of memory to store a double.*/

        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number?: ");
            int favNum = int.Parse(Console.ReadLine());
            return favNum;
        }

        static int SquareNumber(int numToSquare)
        {
            int squareNum = numToSquare * numToSquare;
            return squareNum;
        }

        static void DisplayResult(string userName, int squaredNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
        }

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredUserNum = SquareNumber(userNumber);
        DisplayResult(userName, squaredUserNum);
    }
}