using System;

class Program
{
    static void Main(string[] args)
    {
        int menuChoice;
        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to your mindful break of the day!");
            Console.WriteLine("");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("");
            Console.Write("Choose the activity you would like to start: ");
            menuChoice = int.Parse(Console.ReadLine());
            if (menuChoice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                Console.Clear();
                breathingActivity.Run();
            }
            else if (menuChoice == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                Console.Clear();
                reflectingActivity.Run();
            }
            else if (menuChoice == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                Console.Clear();
                listingActivity.Run();
            }
            else if (menuChoice == 4)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("Goodbye! And have a great day, remember to have peace throughout the day!");
                Console.WriteLine("");
                continue;
            }

        }
        while (menuChoice != 4);
    }
}