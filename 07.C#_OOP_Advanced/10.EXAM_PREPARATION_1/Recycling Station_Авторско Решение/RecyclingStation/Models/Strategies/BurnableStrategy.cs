namespace RecyclingStation.Models.Strategies
{
    using RecyclingStation.WasteDisposal.Interfaces;

    public class BurnableStrategy : IGarbageDisposalStrategy
    {
        public IProcessingData ProcessGarbage(IWaste garbage)
        {
            var energyGained = (garbage.Weight * garbage.VolumePerKg) * 0.8;
            return new ProcessingData(energyGained, 0);
        }
    }
}
