using System;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals;
        private int _score, _level, _experienceToNextLevel;

        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
            _level = 1;
            _experienceToNextLevel = 1000;
        }
        public void DisplayGoals()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("You don't have any goals yet.");
                return;
            }
            Console.WriteLine("Your Goals:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");

            }
        }
        public void RecordEvent()
        {
            DisplayGoals();
            if (_goals.Count == 0)
            {
                return;
            }
            Console.WriteLine("Which goal did you accomplish? ");
            int goalIndex = int.Parse(Console.ReadLine()) - 1;

            if (goalIndex >= 0 && goalIndex < _goals.Count)
            {
                int pointsEarned = _goals[goalIndex].RecordEvent();
                _score += pointsEarned;
                if (pointsEarned > 0)
                {
                    CheckForLevelUp();
                }
            }
            else
            {
                Console.WriteLine("Invalid goal number.");
            }
        }

        private void CheckForLevelUp()
        {
            while (_score >= _experienceToNextLevel)
            {
                _level++;
                Console.WriteLine($"\n*** LEVEL UP! ***");
                Console.WriteLine($"You are now a Level {_level} Eternal Quester!");

                _experienceToNextLevel += (int)(_experienceToNextLevel * 0.5);
                Console.WriteLine($"Next Level at {_experienceToNextLevel} points");

                int levelBonus = _level * 100;
                _score += levelBonus;
                Console.WriteLine($"Level-up bonus: +{levelBonus} ponts!");

            }
        }
        public void DisplayScore()
        {
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine($"Current Leel: {_level}");
            Console.WriteLine($"Progress to next level: {_score}/{_experienceToNextLevel}");
        }

        public void CreateGoal()
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("4. Progress Goal");

            Console.Write("Which type of goal would you like to create? ");
            string goalType = Console.ReadLine();

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            Goal newGoal;
            switch (goalType)
            {
                case "1": // Simple Goal
                    newGoal = new SimpleGoal(name, description, points);
                    break;
                case "2": // Eternal Goal
                    newGoal = new EternalGoal(name, description, points);
                    break;
                case "3": // Checklist Goal
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());
                    newGoal = new ChecklistGoal(name, description, points, target, bonus);
                    break;
                case "4": // Progress Goal
                    Console.Write("What is the target value to complete this goal? ");
                    int targetValue = int.Parse(Console.ReadLine());
                    Console.Write("How many points for each milestone? ");
                    int milestonePoints = int.Parse(Console.ReadLine());
                    Console.Write("How much progress constitutes a milestone? ");
                    int milestoneInterval = int.Parse(Console.ReadLine());
                    newGoal = new ProgressGoal(name, description, points, targetValue, milestonePoints, milestoneInterval);
                    break;
                default:
                    Console.WriteLine("Invalid goal type.");
                    return;
            }

            _goals.Add(newGoal);
            Console.WriteLine("Goal created successfully!");
        }
        public void SaveGoals()
        {
            Console.Write("What is the filename for the goal file? ");
            string filename = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                // First line: Score and level info
                outputFile.WriteLine($"{_score},{_level},{_experienceToNextLevel}");

                // Each goal on its own line
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }

            Console.WriteLine("Goals saved successfully!");
        }

        public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();

        string[] lines = File.ReadAllLines(filename);

        string[] scoreInfo = lines[0].Split(",");
        _score = int.Parse(scoreInfo[0]);
        _level = int.Parse(scoreInfo[1]);
        _experienceToNextLevel = int.Parse(scoreInfo[2]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(":", 2);
            
            if (parts.Length < 2)
                continue;
                
            string goalType = parts[0];
            string goalData = parts[1];
            string[] goalParts = goalData.Split(",");

            Goal goal = null;

            switch (goalType)
            {
                case "SimpleGoal":
                    goal = new SimpleGoal(
                        goalParts[0],
                        goalParts[1],
                        int.Parse(goalParts[2]),
                        bool.Parse(goalParts[3])
                    );
                    break;
                case "EternalGoal":
                    goal = new EternalGoal(
                        goalParts[0],
                        goalParts[1],
                        int.Parse(goalParts[2])
                    );
                    break;
                case "ChecklistGoal":
                    goal = new ChecklistGoal(
                        goalParts[0],
                        goalParts[1],
                        int.Parse(goalParts[2]),
                        int.Parse(goalParts[3]),
                        int.Parse(goalParts[4]),
                        int.Parse(goalParts[5])
                    );
                    break;
                case "ProgressGoal":
                    goal = new ProgressGoal(
                        goalParts[0],
                        goalParts[1],
                        int.Parse(goalParts[2]),
                        int.Parse(goalParts[3]),
                        int.Parse(goalParts[4]),
                        int.Parse(goalParts[5]),
                        int.Parse(goalParts[6])
                    );
                    break;
                default:
                    Console.WriteLine($"Unknown goal type: {goalType}");
                    break;
            }

            if (goal != null)
            {
                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully!");
    }
    }
}