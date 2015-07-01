using SuperRPGGameApp.Interfaces;

namespace SuperRPGGameApp.Characters
{
    public class Enemy : Character, IAttack
    {
        public Enemy(int health, int damage, Position position) 
            : base(health, damage)
        {
            this.Position = position;
        }

        public Position Position { get; set; } //set validation
        
        public void Attack(Character enemy)
        {
        }
    }
}
