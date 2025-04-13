using System;
namespace EternalQuest
{
  public abstract class Goal
  {
    protected string _shortName, _description;
    protected int _points;
    protected bool _isComplete;

    public Goal(string name, string description, int points)
    {
      _shortName = name;
      _description = description;
      _points = points;
      _isComplete = false;
    }
    public abstract int RecordEvent();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();

  }
}
