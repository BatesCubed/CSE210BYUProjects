public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>() {"When have you felt the closest to Heavenly Father this month?",
                                                        "When have you felt the Holy Ghost this month?",
                                                        "What simple acts of kindness have you done recently?",
                                                        "What was the last thing you gave someone that you felt good about?",
                                                        "When have you overcome a trial recently?",
                                                        "List all the people that you trust to keep you on the straight and narrow path",
                                                        "What impressions did you get the last time you read the scriptures?",
                                                        "List all of the talents/hobbies that make you, YOU!",
                                                        "Where have you been when you felt closest to the savior",
                                                        "Who are you missing recently?",
                                                        "List all of the compliments you gave/received this month"};

    public ListingActivity()
    {
        SetName("Listing");
        SetDescription("This activity will help you reflect on the good things in your life by having you\nlist as many things as you can in a certain area.");
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("");
        List<string> userResponseList = GetListFromUser();
        _count = userResponseList.Count();
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random randPrompt = new Random();
        string pickedPrompt = _prompts[randPrompt.Next(0,_prompts.Count())];
        Console.WriteLine($" --- {pickedPrompt} --- ");
    }

    public List<string> GetListFromUser()
    {
        int duration = GetDuration();
        List<string> responses = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        
        while (DateTime.Now <= endTime)
        {
            Console.Write("> ");
            string userResponse = Console.ReadLine();
            responses.Add(userResponse);
        }
        return responses;
    }
}