namespace RecyclingStation.WasteDisposal
{
    using System;
    using System.Collections.Generic;
    using RecyclingStation.WasteDisposal.Attributes;
    using RecyclingStation.WasteDisposal.Interfaces;

    public class StrategyHolder : IStrategyHolder
    {
        private readonly IDictionary<Type, IGarbageDisposalStrategy> strategies;

        public StrategyHolder()
        {
            this.strategies = new Dictionary<Type, IGarbageDisposalStrategy>();
        }

        public IReadOnlyDictionary<Type,IGarbageDisposalStrategy> GetDisposalStrategies
        {
            get { return (IReadOnlyDictionary<Type, IGarbageDisposalStrategy>)this.strategies; }
        }

        public bool AddStrategy(Type disposableAttribute, IGarbageDisposalStrategy strategy)
        {
            if (!disposableAttribute.IsSubclassOf(typeof(DisposableAttribute)) || disposableAttribute.IsAbstract)
            {
                throw new ArgumentException("The passed in type is not a subclass of Disposable Attribute!");
            }

            if (this.strategies.ContainsKey(disposableAttribute))
            {
                return false;
            }

            this.strategies.Add(disposableAttribute, strategy);
            return true;
        }

        public bool RemoveStrategy(Type disposableAttribute)
        {
            if (!disposableAttribute.IsSubclassOf(typeof(DisposableAttribute)) || disposableAttribute.IsAbstract)
            {
                throw new ArgumentException("The passed in type is not a subclass of Disposable Attribute!");
            }

            if (!this.strategies.ContainsKey(disposableAttribute))
            {
                return false;
            }

            this.strategies.Remove(disposableAttribute);
            return true;
        }
    }
}
