public class Cycling: Activities
{
    private double _speed;

    public Cycling()
    {
    }
    public Cycling(double speed, string date, int duration): base(date, duration)
    {
        _speed = speed;
    }

    public double GetSpeed()
    {
        return _speed;
    }
    public void SetSpeed(double speed)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        double distance = (_speed / 60) * GetDuration();
        return distance;
    }
    public override double CalculatePace()
    {
        double pace = 60 / _speed;
        return pace;
    }

}