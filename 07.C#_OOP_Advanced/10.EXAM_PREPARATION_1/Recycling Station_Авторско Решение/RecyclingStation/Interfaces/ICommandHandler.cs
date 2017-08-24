namespace RecyclingStation.Interfaces
{
    using RecyclingStation.WasteDisposal.Interfaces;

    public interface ICommandHandler
    {
        IGarbageProcessor GarbageProcessor { get; }

        IBalanceManager BalanceManager { get; }

        string ProcessGarbage(string[] parameters);

        string ChangeManagementRequirement(string[] parameters);

        string Status();
    }
}
