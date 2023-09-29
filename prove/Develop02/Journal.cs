using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

public class Journal
{   
    public List<Prompt> _prompts = new List<Prompt>();
    public List<Entry> _entries = new List<Entry>();

    public void Write()
    {   
        Prompt prompts = new Prompt();
        string randomNumber = prompts.PromptGenerator();

        Console.Write("> ");
        string newEntry = Console.ReadLine();

        //adding date
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Entry newPrompt = new Entry();
        Entry entry = new Entry();
        
        newPrompt._entry = $"{dateText} - Prompt: {prompts.PromptGenerator()}";
        entry._entry = $" {newEntry}";

        _entries.Add(newPrompt);
        _entries.Add(entry);
    }
    public void Display()
    {   

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        Console.WriteLine();
    }

    public void SaveToFile()
    {   
        Console.WriteLine("Journal saved");
        string filename = "entries.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {    
            outputFile.WriteLine($"{entry._entry}");
            }
        }
    }
       
    public void ReadFile()
    {   
        Console.WriteLine("Entries loaded");
        string filename = "entries.txt";
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        { 
            Entry entry = new Entry();
            entry._entry = line;
            _entries.Add(entry);
        }
    }

}



