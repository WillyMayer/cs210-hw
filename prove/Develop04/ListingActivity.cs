using System;
using System.Reflection.Metadata;

public class ListingActivity : Activity
{
    private List<string> _randomQuestions;

    //Adding questions
    public ListingActivity(string activityName, string description, int duration) : base(activityName, description, duration)
    {
        _randomQuestions = new List<string>
        {   
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };

    }
    public void RandomQuestions()
    {
        Random rnd = new Random();
        int index = rnd.Next(_randomQuestions.Count);
        string randomQuestion = _randomQuestions[index];
        Console.WriteLine("");
        Console.WriteLine("Ponder the next question");
        Console.WriteLine($"-- {randomQuestion} --");
    }

    public void RunActivity()
    {
        base.StartingMessage();

        RandomQuestions();

        int seconds = base._duration;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {

            Console.Write("> ");
            string blessing = Console.ReadLine();
            Thread.Sleep(100);
        }

        base.EndingMessage();
    }
}