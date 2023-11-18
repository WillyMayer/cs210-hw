using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

public class GoalList
{
    protected List<Goal> _goals = new();
    protected int _points = 0;
    public void CreateNewGoal()
    {
        Console.Clear();
        Console.WriteLine("Which kind of goals do you want to do? ");
        Console.WriteLine();
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        Console.Write("Select an option: ");
        string goalOption = Console.ReadLine();

        if (goalOption == "1")
        {
            SimpleGoal simpleGoal = new();
            simpleGoal.SetData();
            _goals.Add(simpleGoal);
        }
        else if (goalOption == "2")
        {
            EternalGoal eternalGoal = new();
            eternalGoal.SetData();
            _goals.Add(eternalGoal);
        }
        else if (goalOption == "3")
        {
            ChecklistGoal checklistGoal = new();
            checklistGoal.SetData();
            _goals.Add(checklistGoal);
        }
        else
        {
            Console.WriteLine("Please enter an option below");
        }

    }

    public void ListGoals()
    {
        // print goals as a numbered list
        Console.WriteLine();
        Console.WriteLine("Your goals are:");
        for (int i = 0; i <= _goals.Count - 1; i++)
        {
            Console.Write($"  {i + 1}.");
            _goals[i].DisplayGoal();
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the name of the file to save your goals? ");
        string fileName = Console.ReadLine();

        using (StreamWriter goalFile = new(fileName))
        {

            goalFile.WriteLine($"{_points}");

            foreach (Goal goal in _goals)
            {
                goalFile.WriteLine(goal.GetDataString());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the name of the file to load your goals? ");
        string fileName = Console.ReadLine();

 
        string[] lines = File.ReadAllLines(fileName);

        string[] firstLineValues = lines[0].Split(";");
        _points = int.Parse(firstLineValues[0]);

        for (int i = 1; i <= lines.Length - 1; i++)
        {
            string[] values = lines[i].Split(";");
            switch (values[0])
            {
                case "SimpleGoal":
                    SimpleGoal simpleGoal = new();
                    simpleGoal.LoadDataArray(values);
                    _goals.Add(simpleGoal);
                    break;

                case "EternalGoal":
                    EternalGoal eternalGoal = new();
                    eternalGoal.LoadDataArray(values);
                    _goals.Add(eternalGoal);
                    break;

                case "ChecklistGoal":
                    ChecklistGoal checklistGoal = new();
                    checklistGoal.LoadDataArray(values);
                    _goals.Add(checklistGoal);
                    break;
            }
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine();
        Console.WriteLine("Your goals are:");
        for (int i = 0; i <= _goals.Count - 1; i++)
        {
            Console.WriteLine($"  {i + 1}. {_goals[i].GetName()}");
        }

        Console.Write("Which goals did you accomplish? ");
        int completedGoal = int.Parse(Console.ReadLine());

        _points += _goals[completedGoal - 1].CompleteGoal();
    }

    public int GetPoints()
    {
        return _points;
    }

}