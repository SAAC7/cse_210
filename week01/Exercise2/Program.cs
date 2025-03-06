using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int percentage = int.Parse(Console.ReadLine());
        string lettergrade;
        if (percentage >= 90)
        {
            lettergrade="A";
        }
        else if (percentage >= 80)
        {
            lettergrade="B";
        }
        else if (percentage >= 70)
        {
            lettergrade="C";
        }
        else if (percentage >= 60)
        {
            lettergrade="D";
        }
        else
        {
            lettergrade="F";
        }
        int modnumber = percentage%10;
        string sign="";
        if (lettergrade != "A" && lettergrade != "F")
        {
            if (modnumber >= 7 ){
                sign = "+";
            } 
            else if (modnumber < 3)
            {
                sign = "-";
            }
        }
        else if (lettergrade == "A" && percentage < 93 )
        {
            sign = "-";
        }

        Console.WriteLine($"Your grade is: {sign}{lettergrade}");
        
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations, You passed!");
        }
        else
        {
            Console.WriteLine("Good luck next time!");
        }



    }
}