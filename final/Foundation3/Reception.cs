public class Reception : Event
{
    private string _email;

    public Reception(string title, string description, string date, string time, string address, string type, string email)
        : base(title, description, date, time, address, type)
    {
        _email = email;
    }

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }

    public string GenerateFullDetails()
    {
        string baseDetails = GenerateStandardDetails();
        return $"{baseDetails}\nEmail: {_email}";
    }
}
