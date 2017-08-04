namespace _03BarracksFactory.Models.Units
{
    public class Gunner : Unit
    {
        private const int DefaultHealth = 35;
        private const int DefaultDamage = 57;

        public Gunner() 
            : base(DefaultHealth, DefaultDamage)
        {
        }
    }
}
