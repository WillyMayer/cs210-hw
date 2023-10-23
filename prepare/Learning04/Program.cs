using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment("Willian Mayer", "Math");
        Console.WriteLine(assign1.GetSumary());

        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fraction", "7.3", "8-19");
        Console.WriteLine(a2.GetSumary());
        Console.WriteLine(a2.GetHomeworkList());

    }
}