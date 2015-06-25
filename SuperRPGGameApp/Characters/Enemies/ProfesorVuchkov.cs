namespace SuperRPGGameApp.Characters.Enemies
{
    public class ProfesorVuchkov : Character
    {
        private const int VuchkovHealth = 100;
        private const int VuchkovDamage = 150;
        
        public ProfesorVuchkov()
            : base(VuchkovHealth, VuchkovDamage)
        {
        }
    }
}
