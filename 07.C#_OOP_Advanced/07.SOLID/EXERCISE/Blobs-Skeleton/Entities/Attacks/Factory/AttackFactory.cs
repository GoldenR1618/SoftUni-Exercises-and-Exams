namespace _02.Blobs.Entities.Attacks.Factory
{
    using System;
    using System.Linq;
    using System.Reflection;
    using _02.Blobs.Interfaces;

    public class AttackFactory
    {
        private const string BehvaiorNameSuffix = "Attack";

        public IAttack CreateAttack(string behaviorTypeStr)
        {
            string behaviorCompleteName = behaviorTypeStr + BehvaiorNameSuffix;
            Type behaviorType = Assembly.GetExecutingAssembly().GetTypes().First(t => t.Name == behaviorCompleteName);
            return (IAttack)Activator.CreateInstance(behaviorType);
        }
    }
}