using System;
public abstract class Goal
{
    protected string _type;
    protected string _name; 
    protected string _desc; 
    protected int _points;

    public string GetGoalType()
    {
        return _type;
    }

    public void SetGoalType(string type)
    {
        _type = type;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public virtual void SetData()
    {

        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        _desc = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        string expPtsText = Console.ReadLine();
        SetPoints(int.Parse(expPtsText));
    }

    public abstract string GetDataString();
    public abstract void LoadDataArray(string[] values);
    public abstract void DisplayGoal();
    public abstract int CompleteGoal();
}