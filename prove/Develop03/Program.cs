using System;

class Program
{
    static void Main(string[] args)
    {   
        int stopLoop = 1;

        Reference references = new Reference("John", "17:3 ", "");
        Scripture scripture = new Scripture(references, "For behold thus saith the Lord I will liken thee O house of Israel like unto a tame olive tree which a man took and nourished in his vineyard and it grew and waxed old and began to decay");

        while (stopLoop != 0)
        {   
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");

            string next = Console.ReadLine();

            if (next != "quit")
            {
                //scripture.HideRandomWords();
                //Console.WriteLine(scripture.GetDisplayText());
            }

            else if (next == "quit")
            {
                stopLoop = 0;
            }

            //if (scripture.IsHidden())
            /*
            StopLoop = 0;
            */
        }
    }
}