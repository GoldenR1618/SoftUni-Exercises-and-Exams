namespace _02.Blobs.Interfaces
{
    using Entities;

    public interface IAttack
    {
        void Execute(Blob attacker, Blob target);
    }
}