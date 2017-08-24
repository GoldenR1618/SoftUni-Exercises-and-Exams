namespace RecyclingStation.WasteDisposal.Interfaces
{
    /// <summary>
    /// Interface that should be implemented by Garbage Disposal Strategies.
    /// </summary>
    public interface IGarbageDisposalStrategy
    {
        /// <summary>
        /// Processes a passed in IWaste object and returns an IProcessingData object containing all information about the results of the operation.
        /// </summary>
        /// <param name="garbage">An IWaste object representing the garbage to be processed.</param>
        /// <returns>Return an IProcessingData object containing all information about the results of processing the waste.</returns>
        IProcessingData ProcessGarbage(IWaste garbage);
    }
}
