using System;

public class ChecklistGoal : Goal
{
    private int _threshold;
    private int _timesCompleted = 0;
    private int __points;
    private bool _completed = false;

    public ChecklistGoal()
    {
        SetGoalType("ChecklistGoal");
    }

    public override string GetDataString()
    {
        return $"{GetGoalType()};{_name};{_desc};{GetPoints()};{_completed};{__points};{_threshold};{_timesCompleted}";
    }

    public override void LoadDataArray(string[] values)
    {
        _name = values[1];
        _desc = values[2];
        SetPoints(int.Parse(values[3]));
        _completed = bool.Parse(values[4]);
        __points = int.Parse(values[5]);
        _threshold = int.Parse(values[6]);
        _timesCompleted = int.Parse(values[7]);
    }

    public override void SetData()
    {

        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();

        // set description
        Console.Write("What is a short description of it? ");
        _desc = Console.ReadLine();

        // set EXP points
        Console.Write("What is the amount of points associated with this goal? ");
        string expPtsText = Console.ReadLine();
        SetPoints(int.Parse(expPtsText));

        // set times to complete goal
        Console.Write("How many times does this goal need to be accomplished? ");
        _threshold = int.Parse(Console.ReadLine());

        // set the _points
        Console.Write("What is the _points for accomplishing it that many times? ");
        __points = int.Parse(Console.ReadLine());
    }

    public override void DisplayGoal()
    {
        string checkmark = " ";
        if (_completed)
        {
            checkmark = "X";
        }
        Console.WriteLine($"[{checkmark}] {_name} ({_desc}) -- Currently completed: {_timesCompleted}/{_threshold}");
    }

    public override int CompleteGoal()
    {
        if (!_completed) // if goal is not complete
        {
            _timesCompleted++;
            _completed = _timesCompleted == _threshold;
            if (_completed)
            {
                Console.WriteLine($"Congratulations! You completed the goal {_threshold} times!");
                Console.WriteLine($"You earned {GetPoints()} as well as a _points of {__points} points!");
                return GetPoints() + __points;
            }
            // else (saving a few lines)
            Console.WriteLine($"Congratulations! You earned {GetPoints()} points.");
            return GetPoints();
        }
        return 0;
    }
}