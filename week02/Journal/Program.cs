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
            int option = Menu();
            switch (option)
            {
                case 1:
                    _journal.CreateEntry();
                    break;
                case 2:
                    Console.WriteLine();
                    _journal.DisplayAll();
                    break;
                case 3:
                    Console.WriteLine("Type the name of the file to Upload");
                    filename = Console.ReadLine();
                    _journal.LoadFromFile(filename);
                    break;
                case 4:
                    Console.WriteLine("Type the name to save the file");
                    filename = Console.ReadLine();
                    _journal.SaveToFile(filename);
                    break;
                case 5:
                    bool exitPromptMenu = false;
                    while (!exitPromptMenu)
                    {
                        int optionPrompt = MenuPrompt();
                        switch (optionPrompt)
                        {
                            case 1:
                                Console.WriteLine("Write your new prompt");
                                string resp = Console.ReadLine();
                                Utilities.AddPrompt(resp);
                                exitPromptMenu = true;
                                break;
                            case 2:
                                Console.WriteLine("Your prompts are: ");
                                for (int i = 0; i < Utilities.Count(); i++)
                                {
                                    Console.WriteLine($"{i + 1}. {Utilities.Prompt(i)}");
                                }
                                while (true)
                                {
                                    try
                                    {
                                        Console.Write("Select an option (number): ");
                                        int respa = int.Parse(Console.ReadLine());
                                        if (respa - 1 >= 0 && respa - 1 < Utilities.Count())
                                        {
                                            Utilities.RemovePrompt(respa - 1);
                                            exitPromptMenu = true;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Select a correct option");
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("Select a correct option");
                                    }
                                }
                                break;
                            case 3:
                                exitPromptMenu = true;
                                break;
                            default:
                                Console.WriteLine("Select a correct option");
                                break;
                        }
                    }
                    break;
                case 6:
                    return; 
                default:
                    Console.WriteLine("Select a correct option");
                    break;
            }
        }
    }

    static int Menu()
    {
        Console.WriteLine("\n\nWelcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Edit Prompts");
        Console.WriteLine("6. Quit");
        Console.Write("Option: ");
        do
        {
            try
            {
                int respuesta = int.Parse(Console.ReadLine());
                return respuesta;
            }
            catch (Exception)
            {
                Console.WriteLine("Select a correct option");
            }
        } while (true);
    }

    static int MenuPrompt()
    {
        Console.WriteLine("\nWhat would you like to do?");
        Console.WriteLine("1. Add a new prompt");
        Console.WriteLine("2. Delete a prompt");
        Console.WriteLine("3. Back to Menu");
        do
        {
            try
            {
                int respuesta = int.Parse(Console.ReadLine());
                return respuesta;
            }
            catch (Exception)
            {
                Console.WriteLine("Select a correct option");
            }
        } while (true);
    }
}
