namespace RecyclingStation.Models.Waste
{
    using RecyclingStation.WasteDisposal.Interfaces;

    public abstract class Garbage : IWaste
    {
        protected Garbage(string name, double weight, double volumePerKg)
        {
            this.Name = name;
            this.Weight = weight;
            this.VolumePerKg = volumePerKg;
        }

        public string Name { get; private set; }

        public double VolumePerKg { get; private set; }

        public double Weight { get; private set; }
    }
}
