using System;

public class Prompt
{
    Random randomGenerator = new Random();
    public string _prompt = "";

    public void Random()
    {
        int number = randomGenerator.Next(1, 5);

        if (number == 1)
        {
            Console.WriteLine("Who was the most interesting person I interacted with today?");
        } else if (number == 2)
        {
            Console.WriteLine("What was the best part of my day?");
        } else if (number == 3)
        {
            Console.WriteLine("How did I see the hand of the Lord in my life today?");
        } else if (number == 4)
        {
            Console.WriteLine("What was the strongest emotion I felt today?");
        } else 
        {
            Console.WriteLine("If I had one thing I could do over today, what would it be?");
        }
    }
    
}

