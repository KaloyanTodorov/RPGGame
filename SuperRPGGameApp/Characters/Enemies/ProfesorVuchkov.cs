namespace SuperRPGGameApp.Characters.Enemies
{
    public class ProfesorVuchkov : Enemy
    {
        private const int VuchkovHealth = 100;
        private const int VuchkovDamage = 150;
        
        public ProfesorVuchkov(Position position)
            : base(VuchkovHealth, VuchkovDamage, position)
        {
        }
    }
}
