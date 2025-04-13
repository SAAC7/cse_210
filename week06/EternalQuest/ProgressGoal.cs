using System;
using System.ComponentModel;
namespace EternalQuest
{
  public class ProgressGoal : Goal
  {
   private int _targetValue,_currentValue,_milestoneInterval,_milestonePoints;

    public ProgressGoal(string name, string description, int points,int targetValue, int milestonePoints,int milestoneInterval):base(name,description,points)
    {
      _targetValue = targetValue;
      _milestonePoints=milestonePoints;
      _milestoneInterval=milestoneInterval;
      _currentValue=0;

    }
    public ProgressGoal(string name, string description, int points,int targetValue, int milestonePoints,int milestoneInterval, int currentValue)
    :base(name,description,points)
    {
      _targetValue = targetValue;
      _milestonePoints=milestonePoints;
      _milestoneInterval=milestoneInterval;
      _currentValue=currentValue;
      _isComplete = currentValue >= targetValue;

    }

    public override int RecordEvent()
    {
      Console.Write("Enter progress amount: ");
        int progress = int.Parse(Console.ReadLine());
        
        int previousMilestones = _currentValue / _milestoneInterval;
        _currentValue += progress;
        int currentMilestones = _currentValue / _milestoneInterval;
        
        int earnedPoints = 0;
        int milestonesAchieved = currentMilestones - previousMilestones;
        
        if (milestonesAchieved > 0)
        {
            earnedPoints = milestonesAchieved * _milestonePoints;
            Console.WriteLine($"You've reached {milestonesAchieved} milestone(s)! +{earnedPoints} points!");
        }
        
        if (!_isComplete && _currentValue >= _targetValue)
        {
            _isComplete = true;
            Console.WriteLine($"Goal completed! You've earned an additional {_points} points!");
            earnedPoints += _points;
        }
        
        return earnedPoints;
    }
    public override string GetDetailsString()
    {
      string mark = " ";
      if (_isComplete)
      {
        mark = "X";
      }

      return $"[{mark}] {_shortName} ({_description}) ----- Progress: {_currentValue}/{_targetValue}";
    }
    public override string GetStringRepresentation()
    {
      return $"ProgressGoal:{_shortName},{_description},{_points},{_targetValue},{_milestonePoints},{_milestoneInterval},{_currentValue}";
    }

  }
}
