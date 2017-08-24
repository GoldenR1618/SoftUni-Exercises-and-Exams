namespace RecyclingStation.WasteDisposal
{
    using System;
    using System.Linq;
    using RecyclingStation.WasteDisposal.Attributes;
    using RecyclingStation.WasteDisposal.Interfaces;

    public class GarbageProcessor : IGarbageProcessor
    {
        public GarbageProcessor(IStrategyHolder strategyHolder)
        {
            this.StrategyHolder = strategyHolder;
        }

        public GarbageProcessor() : this(new StrategyHolder())
        {
        }

        public IStrategyHolder StrategyHolder { get; private set; }

        public IProcessingData ProcessWaste(IWaste garbage)
        {
            Type type = garbage.GetType();
            DisposableAttribute disposalAttribute = (DisposableAttribute)type.GetCustomAttributes(false).FirstOrDefault(x => x.GetType().IsSubclassOf(typeof(DisposableAttribute)));
            IGarbageDisposalStrategy currentStrategy;
            if (disposalAttribute == null || !this.StrategyHolder.GetDisposalStrategies.TryGetValue(disposalAttribute.GetType(), out currentStrategy))
            {
                throw new ArgumentException(
                    "The passed in garbage does not implement a supported Disposable Strategy Attribute.");
            }

            return currentStrategy.ProcessGarbage(garbage);
        }
    }
}
