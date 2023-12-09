public class Cycling : Activity
{
    private float _speed;

    public Cycling(string date, float length, float speed) : base(date, length)
    {
        _speed = speed;
    }

    public override string CalculateDistance()
    {
        return $"{_speed * GetLength() / 60:F2} miles";
    }

    public override string CalculateSpeed()
    {
        return $"{_speed} mph";
    }

    public override string CalculatePace()
    {
        return $"{60 / _speed:F2} min per mile";
    }
}
