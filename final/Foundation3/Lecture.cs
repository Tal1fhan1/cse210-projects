public class Lecture: Event
{
    private string _speaker;
    private int _capacityLimit;

    public Lecture()
    {
    }
    public Lecture(string speaker, int capacityLimit, string title, string description, string date, string time, string address): base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacityLimit = capacityLimit;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }
    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }
    public int GetCapacityLimit()
    {
        return _capacityLimit;
    }
    public void SetCapacityLimit(int capacityLimit)
    {
        _capacityLimit = capacityLimit;
    }
}