using System;
using System.Diagnostics;

public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;

    public Activity(string activityName, string description, int duration)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }

    public void StartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} program!");
        Thread.Sleep(3000);
        Console.WriteLine("");
        Console.WriteLine(_description);
        Thread.Sleep(3000);
    }

    public void EndingMessage()
    {
        Console.Clear();
        Console.WriteLine("Well done!!");
        Thread.Sleep(1000);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}");
    }

    public void ShowingSpinner(int second)
    {
        List<string> _animationString = new List<string>();
        _animationString.Add("|");
        _animationString.Add("/");
        _animationString.Add("-");
        _animationString.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(second);

        int i = 0;

        while (DateTime.Now > endTime)
        {
            string s = _animationString[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void CountdownTimer(int second)
    {
        for (int i = second; i > 0; i--)
        {
            Console.WriteLine($"Time remaining: {i} seconds");
            Thread.Sleep(1000);
        }
    }
}