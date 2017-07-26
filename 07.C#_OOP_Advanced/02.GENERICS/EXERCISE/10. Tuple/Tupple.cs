public class Tupple<T1, T2>
{
    public Tupple(T1 first, T2 second)
    {
        this.First = first;
        this.Second = second;
    }

    public T1 First { get; }

    public T2 Second { get; }

    public override string ToString()
    {
        return $"{this.First.ToString()} -> {this.Second.ToString()}";
    }
}