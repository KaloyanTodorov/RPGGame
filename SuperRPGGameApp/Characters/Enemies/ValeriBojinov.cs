namespace SuperRPGGameApp.Characters.Enemies
{
    public class ValeriBojinov : Enemy
    {
        private const int BojinkataHealth = 200;
        private const int BojinkataDamage = 50;
        
        public ValeriBojinov(Position position)
            : base(BojinkataHealth, BojinkataDamage, position)
        {
        }
    }
}
