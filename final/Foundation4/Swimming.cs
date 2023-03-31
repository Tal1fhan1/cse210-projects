public class Swimming: Activities
{
    private double _laps;

    public Swimming()
    {
    }
    public Swimming(double laps, string date, int duration): base(date, duration)
    {
        _laps = laps;
    }

    public double GetLaps()
    {
        return _laps;
    }
    public void SetLaps(double laps)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        double distance = _laps * 50/1000;
        return distance;
    }
    public override double CalculateSpeed()
    {
        double speed = (CalculateDistance() / GetDuration()) * 60;
        return speed;
    }
    public override double CalculatePace()
    {
        double pace = 60 / CalculateSpeed();
        return pace;
    }

}