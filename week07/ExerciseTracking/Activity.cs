using System;
namespace ExerciseTracking
{
    public abstract class Activity
    {
        private DateTime _date;
        private int _minutes;
        public Activity(DateTime date, int minutes)
        {
            _date = date;
            _minutes = minutes;
        }
        public DateTime GetDateTime() { return _date; }
        public int GetMinutes() { return _minutes; }

        public string GetSummary()
        {
            string dateString = _date.ToString("dd MMM yyyy");
            string activityType = GetType().Name;
            double distance = GetDistance();
            double speed = GetSpeed();
            double pace = GetPace();

            return $"{dateString} {activityType} ({_minutes} min): " +
                   $"Distance {distance:F1} miles, Speed: {speed:F1} mph, " +
                   $"Pace: {pace:F1} min per mile";
        }
        public abstract double GetDistance();
        // The speed (miles per hour or kilometers per hour)
        public abstract double GetSpeed();
        // The pace (minutes per mile or minutes per kilometer)
        public abstract double GetPace();


    }
}
