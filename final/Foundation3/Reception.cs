public class Reception: Event
{
    private string _rsvpEmail;

    public Reception()
    {
    }
    public Reception(string rsvpEmail, string title, string description, string date, string time, string address): base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public string GetRSVPEmail()
    {
        return _rsvpEmail;
    }
    public void SetRSVPEmail(string rsvpEmail)
    {
        _rsvpEmail = rsvpEmail;
    }
}