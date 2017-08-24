namespace RecyclingStation.Models.Strategies
{
    using RecyclingStation.WasteDisposal;
    using RecyclingStation.WasteDisposal.Interfaces;

    public class RecyclableStrategy : IGarbageDisposalStrategy
    {
        public IProcessingData ProcessGarbage(IWaste garbage)
        {
            var usedEnergy = (garbage.Weight * garbage.VolumePerKg) / 2;
            var income = garbage.Weight * 400;
            return new ProcessingData(0 - usedEnergy, income);
        }
    }
}
