public class Running : Activity
{
    private float _distance;

    public Running(string date, float length, float distance) : base(date, length)
    {
        _distance = distance;
    }

    public override string CalculateDistance()
    {
        return $"{_distance} miles";
    }

    public override string CalculateSpeed()
    {
        return $"{_distance / GetLength() * 60:F2} mph";
    }

    public override string CalculatePace()
    {
        return $"{GetLength() / _distance:F2} min per mile";
    }
}
