using System.IO;
public class Journal{
    List<Entry> _entrys = new List<Entry>();
    public void CreateNote(){
        Console.WriteLine("");
        string question =Utilities.RandomQuestion();
        Console.WriteLine(question);
        string answer = Console.ReadLine();
        Console.WriteLine("");
        Entry entry = new Entry(DateTime.Now,question,answer);
        _entrys.Add(entry);
    }
    public void Display(){
        if (_entrys.Count > 0)
        {
            foreach (Entry note in _entrys){
            note.DisplayNote();
            }
        }
        else
        {
            Console.WriteLine("\nFirst you have to add a note\n");
        }
        
    }

    public void SaveToFile(string filename){
        using (StreamWriter outputFile = new StreamWriter(filename))    
        {
            foreach (Entry entry in _entrys){
            outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._entryText}");
            }    
        }
        
    }
    public void LoadFromFile(string filename){
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines){
            string[]parts = line.Split('|');
            Entry entry = new Entry(DateTime.Parse(parts[0]),parts[1],parts[2]);
            _entrys.Add(entry);
        }

    }
} 