using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percentage = int.Parse(grade);

        string letter = "";

        if (percentage >= 90) 
        {
            letter = "A";
        } else if (percentage >= 80) 
        {
            letter = "B";
        } else if (percentage >= 70)
        {
            letter = "C";
        } else if (percentage >= 60)
        {
            letter = "D";
        } else if (percentage < 60) 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (percentage >= 70) {
            Console.WriteLine("Congrats! You passed.");
        } else if (percentage < 70) 
        {
            Console.WriteLine("Sorry, try the next time.");
        }
    }
}