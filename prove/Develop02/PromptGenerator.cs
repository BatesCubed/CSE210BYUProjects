using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>() {"What is the most interesting thing that happened to you today?",
                                    "Did anyone or anything make you feel good today?",
                                    "Name a moment today that you felt the best about yourself!",
                                    "What was the highlight of the day for you?",
                                    "What were some projects that you started/continued/ended today?",
                                    "List five things you are grateful for today and explain why.",
                                    "Describe a small act of kindness you witness or performed recently.",
                                    "Reflect on a challenging situation and find something positive or a lesson you learned from it.",
                                    "Write about a recent moment of stillness or mindfulness and how it made you feel."};
    public Random random = new Random();
    public string GetRandomPrompt()
    {
        
        int randNum = random.Next(0,_prompts.Count);
        string thePrompt = _prompts[randNum];

        return thePrompt;
    }
}