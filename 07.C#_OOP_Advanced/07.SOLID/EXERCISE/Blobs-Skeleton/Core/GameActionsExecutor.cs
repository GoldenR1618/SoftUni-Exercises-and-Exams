namespace _02.Blobs.Core
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Entities;
    using Entities.Attacks.Factory;
    using Entities.Behaviors.Factory;
    using Interfaces;
    using Interfaces.IO;

    public class GameActionsExecutor
    {
        private IDictionary<string, Blob> blobs;
        private BehaviorFactory behaviorFactory;
        private AttackFactory attackFactory;

        public GameActionsExecutor()
        {
            this.blobs = new Dictionary<string, Blob>();
            this.behaviorFactory = new BehaviorFactory();
            this.attackFactory = new AttackFactory();
        }

        private void CreateBlob(IList<string> actionTokens)
        {
            string name = actionTokens[0];
            int health = int.Parse(actionTokens[1]);
            int damage = int.Parse(actionTokens[2]);
            IBehavior behavior = this.behaviorFactory.CreateBehavior(actionTokens[3]);
            IAttack attack = this.attackFactory.CreateAttack(actionTokens[4]);

            this.blobs.Add(name, new Blob(name, health, damage, behavior, attack));
        }

        private void GetStatus(IWriter writer)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Blob blob in this.blobs.Values)
            {
                sb.AppendLine(blob.ToString());
            }

            writer.WriteLine(sb.ToString().Trim());
        }

        private void ExecuteAttack(IList<string> actionTokens)
        {
            string attackerName = actionTokens[0];
            string targetName = actionTokens[1];

            this.blobs[attackerName].Attack(this.blobs[targetName]);
        }

        private void RollTurn()
        {
            foreach (Blob blob in this.blobs.Values)
            {
                blob.MoveToNextTurn();
            }
        }

        public void PlayAction(string action, IWriter writer)
        {
            IList<string> actionTokens = action.Split().ToList();
            string actionType = actionTokens[0];
            actionTokens.RemoveAt(0);

            switch (actionType)
            {
                case "create":
                    this.CreateBlob(actionTokens);
                    break;
                case "attack":
                    this.ExecuteAttack(actionTokens);
                    break;
                case "status":
                    this.GetStatus(writer);
                    break;
            }

            this.RollTurn();
        }
    }
}