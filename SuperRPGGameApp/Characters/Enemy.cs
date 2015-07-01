using SuperRPGGameApp.Interfaces;

namespace SuperRPGGameApp.Characters
{
    public class Enemy : Character, IAttack
    {
<<<<<<< HEAD
        private Position position;

        public Enemy(Position position, char objectSymbol, string name)
            : base(position, 'W', name, 10,10)
=======
        public Enemy(int health, int damage, Position position) 
            : base(health, damage)
>>>>>>> e361981c8ad034c9971d16b7a3ec22b99d67c5a3
        {
            this.Position = position;
        }

<<<<<<< HEAD
        public Position Position { get; set; } 
=======
        public Position Position { get; set; } //set validation
        
        public void Attack(Character enemy)
        {
        }
>>>>>>> e361981c8ad034c9971d16b7a3ec22b99d67c5a3
    }
}
