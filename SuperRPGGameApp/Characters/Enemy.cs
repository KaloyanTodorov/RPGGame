namespace SuperRPGGameApp.Characters
{
    public class Enemy : Character
    {
        private Position position;

        public Enemy(Position position, char objectSymbol, string name)
            : base(position, 'W', name, 10,10)
        {
            this.Position = position;
        }

        public Position Position { get; set; } 
    }
}
