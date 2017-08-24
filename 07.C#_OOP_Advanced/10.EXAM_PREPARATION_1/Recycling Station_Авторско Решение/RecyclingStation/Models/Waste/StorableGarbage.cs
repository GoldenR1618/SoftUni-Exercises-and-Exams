namespace RecyclingStation.Models.Waste
{
    using RecyclingStation.Attributes;

    [Storable]
    public class StorableGarbage : Garbage
    {
        public StorableGarbage(string name, double weight, double volume) : base(name, weight, volume)
        {
        }
    }
}
