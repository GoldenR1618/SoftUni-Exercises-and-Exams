namespace RecyclingStation.Core
{
    using RecyclingStation.Interfaces;
    using RecyclingStation.WasteDisposal.Interfaces;

    public class BalanceManager : IBalanceManager
    {
        public BalanceManager()
        {
            this.EnergyBalance = 0;
            this.CapitalBalance = 0;
            this.ManagmentRequirement = null;
        }

        public double EnergyBalance { get; private set; }

        public double CapitalBalance { get; private set; }

        public IManagementRequirement ManagmentRequirement { get; set; }

        public void ApplyProcessingResult(IProcessingData result)
        {
            this.EnergyBalance += result.EnergyBalance;
            this.CapitalBalance += result.CapitalBalance;
        }

        public bool CheckWasteForProcessing(IWaste waste)
        {
            if (this.ManagmentRequirement == null)
            {
                return true;
            }

            return this.ManagmentRequirement.CheckWasteForProcessing(this.EnergyBalance, this.CapitalBalance, waste);
        }
    }
}
