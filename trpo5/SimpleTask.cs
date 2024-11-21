namespace trpo5;
public class SimpleTask
{
    public string Title { get; set; }
    public bool IsCompleted { get; set; }

    public override string ToString() => Title;
}
