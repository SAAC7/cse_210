using System;
namespace EternalQuest
{

    public class SimpleGoal : Goal
    {
        public SimpleGoal(string name, string description, int points) : base(name, description, points)
        {
        }
        public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
        {
            _isComplete = isComplete;
        }
        public override int RecordEvent()
        {
            if (!_isComplete)
            {
                _isComplete = true;
                Console.WriteLine($"Congratulations! You have earned {_points} points!");
                return _points;
            }
            else
            {
                Console.WriteLine("This goal has already been completed.");
                return 0;
            }
        }
        public override string GetDetailsString()
        {
            string mark = " ";
            if (_isComplete)
            {
                mark = "X";
            }
            return $"[{mark}] {_shortName} ({_description})";
        }
        public override string GetStringRepresentation()
        {

            return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
        }


    }
}