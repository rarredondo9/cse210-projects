using System;

public abstract class Activity
{
    private string _date;
    private float _length;

    public Activity(string date, float length)
    {
        _date = date;
        _length = length;
    }

    public string GetDate()
    {
        return _date;
    }

    public void SetDate(string date)
    {
        _date = date;
    }

    public float GetLength()
    {
        return _length;
    }

    public void SetLength(float length)
    {
        _length = length;
    }

    public abstract string CalculateDistance();
    public abstract string CalculateSpeed();
    public abstract string CalculatePace();

    public string GenerateSummary()
    {
        string distance = CalculateDistance();
        string speed = CalculateSpeed();
        string pace = CalculatePace();

        return $"{_date} {GetType().Name} ({_length} min) - Distance: {distance}, Speed: {speed}, Pace: {pace}";
    }
}
