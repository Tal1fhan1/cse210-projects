public class Activities
{
    private string _date;
    private int _duration;

    public Activities()
    {
    }
    public Activities(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public string GetDate()
    {
        return _date;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public virtual double CalculateDistance()
    {
        return 0;
    }
    public virtual double CalculateSpeed()
    {
        return 0;
    }
    public virtual double CalculatePace()
    {
        return 0;
    }
    public string GetSummary(string activityType, double distance, double speed, double pace)
    {
        return $"{_date} {activityType} ({_duration} min) - Distance: {double.Round(distance, 1)} km, Speed: {double.Round(speed, 1)} kph, Pace: {double.Round(pace, 1)} min per km";
    }
}