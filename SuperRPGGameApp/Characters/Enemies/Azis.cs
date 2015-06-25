namespace SuperRPGGameApp.Characters.Enemies
{
    class Azis : Character
    {
        private const int AzisHealth = 100;
        private const int AzisDamage = 100;
        
        public Azis(Position position)
            : base(AzisHealth, AzisDamage)
        {
            this.Position = position;
        }

        public Position Position { get; set; }
    }
}
