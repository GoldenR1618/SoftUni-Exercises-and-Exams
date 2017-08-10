namespace _02.Blobs.Entities.Behaviors.Factory
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Interfaces;

    public class BehaviorFactory
    {
        private const string BehvaiorNameSuffix = "Behavior";

        public IBehavior CreateBehavior(string behaviorTypeStr)
        {
            string behaviorCompleteName = behaviorTypeStr + BehvaiorNameSuffix;
            Type behaviorType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .First(t => t.Name == behaviorCompleteName);
            return (IBehavior) Activator.CreateInstance(behaviorType);
        }
    }
}
