public interface ICar
{
    string Color { get; }
    string Model { get; }

    string Start();
    string Stop();
}