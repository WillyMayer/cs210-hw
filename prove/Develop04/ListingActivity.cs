using System;
using System.Reflection.Metadata;

public class ListingActivity : Activity
{
    private string _randomQuestions;

    public ListingActivity(string activityName, string description, int duration) : base(activityName, description, duration)
    {
        
    }
    public void RandomQuestions()
    {

    }

    public void RunActivity()
    {
        base.StartingMessage();

        base.EndingMessage();
    }
}