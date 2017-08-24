namespace RecyclingStation.Models.Waste
{
    using RecyclingStation.Attributes;

    [Burnable]
    public class BurnableGarbage : Garbage
    {
        public BurnableGarbage(string name, double weight, double volume) : base(name, weight, volume)
        {
        }
    }
}
