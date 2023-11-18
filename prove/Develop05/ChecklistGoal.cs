public class ChecklistGoal : Goal{
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }
    public int BonusValue { get; set; }

    public override int Complete()
    {
        CurrentCount++;
        if (CurrentCount < TargetCount)
        {
            return Value;
        }
        else
        {
            Completed = true;
            return Value + BonusValue;
        }
    }
}