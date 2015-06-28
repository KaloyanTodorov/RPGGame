﻿namespace SuperRPGGameApp.Items
{
    class Musaka : Item
    {
        private const int MusakaHealth = 100;
        private const int MusakaDamage = 0;
        
        public Musaka(Position position)
            : base(MusakaHealth, MusakaDamage, position)
        {
        }
    }
}