namespace SuperRPGGameApp.Items
{
    class Mastika : Item
    {
        private const int MastikaHealth = 100;
        private const int MastikaDamage = 0;
        
        public Mastika(Position position)
            : base( position,'K')
        {
        }
    }
}
