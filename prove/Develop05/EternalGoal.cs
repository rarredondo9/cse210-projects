public class EternalGoal : Goal{
    public override int Complete()
    {
        Value += Value;
        return Value;
    }
}