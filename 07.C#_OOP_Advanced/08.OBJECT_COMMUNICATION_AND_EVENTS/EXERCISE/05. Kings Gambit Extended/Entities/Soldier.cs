using System;

namespace _05.KingGambitExtended.Entities
{
    public abstract class Soldier
    {
        protected Soldier(string name, int health)
        {
            this.Name = name;
            this.Health = health;
        }

        public string Name { get; set; }

        public int Health { get; set; }

        public abstract void ProtectKing(object sourse, EventArgs args);
    }
}