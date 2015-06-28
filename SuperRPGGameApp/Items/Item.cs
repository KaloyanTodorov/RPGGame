namespace SuperRPGGameApp.Items
{
    public abstract class Item : GameObject
    {
        protected Item(int health, int damage, Position position) 
            : base(health, damage)
        {
        }
    }
}
