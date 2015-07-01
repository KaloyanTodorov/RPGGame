namespace SuperRPGGameApp.Items
{
    public class Vydica : Item
    {
        private const int VydicaHealth = 0;
        private const int VydicaDamage = 20;
        
        public Vydica(Position position)
            : base(VydicaHealth, VydicaDamage, position)
        {
        }
    }
}
