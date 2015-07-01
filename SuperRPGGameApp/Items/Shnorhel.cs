namespace SuperRPGGameApp.Items
{
    public class Shnorhel : Item
    {
        private const int ShnorhelHealth = 0;
        private const int ShnorhelDamage = 40;
        
        public Shnorhel(Position position)
            : base(ShnorhelHealth, ShnorhelDamage, position)
        {
        }
    }
}
