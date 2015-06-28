namespace SuperRPGGameApp.Characters.Enemies
{
    public class Azis : Enemy
    {
        private const int AzisHealth = 100;
        private const int AzisDamage = 100;
        
        public Azis(Position position)
            : base(AzisHealth, AzisDamage, position)
        {
        }
    }
}
