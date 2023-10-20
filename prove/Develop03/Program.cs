using System;

class Program
{
    static void Main(string[] args)
    {   
        int stopLoop = 1;

        while (stopLoop != 0)
        {
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