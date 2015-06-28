namespace SuperRPGGameApp.Characters.Enemies
{
    public class LiliIvanova : Enemy
    {
        private const int LiliHealth = 500;
        private const int LiliDamage = 50;
        
        public LiliIvanova(Position position)
            : base(LiliHealth, LiliDamage, position)
        {
        }
    }
}