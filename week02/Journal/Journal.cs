using System.IO;
public class Journal
{
    List<Entry> _entries = new List<Entry>();
    public void CreateEntry()
    {
        Console.WriteLine("");
        string prompt = Utilities.RandomQuestion();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your anwer: ");
        string answer = Console.ReadLine();
        Console.WriteLine("");
        Entry entry = new Entry(DateTime.Now, prompt, answer);
        _entries.Add(entry);
    }
    public void DisplayAll()
    {
        if (_entries.Count > 0)
        {
            foreach (Entry note in _entries)
            {
                note.Display();
            }
        }
        else
        {
            Console.WriteLine("\nFirst you have to add a note\n");
        }

    }

    public void SaveToFile(string filename)
    {
        // In this method i develop the part to save the list of prompts because i adda the method to add new prompts
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"entry|{entry._date}|{entry._prompt}|{entry._entryText}");
            }
            for (int i = 0;i < Utilities.Count(); i++)
            {
                outputFile.WriteLine($"prompt|{Utilities.Prompt(i)}");
            }

            Console.WriteLine($"Your data has been saved in {filename}");
        }

    }
    public void LoadFromFile(string filename)
    {
        // int this method i implement to load the list of prompts 
        if (System.IO.File.Exists(filename))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            Utilities.EmptyData();
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts[0]=="entry")
                {
                Entry entry = new Entry(DateTime.Parse(parts[1]), parts[2], parts[3]);
                _entries.Add(entry);
                }
                if (parts[0]=="prompt")
                {
                    Utilities.AddPrompt(parts[1]);
                }
                
            }
            Console.WriteLine("Your Journal has been updated");
        }
        else
        {
            Console.WriteLine($"The file {filename} doesn't exist");
        }


    }
}