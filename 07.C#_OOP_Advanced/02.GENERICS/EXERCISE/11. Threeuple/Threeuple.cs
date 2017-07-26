public class Threeuple<T1, T2, T3>
{
    public Threeuple(T1 first, T2 second, T3 third)
    {
        this.First = first;
        this.Second = second;
        this.Third = third;
    }

    public T1 First { get; }

    public T2 Second { get; }

    public T3 Third { get; }

    public override string ToString()
    {
        return $"{this.First} -> {this.Second} -> {this.Third}";
    }
}