public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;
    private string _type;

    public Event(string title, string description, string date, string time, string address, string type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
    }

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public string Date
    {
        get { return _date; }
        set { _date = value; }
    }

    public string Time
    {
        get { return _time; }
        set { _time = value; }
    }

    public string Address
    {
        get { return _address; }
        set { _address = value; }
    }

    public string Type
    {
        get { return _type; }
        set { _type = value; }
    }

    public string GenerateStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\nType: {_type}";
    }

    public string GenerateShortDetails()
    {
        return $"Type: {_type}\nTitle: {_title}\nDate: {_date}";
    }
}
