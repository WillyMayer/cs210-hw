using System;
using System.Reflection.Metadata;

public class ListingActivity : Activity
{
    private List<string> _randomQuestions;

    //Adding questions
    public ListingActivity(string activityName, string description, int duration) : base(activityName, description, duration)
    {
        _randomQuestions.Add("Who are people that you appreciate?");
        _randomQuestions.Add("What are personal strengths of yours?");
        _randomQuestions.Add("Who are people that you have helped this week?");
        _randomQuestions.Add("When have you felt the Holy Ghost this month?");
        _randomQuestions.Add("Who are some of your personal heroes?");
    }
    public void RandomQuestions()
    {
        Random rnd = new Random();
        int index = rnd.Next(_randomQuestions.Count);
        string randomQuestion = _randomQuestions[index];
        Console.WriteLine("Random Question: " + randomQuestion);
    }

    public void RunActivity()
    {
        base.StartingMessage();

        RandomQuestions();

        int seconds = base._duration;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {

            Console.WriteLine("Write down a blessing: ");
            string blessing = Console.ReadLine();
            Console.WriteLine($"You wrote: {blessing}");

            Thread.Sleep(1000);
        }

        base.EndingMessage();
    }
}