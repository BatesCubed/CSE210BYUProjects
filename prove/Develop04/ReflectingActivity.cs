public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>() {"Think of a time when you did something really difficult ",
                                                        "Think of a time when you thought you were going to quit, though you didn't ",
                                                        "Think of a time when you helped someone, either with something big, or something small ",
                                                        "Think of a time when you did something alone, when you thought you couldn't do it alone ",
                                                        "Think of a time when you got a project done early "};
    private List<string> _questions = new List<string>() {"What were some of the feelings you had? ",
                                                          "What lessons did you learn from this? ",
                                                          "How did you feel during and after this?",
                                                          "What were the benefits for you, that you did this. ",
                                                          "What were some thoughts that were going through your mind at this time? "};

    public ReflectingActivity()
    {
        SetName("Reflecting");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        int indQuestionTime = duration / 2;
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        DisplayPrompt();
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press ENTER to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(10);
        Console.Clear();
        Console.WriteLine("");
        DisplayQuestions();
        ShowSpinner(indQuestionTime);
        Console.WriteLine("");
        DisplayQuestions();
        ShowSpinner(indQuestionTime);
        Console.WriteLine("");
        DisplayEndingMessage();
        

        
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        string chosenPrompt = _prompts[random.Next(0,_prompts.Count())];
        return chosenPrompt;
    }

    public string GetRandomQuestion()
    {
        Random randQuestion = new Random();
        string chosenQuestion = _questions[randQuestion.Next(0,_questions.Count())];
        return chosenQuestion;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
    }

    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()}");
    }
}