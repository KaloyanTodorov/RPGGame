namespace SuperRPGGameApp.Characters
{
    public abstract class Character : GameObject
    {
        protected Character(int health, int damage)
            :base(health, damage)
        {
        }
    }
}
