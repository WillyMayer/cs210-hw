using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assign1.GetSummary());
        Console.WriteLine();

        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fraction", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingAssignment());
    }
}