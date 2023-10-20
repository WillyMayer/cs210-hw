using System;

class Program
{
    static void Main(string[] args)
    {   
        int stopLoop = 1;
    
        Reference references = new Reference("John", "14", "27");
        Scripture scripture = new Scripture(references, "Peace I leave with you, my peace I give unto you: not as the world giveth, give I unto you. Let not your heart be troubled, neither let it be afraid.");

        //Exceeding requirements
        //Start the program with a welcome message 
        Console.Clear();
        Welcome welcome = new Welcome();
        welcome.WelcomeMessage();
        Console.ReadLine();
        
        while (stopLoop != 0)
        {   
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");

            string next = Console.ReadLine();

            if (next != "quit")
            {
                Random random = new Random();
                int number = random.Next(3, 5);
                scripture.HideWords(number);
                Console.WriteLine(scripture.GetDisplayText());
            }

            else if (next == "quit")
            {
                stopLoop = 0;
            }

            if (scripture.IsHidden())
            {
                Console.WriteLine();
                Console.WriteLine("Congrats! Press enter to finish.");
                Console.ReadLine();
                stopLoop = 0;
            }    
        }
    }
}