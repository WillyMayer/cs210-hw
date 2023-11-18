using System;

class Program
{
    static void Main(string[] args)
    {
        displayWelcome();

        string nameUser = askingName();
        int numberUser = askingFavNumber();
        
        int squareUser = squareNumber(numberUser);

        displayResult(nameUser, squareUser);

    }
    static void displayWelcome()
       {
        Console.WriteLine("Welcome to the program!");
       }

   static string askingName()
       {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
       }

    static int askingFavNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string stringNumber = Console.ReadLine();
            int favNumber = int.Parse(stringNumber);

            return favNumber;
        }

    static int squareNumber(int favNumber)
        {
            int square = favNumber * favNumber;

            return square;
        }

    static void displayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    
}