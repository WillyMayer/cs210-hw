using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        //while loop
        Menu displayMenu = new Menu();
        displayMenu.Display();

        string stopLoop = "5";
        string selectOption = "";
        //Selecting option

        while (stopLoop != selectOption)
        {   
            Console.Write("What would you like to do? ");
            selectOption = Console.ReadLine();

            if (selectOption == "1")
            {
                //codeline

                displayMenu.Display();
            } else if (selectOption == "2")
            {
                //codeline

                displayMenu.Display();
            } else if (selectOption == "3")
            {
                //codeline

                displayMenu.Display();
            } else if (selectOption == "4")
            {
               //codeline

                displayMenu.Display();
            } else if (selectOption == "5") 
            {
                //Quit loop
            } else
            {   
                Console.WriteLine("Please select a below option");
                displayMenu.Display();
            }

        }
        
    }
}