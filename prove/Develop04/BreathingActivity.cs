using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string nameActivity, string description, int duration) : base(nameActivity, description, duration)
    {

    }

    public void RunActivity()
    {
        base.StartingMessage();

        
        int durationInSeconds = base._duration;
        DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in");
            CountdownTimer(5);
            Console.WriteLine("");
            Console.Write("Breathe out");
            CountdownTimer(5);
            Console.WriteLine("");

        }
        base.EndingMessage();
    }
}