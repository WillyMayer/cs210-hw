using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void Write()
    {
        Console.Write("Write your enter: ");
        string newEntry = Console.ReadLine();

        Entry entry = new Entry();

        //adding date
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        entry._entry = $"{dateText} - {newEntry}";

        _entries.Add(entry);
    }
    public void Display()
    {   

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        
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



