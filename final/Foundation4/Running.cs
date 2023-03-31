public class Running: Activities
{
    private double _distance;

    public Running()
    {
    }
    public Running(double distance, string date, int duration): base(date, duration)
    {
        _distance = distance;
    }

    public double GetDistance()
    {
        return _distance;
    }
    public void SetDistance(double distance)
    {
        _distance = distance;
    }

    public override double CalculateSpeed()
    {
        double speed = (_distance / GetDuration()) * 60;
        return speed;
    }
    public override double CalculatePace()
    {
        double pace = GetDuration() / _distance;
        return pace;
    }

}