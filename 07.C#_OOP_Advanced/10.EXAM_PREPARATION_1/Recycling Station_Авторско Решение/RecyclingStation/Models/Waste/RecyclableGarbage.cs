namespace RecyclingStation.Models.Waste
{
    using RecyclingStation.Attributes;

    [Recyclable]
    public class RecyclableGarbage : Garbage
    {
        public RecyclableGarbage(string name, double weight, double volume) : base(name, weight, volume)
        {
        }
    }
}
