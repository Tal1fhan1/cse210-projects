public class Outdoor: Event
{
    private string _weatherConditions;

    public Outdoor()
    {
    }
    public Outdoor(string weatherConditions, string title, string description, string date, string time, string address): base(title, description, date, time, address)
    {
        _weatherConditions = weatherConditions;
    }

    public string GetWeatherConditions()
    {
        return _weatherConditions;
    }
    public void SetWeatherConditions(string weatherConditions)
    {
        _weatherConditions = weatherConditions;
    }

}