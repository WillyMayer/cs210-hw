using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        //Displaying menu
        Menu displayMenu = new Menu();
        displayMenu.Display();

        
        Journal journal = new Journal();

        //Stop loop
        string stopLoop = "5";
        //Select option
        string selectOption = "";

        //While loop
        while (stopLoop != selectOption)
        {   
            Console.Write("What would you like to do? ");
            selectOption = Console.ReadLine();

            if (selectOption == "1")
            {   
                Entry entry = new Entry();
                entry._entry = Console.ReadLine();
                journal._entries.Add(entry);
                
                
            } else if (selectOption == "2")
            {
                journal.Display();

                //displayMenu.Display();
            } else if (selectOption == "3")
            {
                //codeline

                displayMenu.Display();
            } else if (selectOption == "4")
            {

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