using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        GoalList goalList = new GoalList();
        Menu menu = new Menu();

        string stopLoop = "6";

        string option = "";

        //Welcome message
        Console.WriteLine("Hi! Welcome to the Goal Tracker system.");
        Console.WriteLine();

        while (option != stopLoop)
        {
            Console.WriteLine($"You earned {goalList.GetPoints()} points ");
            menu.DisplayMenu();

            option = Console.ReadLine();
            if (option == "1")
            {
                goalList.CreateNewGoal();
            }
            else if (option == "2")
            {
                goalList.ListGoals();
            }
            else if (option == "3")
            {
                goalList.SaveGoals();
            }
            else if (option == "4")
            {
                goalList.LoadGoals();
            }
            else if (option == "5")
            {
                goalList.RecordEvent();
            }
            else if (option == "6")
            {
                //Quit program
            }
            else
            {
                Console.WriteLine("Please enter an option below.");
            }
        }

    }
}