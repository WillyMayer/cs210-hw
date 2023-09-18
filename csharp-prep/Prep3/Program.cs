using System;

class Program
{
    static void Main(string[] args)
    { 
         int restart = 1; 

        while (restart == 1) {
                 
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 20);

        Console.WriteLine($"What is the magic number? {number}");

        int numberGuess = 0;

            while (number != numberGuess) 
            {
             Console.Write($"What if your guess? ");
             numberGuess = int.Parse(Console.ReadLine());

             if (numberGuess > number) {
                Console.WriteLine("Lower");
             } else if (numberGuess < number) {
                Console.WriteLine("Higher");
             } else {
                Console.WriteLine("That's it!");
             }
            }
         
         Console.Write("Would you like to continue? (Yes = 1 / No = 0) ");
         restart = int.Parse(Console.ReadLine());

    }
    }
}