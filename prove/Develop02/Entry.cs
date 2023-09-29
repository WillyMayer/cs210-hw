using System;
using System.Security.Cryptography.X509Certificates;

public class Entry
{   
    public string _prompt;
    public string _entry;

    public void Display()
    {
        Console.WriteLine(_prompt);
        Console.WriteLine(_entry);
    }
}
