namespace _02.Blobs.Entities.Attacks
{
    public class BlobplodeAttack : Attack
    {
        private const int DamageMultiplier = 2;
        private const int MinimumHealth = 1;

        public override void Execute(Blob attacker, Blob target)
        {
            int healthLoss = attacker.Health / 2;
            if (healthLoss < MinimumHealth)
            {
                attacker.Health = MinimumHealth;
            }
            else
            {
                attacker.Health -= healthLoss;
            }

            target.Health -= attacker.Damage * DamageMultiplier;
        }
    }
}