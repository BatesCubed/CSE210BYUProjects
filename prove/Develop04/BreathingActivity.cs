public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetName("Breathing");
        SetDescription("This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.");
        
    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        int durationLeft = duration;
        List<string> inAndOutList = new List<string>();
        inAndOutList.Add("Breathe in");
        inAndOutList.Add("Now breathe out");
        int i = 8;
        while (i > 0)
        {
            foreach (string breath in inAndOutList)
            {
                int breathDuration = durationLeft / i;
                durationLeft = durationLeft - breathDuration;
                i = i - 1;
                Console.Write($"{breath}... ");
                ShowCountDown(breathDuration);
                Console.Write("\n");
                ;
            }
            Console.WriteLine("");
        }
        DisplayEndingMessage();

    }
}