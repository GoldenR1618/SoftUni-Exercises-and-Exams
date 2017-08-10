namespace _02.Blobs.Entities.Attacks
{
    using Interfaces;

    public abstract class Attack : IAttack
    {
        public abstract void Execute(Blob attacker, Blob target);
    }
}