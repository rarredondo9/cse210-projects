public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, float length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override string CalculateDistance()
    {
        float distanceKm = _laps * 50 / 1000;
        return $"{distanceKm:F2} km";
    }

    public override string CalculateSpeed()
    {
        float distanceMiles = _laps * 50 / 1000 * 0.62f;
        return $"{distanceMiles / GetLength() * 60:F2} mph";
    }

    public override string CalculatePace()
    {
        float distanceKm = _laps * 50 / 1000;
        return $"{GetLength() / distanceKm:F2} min per km";
    }
}
