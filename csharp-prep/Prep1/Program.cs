using System;

class Program
{
    static void Main(string[] args)
    {   
        //Input the names
        Console.Write("What is your first name? ");
        string fname = Console.ReadLine();

        Console.Write("What is your last name? " );
        string lname = Console.ReadLine();

        //Results
        Console.WriteLine("");
        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");
    }
}