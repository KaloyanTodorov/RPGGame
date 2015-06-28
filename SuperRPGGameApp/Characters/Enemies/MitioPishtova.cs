namespace SuperRPGGameApp.Characters.Enemies
{
    public class MitioPishtova : Enemy
    {
        private const int MitioHealth = 100;
        private const int MitioDamage = 200;
        
        public MitioPishtova(Position position)
            : base(MitioHealth, MitioDamage, position)
        {
        }
    }
}
