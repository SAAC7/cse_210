using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string name,lastname;
        name = text_toTitle("What is your first name?");
        lastname = text_toTitle("What is your last name?");
        Console.WriteLine($"Your name is {lastname}, {name} {lastname}.");
        
        
    }
    static string text_toTitle(string text)
    {
        Console.Write(text+" ");
        string get_text = Console.ReadLine();
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        return textInfo.ToTitleCase(get_text.ToLower());
    }
}