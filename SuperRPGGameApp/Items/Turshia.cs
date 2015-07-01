namespace SuperRPGGameApp.Items
{
    public class Turshia : Item
    {
        private const int TurshiaHealth = 50;
        private const int TurshiaDamage = 0;
        
        public Turshia(Position position)
            : base(position,'O')
        {
        }
    }
}
