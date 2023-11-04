using System;
using System.ComponentModel;

public class ReflectingActivity : Activity
{
    private List<string> _randomPrompt;
    private List<string> _randomQuestion;

    public ReflectingActivity(string activityName, string description, int duration) 
        : base(activityName, description, duration)
    {
        _randomPrompt = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _randomQuestion = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }
    public void DisplayPrompt()
    {
        Random random = new Random();
        int index = random.Next(_randomPrompt.Count);
        string randomPrompt = _randomPrompt[index];

        Console.WriteLine("Ponder this question");
        Console.WriteLine($"-- {randomPrompt} --");
        Console.WriteLine("");
    }

    public void DisplayQuestions()
    {
        Random random = new Random();
        int index = random.Next(_randomQuestion.Count);
        string randomQuestion = _randomQuestion[index];

        Console.WriteLine(randomQuestion);
    }

    public void RunActivity()
    {
        base.StartingMessage();

        int durationInSeconds = base._duration;
        DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);

        Console.WriteLine("");
        DisplayPrompt();

        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            ShowingSpinner(10);
        }
        base.EndingMessage();
    }
}
