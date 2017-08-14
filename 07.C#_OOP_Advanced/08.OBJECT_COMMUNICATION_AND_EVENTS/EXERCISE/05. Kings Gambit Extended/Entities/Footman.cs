using System;

namespace _05.KingGambitExtended.Entities
{
    public class Footman : Soldier
    {
        private const int DefaultHealth = 2;

        public Footman(string name) : base(name, DefaultHealth)
        {
        }

        public override void ProtectKing(object sourse, EventArgs args)
        {
            Console.WriteLine($"Footman {this.Name} is panicking!");
        }
    }
}