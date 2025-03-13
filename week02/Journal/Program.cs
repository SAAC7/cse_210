using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Journal _journal = new Journal();
        Console.WriteLine(Utilities.RandomQuestion());
        string filename;
        while (true)
        {
            int option = Menu() ;
        switch (option)
        {
            case 1:
                _journal.CreateNote();
                break;
            case 2:
                _journal.Display();
                break;
            case 3:
                Console.WriteLine("Write the filename");
                filename = Console.ReadLine();
                _journal.LoadFromFile(filename);
                break;
            case 4:
                Console.WriteLine("Write the filename");
                filename = Console.ReadLine();
                _journal.SaveToFile(filename);
                break;
            case 5:
                break;
        }
        if (option == 5)
        {
            break;
        }
        }
        
       
    }

    static int Menu(){
        Console.WriteLine("\n\nWelcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("Option: ");
        
        do
        {
             try
        {
            int respuesta = int.Parse(Console.ReadLine());
            return respuesta;
        }
        catch (System.Exception)
        {
            Console.WriteLine("Select a correct option");
        }
        } while (true);
       
        
    }
}