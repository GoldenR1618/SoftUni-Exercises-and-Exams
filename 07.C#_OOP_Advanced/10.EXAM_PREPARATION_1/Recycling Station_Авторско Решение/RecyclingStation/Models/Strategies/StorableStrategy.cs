namespace RecyclingStation.Models.Strategies
{
    using RecyclingStation.WasteDisposal;
    using RecyclingStation.WasteDisposal.Interfaces;

    public class StorableStrategy : IGarbageDisposalStrategy
    {
        public IProcessingData ProcessGarbage(IWaste garbage)
        {
            var spending = (garbage.Weight * garbage.VolumePerKg) * 0.65;
            var energyCost = (garbage.Weight * garbage.VolumePerKg) * 0.13;
            return new ProcessingData(0 - energyCost, 0 - spending);
        }
    }
}
