using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

public class Journal
{   
    public List<Entry> journal = new List<Entry>();

    public void Write()
    {   
        Prompt prompts = new Prompt();
        string randomPrompt = prompts.PromptGenerator();
        Console.WriteLine(randomPrompt);

        Console.Write("> ");
        string newEntry = Console.ReadLine();

        //adding date
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Entry newPrompt = new Entry();
        Entry entry = new Entry();
        Entry blank = new Entry();

        
        newPrompt._entry = $"{dateText} - Prompt: {randomPrompt}";
        entry._entry = $"{newEntry}";
        blank._entry = "";

        journal.Add(newPrompt);
        journal.Add(entry);
        journal.Add(blank);
    }
    public void Display()
    {   

        foreach (Entry entry in journal)
        {
            entry.Display();
            Console.WriteLine("");
        }
    
    }

    public void SaveToFile()
    {   
        Console.WriteLine("What is the filename?");
        Console.Write("> ");
        string filename = Console.ReadLine();

        Console.WriteLine("Journal saved");

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in journal)
            {    
            outputFile.WriteLine($"{entry._entry}");
            }
        }
    }
       
    public void ReadFile()
    {   
        Console.WriteLine("What is the filename? ");
        Console.Write("> ");

        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);

         foreach (string line in lines)
            { 
            Entry entry = new Entry();
            entry._entry = line;
            journal.Add(entry);
            }

        Console.WriteLine("Entries loaded");
 
    }

}



