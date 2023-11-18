using System;
public class SimpleGoal : Goal
{
    private bool _completed = false;

    public SimpleGoal()
    {
        SetGoalType("SimpleGoal");
    }

    public override string GetDataString()
    {
        return $"{GetGoalType()};{_name};{_desc};{GetPoints()};{_completed}";
    }

    public override void LoadDataArray(string[] values)
    {
        _name = values[1];
        _desc = values[2];
        SetPoints(int.Parse(values[3]));
        _completed = bool.Parse(values[4]);
    }

    public override void DisplayGoal()
    {
        string checkmark = " ";
        if (_completed)
        {
            checkmark = "X";
        }
        Console.WriteLine($"[{checkmark}] {_name} ({_desc})");
    }

    public override int CompleteGoal()
    {
        if (!_completed)
        {
            _completed = true;
            Console.WriteLine($"Congratulations! You earned {GetPoints()} EXP points!");
            return GetPoints();
        }
        else
        {
            Console.WriteLine("You have already completed this goal");
            return 0;
        }
    }
}