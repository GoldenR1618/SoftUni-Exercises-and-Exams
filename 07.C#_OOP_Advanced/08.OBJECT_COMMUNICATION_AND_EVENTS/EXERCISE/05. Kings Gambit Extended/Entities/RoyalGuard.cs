using System;

namespace _05.KingGambitExtended.Entities
{
    public class RoyalGuard : Soldier
    {
        private const int DefaultHealth = 3;

        public RoyalGuard(string name) : base(name, DefaultHealth)
        {
        }

        public override void ProtectKing(object sourse, EventArgs args)
        {
            Console.WriteLine($"Royal Guard {this.Name} is defending!");
        }
    }
}