using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
            Console.WriteLine(assignment.GetSummariy());
            MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
            Console.WriteLine(mathAssignment.GetSummariy());      
            Console.WriteLine(mathAssignment.GetHomeworkList());  
            WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
            Console.WriteLine(writingAssignment.GetSummariy());           
            Console.WriteLine(writingAssignment.GetWritingInformation());
        }
    }
}
