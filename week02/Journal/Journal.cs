using System.IO;
public class Journal{
    List<Notes> _notes = new List<Notes>();
    public void CreateNote(){
        Console.WriteLine("");
        string question =Utilities.RandomQuestion();
        Console.WriteLine(question);
        string answer = Console.ReadLine();
        Console.WriteLine("");
        Notes note = new Notes(DateTime.Now,question,answer);
        _notes.Add(note);
    }
    public void Display(){
        if (_notes.Count > 0)
        {
            foreach (Notes note in _notes){
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
            foreach (Notes note in _notes){
            outputFile.WriteLine($"{note._theCurrentTime}|{note._question}|{note._answer}");
            }    
        }
        
    }
    public void LoadFromFile(string filename){
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines){
            string[]parts = line.Split('|');
            Notes note = new Notes(DateTime.Parse(parts[0]),parts[1],parts[2]);
            _notes.Add(note);
        }

    }
} 