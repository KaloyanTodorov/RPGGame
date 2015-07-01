namespace SuperRPGGameApp.Items
{
    public class Musaka : Item
    {
        private const int MusakaHealth = 100;
        private const int MusakaDamage = 0;
        
        public Musaka(Position position)
            : base( position,'M')
        {
        }
    }
}
