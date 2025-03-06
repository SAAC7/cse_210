using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favorite = int.Parse(Console.ReadLine());
        return favorite;
    }
    static int SquareNumber(int number)
    {
        return number*number;
    }
    // DisplayResult - Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string name, int square)
    {
    Console.WriteLine($"{name}, the square of your number is {square}");
    }

}