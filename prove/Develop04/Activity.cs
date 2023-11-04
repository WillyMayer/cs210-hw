using System;
using System.Diagnostics;

public class Activity
{
    private string _activityName;
    private string _description;
    public int _duration;

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
        Console.WriteLine("");
        Console.WriteLine("Well done!!");
        Thread.Sleep(1000);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}");
        Console.WriteLine("");
    }

    public void ShowingSpinner(int second)
    {
        List<string> _animationString = new List<string>
        {
           "|",
            "/",
            "-",
            "\\"
        };

        int animationIndex = 0;
        DateTime endTime = DateTime.Now.AddSeconds(second);

        while (DateTime.Now < endTime)
        {
            Console.Write("\r" + _animationString[animationIndex]);
            animationIndex = (animationIndex + 1) % _animationString.Count;
            Thread.Sleep(100);
        }

        Console.Write("\r");
    }

    public void CountdownTimer(int second)
    {
        for (int i = second; i > 0; i--)
        {
            Console.Write($".");
            Thread.Sleep(1000);
        }
    }
}