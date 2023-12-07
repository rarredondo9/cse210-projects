public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time, string address, string type, string weather)
        : base(title, description, date, time, address, type)
    {
        _weather = weather;
    }

    public string Weather
    {
        get { return _weather; }
        set { _weather = value; }
    }

    public string GenerateFullDetails()
    {
        string baseDetails = GenerateStandardDetails();
        return $"{baseDetails}\nWeather: {_weather}";
    }
}
