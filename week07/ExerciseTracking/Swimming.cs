using System;
namespace ExerciseTracking
{
    class Swimming:Activity
    {
        private int _laps;
    private const double _lapDistanceInMiles = 50.0 / 1000 * 0.62; // 50 meters in miles

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * _lapDistanceInMiles;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
    }
}