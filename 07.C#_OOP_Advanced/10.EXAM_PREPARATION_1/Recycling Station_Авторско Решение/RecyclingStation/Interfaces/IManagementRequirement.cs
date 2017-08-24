namespace RecyclingStation.Interfaces
{
    using System;
    using RecyclingStation.WasteDisposal.Interfaces;

    public interface IManagementRequirement
    {
        double MinEnergyBalance { get; }

        double MinCapitalBalance { get; }

        Type BannedWasteType { get; }

        bool CheckWasteForProcessing(double currentEnergyBalance, double currentCapitalBalance, IWaste bannedWaste);
    }
}
