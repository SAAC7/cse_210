using System;
namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points) : base(name, description, points)
        { }
        public override int RecordEvent()
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            return _points;
        }
        public override string GetDetailsString()
        {
            return $"[ ] {_shortName} ({_description})";
        }
        public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
    }

}