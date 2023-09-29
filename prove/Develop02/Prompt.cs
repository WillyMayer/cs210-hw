
using System;

public class Prompt
{   

    public int NumberGenerator()
    {
      Random randomGenerator = new Random();
      int number = randomGenerator.Next(1, 5);
      return number;
    }

    public string PromptGenerator()
    {
      string random = NumberGenerator().ToString();

            if (random == "1")
        {
           return "Who was the most interesting person I interacted with today?";
        } else if (random == "2")
        {
           return "What was the best part of my day?";
        } else if (random == "3")
        {
          return "How did I see the hand of the Lord in my life today?";
        } else if (random == "4")
        {
          return "What was the strongest emotion I felt today?";
        } else 
        {
          return "If I had one thing I could do over today, what would it be?";
        }
    }
} 

