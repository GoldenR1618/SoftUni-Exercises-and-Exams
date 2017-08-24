namespace RecyclingStation.Core
{
    using System;
    using System.Linq;
    using System.Reflection;
    using RecyclingStation.Interfaces;
    using RecyclingStation.Models;
    using RecyclingStation.WasteDisposal;
    using RecyclingStation.WasteDisposal.Attributes;
    using RecyclingStation.WasteDisposal.Interfaces;

    public class CommandHandler : ICommandHandler
    {
        public CommandHandler(IBalanceManager balanceManager, IGarbageProcessor garbageProcessor)
        {
            this.GarbageProcessor = garbageProcessor;
            this.BalanceManager = balanceManager;
            this.InitializeStrategies();

        }

        public CommandHandler() : this(new BalanceManager(), new GarbageProcessor())
        {
        }

        public IGarbageProcessor GarbageProcessor { get; private set; }

        public IBalanceManager BalanceManager { get; private set; }

        public string ProcessGarbage(string[] parameters)
        {
            IWaste garbage = this.InstantiateWaste(parameters);
            if (this.BalanceManager.CheckWasteForProcessing(garbage))
            {
                IProcessingData result = this.GarbageProcessor.ProcessWaste(garbage);
                this.BalanceManager.ApplyProcessingResult(result);
                return string.Format("{0:F2} kg of {1} successfully processed!", garbage.Weight, garbage.Name);
            }

            return "Processing Denied!";
        }

        public string ChangeManagementRequirement(string[] parameters)
        {
            IManagementRequirement requirement = this.InstantiateManagementRequirement(parameters);
            this.BalanceManager.ManagmentRequirement = requirement;
            return "Management requirement changed!";
        }

        public string Status()
        {
            return string.Format("Energy: {0:F2} Capital: {1:F2}", this.BalanceManager.EnergyBalance,
                this.BalanceManager.CapitalBalance);
        }

        //Initialize and load all attribute classes and strategies in the StrategyHolder
        private void InitializeStrategies()
        {
            var assemblyTypes = Assembly.GetExecutingAssembly().DefinedTypes as TypeInfo[]
                ?? Assembly.GetExecutingAssembly().DefinedTypes.ToArray();

            //get all strategies Types that implement IGarbageDisposalStrategy interface, are not abstract classes
            //or interfaces and are not the actual type IGarbageDisposalStrategy
            var strategies = assemblyTypes.Where(x => typeof(IGarbageDisposalStrategy).IsAssignableFrom(x) &&
                x != typeof(IGarbageDisposalStrategy) &&
                !x.IsAbstract &&
                !x.IsInterface);


            var attributes = assemblyTypes.Where(x => typeof(DisposableAttribute).IsAssignableFrom(x) &&
                x != typeof(DisposableAttribute) &&
                !x.IsAbstract);

            foreach (var attribute in attributes)
            {
                //match the corresponding strategy type to the current attribute type
                // instantiate it and send it to the StrategyHolder for mapping
                string strategyName = attribute.Name.Replace("Attribute", "Strategy");
                var strategy = strategies.FirstOrDefault(x => x.Name == strategyName);
                if (strategy != null)
                {
                    var stratInstance = (IGarbageDisposalStrategy)Activator.CreateInstance(strategy);
                    this.GarbageProcessor.StrategyHolder.AddStrategy(attribute, stratInstance);
                }
            }
        }

        private IWaste InstantiateWaste(string[] parameters)
        {
            string type = parameters[3];
            string garbageTypeName = type + "Garbage";
            Type garbageType = Assembly.GetExecutingAssembly().DefinedTypes.FirstOrDefault(x => x.Name == garbageTypeName);
            if (garbageType == null)
            {
                throw new ArgumentException("Unsupported garbage type passed!");
            }

            ConstructorInfo constructor = garbageType.GetConstructors()[0];
            ParameterInfo[] constructorParams = constructor.GetParameters();
            object[] convertedParameters = new object[constructorParams.Length];
            for (int i = 0; i < convertedParameters.Length; i++)
            {
                Type parameterType = constructorParams[i].ParameterType;
                if (typeof(IConvertible).IsAssignableFrom(parameterType))
                {
                    convertedParameters[i] = Convert.ChangeType(parameters[i], parameterType);
                }
            }

            IWaste garbage = (IWaste)Activator.CreateInstance(garbageType, convertedParameters);
            return garbage;
        }

        private IManagementRequirement InstantiateManagementRequirement(string[] parameters)
        {
            string type = parameters[2];
            string garbageTypeName = type + "Garbage";
            Type garbageType = Assembly.GetExecutingAssembly().DefinedTypes.FirstOrDefault(x => x.Name == garbageTypeName);
            double minEnergyBalance = double.Parse(parameters[0]);
            double minCapitalBalance = double.Parse(parameters[1]);
            IManagementRequirement requirement = new ManagementRequirement(minEnergyBalance, minCapitalBalance, garbageType);

            return requirement;
        }
    }
}
