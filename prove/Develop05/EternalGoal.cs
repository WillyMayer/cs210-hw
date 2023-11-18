using System;
public class EternalGoal : Goal
{
    public EternalGoal()
    {
        SetGoalType("EternalGoal");
    }

    public override string GetDataString()
    {
        return $"{GetGoalType()};{_name};{_desc};{GetPoints()}";
    }

    public override void LoadDataArray(string[] values)
    {
        _name = values[1];
        _desc = values[2];
        SetPoints(int.Parse(values[3]));
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[-] {_name} ({_desc})");
    }

    public override int CompleteGoal()
    {
        Console.WriteLine($"Congratulations! You earned {GetPoints()} points");
        return GetPoints();
    }
}