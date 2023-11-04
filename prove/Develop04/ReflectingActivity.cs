using System;

public class ReflectingActivity : Activity
{
    private List<Program> _randomPrompt;
    private List<Program> _randomQuestion;

    public ReflectingActivity(string activityName, string description, int duration) : base(activityName, description, duration)
    {

    }
    public void DisplayPrompt()
    {

    }

    public void DisplayQuestions()
    {

    }

    public void RunActivity()
    {
        base.StartingMessage();

        base.EndingMessage();
    }
}