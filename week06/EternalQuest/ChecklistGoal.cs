using System;

namespace EternalQuest
{
    class ChecklistGoal : Goal
    {
        private int _amountCOmpleted, _target, _bonus;
        public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
        {
            _amountCOmpleted = 0;
            _target = target;
            _bonus = bonus;
        }
        public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCOmpleted) : base(name, description, points)
        {
            _amountCOmpleted = amountCOmpleted;
            _target = target;
            _bonus = bonus;
            _isComplete = amountCOmpleted >= target;
        }

        public override int RecordEvent()
        {
            if (_amountCOmpleted < _target)
            {
                _amountCOmpleted++;
                if (_amountCOmpleted >= _target)
                {
                    _isComplete = true;
                    Console.WriteLine($"Congratulations! You have earned {_points} points plus a bonus of {_bonus} points!");
                    return _points + _bonus;
                }
                else
                {
                    Console.WriteLine($"Congratulations! You have earned {_points} points!");
                    return _points;
                }
            }
            else
            {
                Console.WriteLine("This goal has already been completed.");
                return 0;
            }
        }
        public override string GetDetailsString()
        {
            string mark =" ";
            if (_isComplete)
            {
                mark = "X";
            }
            return $"[{mark}] {_shortName} ({_description}) ..... Completed {_amountCOmpleted}/{_target} times";
        }
        public override string GetStringRepresentation()
        {
            return $"ChecklistGoal:{_shortName},{_description},{_points},{_target},{_bonus},{_amountCOmpleted}";
        }

    }
}