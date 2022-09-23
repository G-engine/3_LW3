namespace task3;

public class Currency
{
    public double Value { get; set; }
    public override string ToString()
    {
        return Value.ToString("f2");
    }
}