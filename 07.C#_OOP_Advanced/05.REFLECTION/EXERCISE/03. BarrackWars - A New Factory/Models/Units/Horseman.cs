namespace _03BarracksFactory.Models.Units
{
    public class Horseman : Unit
    {
        private const int DefaultHealth = 68;
        private const int DefaultDamage = 47;

        public Horseman() 
            : base(DefaultHealth, DefaultDamage)
        {
        }
    }
}
