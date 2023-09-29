
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




/*public void RandomPrompts()
    {
        int RandomNumber(){

          int number = randomGenerator.Next(1, 5);
          return number;
        } 

        string PromptGenerator(number)
    {
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
        */