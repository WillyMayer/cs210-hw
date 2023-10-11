using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Reference reference1 = new Reference();
        string display = reference1.GetScripture();
        Console.Write(display);
    }
}