public class SimpleGoal : Goal{
    public override int Complete()
    {
        Completed = true;
        return Value;
    }
}