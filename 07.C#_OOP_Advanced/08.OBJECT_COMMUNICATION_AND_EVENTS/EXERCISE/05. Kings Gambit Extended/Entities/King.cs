using System;

namespace _05.KingGambitExtended.Entities
{
    public delegate void KingUnderAttackHandler(object sourse, EventArgs e);

    public class King
    {
        public event KingUnderAttackHandler KingAttacked;

        public King(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void Attack()
        {
            this.OnKingAttack(this.Name);
        }

        protected virtual void OnKingAttack(string name)
        {
            Console.WriteLine($"King {this.Name} is under attack!");

            if (KingAttacked != null)
            {
                KingAttacked(this, EventArgs.Empty);
            }
        }
    }
}