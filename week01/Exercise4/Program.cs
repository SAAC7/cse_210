using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> listnumbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (true)
        {
            Console.Write ("Enter a Number: ");
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                break;
            }
            listnumbers.Add(number);
        }
        if (listnumbers.Count>0)
        {
            int sum = 0;
            foreach (int number in listnumbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum is {sum}");
            float average = (float)sum / listnumbers.Count;
            Console.WriteLine($"The average is {average}");
            int max = listnumbers[0];
            int min = listnumbers[0];
            foreach (int number in listnumbers)
            {
                if (number > max)
                {
                    max = number;
                }
                if (number < min && number > 0)
                {
                    min = number;
                }
            }
            Console.WriteLine($"The Largest number is: {max}");
            Console.WriteLine($"The smallest positive number is: {min}");
            Console.WriteLine("The sorted list is:");
            listnumbers.Sort();
            foreach (int num in listnumbers)
            {
                Console.WriteLine(num);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}