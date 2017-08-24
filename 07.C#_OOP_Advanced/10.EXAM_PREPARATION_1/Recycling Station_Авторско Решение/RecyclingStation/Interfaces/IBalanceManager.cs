namespace RecyclingStation.Interfaces
{
    using RecyclingStation.WasteDisposal.Interfaces;

    public interface IBalanceManager
    {
        double EnergyBalance { get; }

        double CapitalBalance { get; }

        IManagementRequirement ManagmentRequirement { get; set; }

        void ApplyProcessingResult(IProcessingData result);

        bool CheckWasteForProcessing(IWaste waste);
    }
}
