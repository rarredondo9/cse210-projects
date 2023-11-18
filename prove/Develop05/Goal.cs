public class Goal
{
    public string Name { get; set; }
    public int Value { get; set; }
    public bool Completed { get; set; }

    public virtual int Complete()
    {
        Completed = true;
        return Value;
    }
}