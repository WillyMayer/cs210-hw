using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string nameActivity, string description, int duration) : base(nameActivity, description, duration)
    {

    }

    public void RunActivity()
    {
            base.StartingMessage();

            base.EndingMessage();
    }
}