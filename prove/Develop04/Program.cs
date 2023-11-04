using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Menu menu = new Menu();
        menu.Presentation();
        menu.DisplayMenu();

        string stopLoop = "4";

        string option = "";

        while (option != stopLoop)
        {
            Console.WriteLine("");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();

            if (option == "1")
            {
                string nameActivity = "Breathing Activity";
                string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

                Console.Write("How long, in seconds, would you like for your session? ");
                int duration = Convert.ToInt32(Console.ReadLine());

                BreathingActivity breathingActivity = new BreathingActivity(nameActivity, description, duration);
                breathingActivity.RunActivity();

                menu.DisplayMenu();
            }
            else if (option == "2")
            {
                string nameActivity = "Reflecing Activity";
                string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                Console.Write("How long, in seconds, would you like for your session? ");
                int duration = Convert.ToInt32(Console.ReadLine());

                ReflectingActivity reflectingActivity = new ReflectingActivity(nameActivity, description, duration);
                reflectingActivity.RunActivity();

                menu.DisplayMenu();
            }
            else if (option == "3")
            {
                string nameActivity = "Listing Activity";
                string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                Console.Write("How long, in seconds, would you like for your session? "); int duration = Convert.ToInt32(Console.ReadLine());

                ListingActivity listingActivity = new ListingActivity(nameActivity, description, duration);
                listingActivity.RunActivity();

                menu.DisplayMenu();
            }
            else if (option == "4")
            {
                //Quit loop
            }

            else
            {
                Console.WriteLine("");
                Console.WriteLine("Please select a below option");
                Console.WriteLine("");
                menu.DisplayMenu();
            }
        }

    }
}