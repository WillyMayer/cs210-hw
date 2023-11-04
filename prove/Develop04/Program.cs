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

        Console.WriteLine("");
        Console.Write("What do you like to do? ");
        string option = Console.ReadLine();

        while (option != stopLoop)
        {
            if (option == "1")
            {
                string nameActivity = "Breathing Activity";
                string description = "This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on breathing.";

                Console.Write("How long, in seconds, would you like for your session? ");
                int duration = Convert.ToInt32(Console.ReadLine());

                BreathingActivity breathingActivity = new BreathingActivity(nameActivity, description, duration);
                breathingActivity.RunActivity();

            }
            else if (option == "2")
            {
                string nameActivity = "Reflecing Activity";
                string description = "This activity will hep you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                Console.Write("How long, in seconds, would you like for your session? ");
                int duration = Convert.ToInt32(Console.ReadLine());

                ReflectingActivity reflectingActivity = new ReflectingActivity(nameActivity, description, duration);
                reflectingActivity.RunActivity();
            }
            else if (option == "3")
            {
                string nameActivity = "Listing Activity";
                string description = "This activity will help you reflect on the good things on your life by having you list as many things as you can in a certain area";
                Console.Write("How long, in seconds, would you like for your session? "); int duration = Convert.ToInt32(Console.ReadLine());

                ListingActivity listingActivity = new ListingActivity(nameActivity, description, duration);
                listingActivity.RunActivity();
            }
            else if (option == "4")
            {
                //Quit loop
            }
        }

    }
}