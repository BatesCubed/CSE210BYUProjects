public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity()
    {
        //
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
         _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity!");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine("");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("");
        Console.Write("Well done!! ");
        ShowSpinner(3);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationFrames = new List<string>();
        animationFrames.Add("|");
        animationFrames.Add("/");
        animationFrames.Add("-");
        animationFrames.Add("\\");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            foreach (string frame in animationFrames)
            {
                Console.Write(frame);
                Thread.Sleep(150);
                Console.Write("\b \b");
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            //I used this to make sure that all digits got removed with the backspaces. 
            //Even if there were 4 digits, it would remove them all.
            int digits = i.ToString().Length;
            for (int l = digits; l > 0; l--)
            {
                Console.Write("\b \b");
            }
            
        }
    }

}