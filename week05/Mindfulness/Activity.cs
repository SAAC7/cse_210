using System;

class Activiy
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activiy(string _name, String _description)
    {
        this._name = _name;
        this._description = _description;
    }

    public virtual void StartActiviy()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine($"{_description}");
        Console.Write($"How Long, in secods, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get Ready ...");
        SpinnerAnimation(3);

    }
    public virtual void EndActivity()
    {
        Console.WriteLine("Well Done!!");
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        SpinnerAnimation(3);
    }

    public virtual void SpinnerAnimation(int seconds)
    {
        char[] spinner = new char[] { '|', '/', '-', '\\' };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write("\r" + spinner[i % spinner.Length]);
            Thread.Sleep(250);
        }
        Console.WriteLine();
    }
    public virtual void CountDownAnimation(int seconds)
    {
        int len = seconds.ToString().Length;
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            for (int j = 0 ; j< len;j++)
            {
                Console.Write("\b \b");
            }
        }
        Console.WriteLine();
    }
    public void Prueba()
    {
        CountDownAnimation(15);
        // SpinnerAnimation(15);
    }
}